using System.Data;
using System.IO;
using System.Windows.Forms;

namespace XmlRefactor.UI
{
    public partial class XmlGridView : UserControl
    {

        private bool _mBGridViewModeReadError;

        public enum V�ewMode {Xml, Table}
        public V�ewMode ViewMode
        {
            set => SetViewMode(value);
        }

        private string _mSDataFilePath = string.Empty;
        public string DataFilePath
        {
            set
            {
                _mSDataFilePath = value;
                LoadDataFile();
            }
        }

        private int _mNDataSetTableIndex;
        public int DataSetTableIndex
        {
            get => _mNDataSetTableIndex;
            set => SetDataSetTableIndex(value);
        }

        public int DataTableCount { get; private set; }

        public XmlGridView()
        {
            InitializeComponent();

            SetViewMode(V�ewMode.Xml);
        }

        private void SetViewMode(V�ewMode mode)
        {
            if (_mBGridViewModeReadError)
            {
                mode = V�ewMode.Xml;
            }

            if(mode == V�ewMode.Xml)
            {
                webXmlView.Visible = true;
                grdTableView.Visible = false;
            }
            else
            {
                webXmlView.Visible = false;
                grdTableView.Visible = true;
            }
        }

        private void LoadDataFile()
        {
            _mBGridViewModeReadError = false;

            // use the webbrowser control to automatically parse the file
            webXmlView.Navigate(_mSDataFilePath);

            if ((_mSDataFilePath != string.Empty) && File.Exists(_mSDataFilePath))
            {
                // Creates a DataSet and loads it with the xml content
                try
                {
                    var dsXmlFile = new DataSet();
                    dsXmlFile.ReadXml(_mSDataFilePath, XmlReadMode.Auto);
                    DataTableCount = dsXmlFile.Tables.Count;

                    grdTableView.DataSource = dsXmlFile.Tables[DataSetTableIndex];
                }
                catch
                {
                    _mBGridViewModeReadError = true;
                    DataTableCount = 0;
                    webXmlView.Navigate(_mSDataFilePath);
                    SetViewMode(V�ewMode.Xml);
                }
            }
            else
            {
                grdTableView.DataSource = null;
            }
        }

        private void SetDataSetTableIndex(int nTableIndex)
        {
            if (nTableIndex >= DataTableCount)
                return;

            _mNDataSetTableIndex = nTableIndex;
            LoadDataFile();
        }
    }
}
