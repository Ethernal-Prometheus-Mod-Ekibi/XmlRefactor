using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace XmlRefactor.UI
{
    public partial class TranslateUı : Form
    {
        private string FilenameValue { get; }

        public TranslateUı(MainUı mainForm)
        {
            InitializeComponent();
            FilenameValue = mainForm.GetFilenameValue();

            txt_filename.Text = FilenameValue;
            ViewXml();
        }

        // DATAGRID

        private static int DataTableCount { get; set; }

        private static string _mSDataFilePath = string.Empty;

        private string DataFilePath
        {
            get => _mSDataFilePath;
            set
            {
                _mSDataFilePath = value;
                LoadDataFile();
            }
        }

        private int DataSetTableIndex
        {
            set => SetDataSetTableIndex(value);
        }

        private void LoadDataFile()
        {
            if ((_mSDataFilePath != string.Empty) && File.Exists(_mSDataFilePath))
            {
                // Creates a DataSet and loads it with the xml content
                try
                {
                    var dsXmlFile = new DataSet();
                    dsXmlFile.ReadXml(_mSDataFilePath, XmlReadMode.Auto);
                    DataTableCount = dsXmlFile.Tables.Count;

                    // DataGridView'ı güncellemek için tüm tabloları dolaşın ve içerikleri yükleyin.
                    foreach (var index in _dataGridViews.Keys)
                    {
                        var dataGridView = _dataGridViews[index];
                        if (index >= 0 && index < dsXmlFile.Tables.Count)
                        {
                            dataGridView.DataSource = dsXmlFile.Tables[index];
                        }
                        else
                        {
                            dataGridView.DataSource = null;
                        }
                    }
                }
                catch
                {
                    DataTableCount = 0;
                }
            }
            else
            {
                // Dosya mevcut değilse DataGridView'ı temizle.
                foreach (var dataGridView in _dataGridViews.Values)
                {
                    dataGridView.DataSource = null;
                }
            }
        }


        private void SetDataSetTableIndex(int nTableIndex)
        {
            if (nTableIndex >= DataTableCount)
                return;

            LoadDataFile();
        }

        private readonly Dictionary<int, DataGridView> _dataGridViews = new Dictionary<int, DataGridView>();

        private void ViewXml()
        {
            if (txt_filename.Text != string.Empty && File.Exists(txt_filename.Text))
            {
                DataFilePath = txt_filename.Text;

                cmbTableIndex.Items.Clear();
                for (var i = 0; i < DataTableCount; i++)
                {
                    cmbTableIndex.Items.Add(i.ToString());

                    // Her tablo için yeni bir sekme oluşturun ve DataGridView ekleyin.
                    var tabPage = new TabPage("Table " + i);
                    var dataGridView = new DataGridView
                    {
                        Dock = DockStyle.Fill
                    };
                    tabPage.Controls.Add(dataGridView);

                    // DataGridView'ı tabloya eşleştirin.
                    _dataGridViews.Add(i, dataGridView);

                    tabControl.TabPages.Add(tabPage);
                }

                var lastIndex = cmbTableIndex.Items.Count - 1;
                cmbTableIndex.SelectedIndex = lastIndex;
                DataSetTableIndex = Convert.ToInt32(cmbTableIndex.Text.Trim());
            }
        }

        private void SelectXmlTableIndex(object sender, EventArgs e)
        {
            DataSetTableIndex = Convert.ToInt32(cmbTableIndex.Text.Trim());
        }

        private void SaveFile(object sender, EventArgs e)
        {
            if (_dataGridViews.Count == 0)
            {
                MessageBox.Show(@"Hiç tablo bulunmuyor.", @"Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DataFilePath != string.Empty && File.Exists(DataFilePath))
            {
                var dsXmlFile = new DataSet();
                dsXmlFile.ReadXml(DataFilePath, XmlReadMode.Auto);

                foreach (var index in _dataGridViews.Keys)
                {
                    if (index >= 0 && index < dsXmlFile.Tables.Count)
                    {
                        var selectedTable = dsXmlFile.Tables[index];
                        var dataGridView = _dataGridViews[index];

                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            var xmlRow = selectedTable.Rows[row.Index];

                            for (var i = 0; i < dataGridView.Columns.Count; i++)
                            {
                                if (i < xmlRow.ItemArray.Length) // İlgili sütun sayısını aşmadan kontrol edin
                                {
                                    xmlRow[i] = row.Cells[i].Value;
                                }
                            }
                        }
                    }
                }

                try
                {
                    dsXmlFile.WriteXml(DataFilePath); // Verileri güncelle
                    MessageBox.Show(@"Düzenlenmiş veriler başarıyla kaydedildi.", @"Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Veriler kaydedilirken bir hata oluştu: " + ex.Message, @"Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(@"Dosya yolu geçersiz veya dosya mevcut değil.", @"Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
