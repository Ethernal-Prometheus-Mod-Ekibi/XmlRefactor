using System.ComponentModel;
using System.Windows.Forms;
using EO.WebBrowser;
using EO.WinForm;

namespace XmlRefactor.UI
{
    partial class MainUı
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this._sDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_TR = new System.Windows.Forms.Button();
            this.btn_EN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.webControl1 = new EO.WinForm.WebControl();
            this.webView1 = new EO.WebBrowser.WebView();
            this.txt_link = new System.Windows.Forms.TextBox();
            this.btn_wbhome = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.txtFile2 = new System.Windows.Forms.TextBox();
            this.chkTableView2 = new System.Windows.Forms.CheckBox();
            this.cmbTableIndex2 = new System.Windows.Forms.ComboBox();
            this.xmlGridView2 = new XmlRefactor.UI.XmlGridView();
            this.btn_file2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_start2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_foldpath2 = new System.Windows.Forms.TextBox();
            this.btn_fold2 = new System.Windows.Forms.Button();
            this.txt_filename2 = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_file = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.cmb_langnum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_foldpath = new System.Windows.Forms.TextBox();
            this.btn_fold = new System.Windows.Forms.Button();
            this.txt_filename = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.chkTableView = new System.Windows.Forms.CheckBox();
            this.cmbTableIndex = new System.Windows.Forms.ComboBox();
            this.xmlGridView = new XmlRefactor.UI.XmlGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btn_Revert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.ForeColor = System.Drawing.Color.Green;
            this.progressBar1.Location = new System.Drawing.Point(0, 366);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(553, 23);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Value = 100;
            // 
            // _sDialog
            // 
            this._sDialog.CheckFileExists = true;
            this._sDialog.CreatePrompt = true;
            this._sDialog.DefaultExt = "xml";
            this._sDialog.RestoreDirectory = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(545, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Info & Settings";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.86705F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.13295F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 219F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(539, 334);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(277, 3);
            this.groupBox2.Name = "groupBox2";
            this.tableLayoutPanel2.SetRowSpan(this.groupBox2, 2);
            this.groupBox2.Size = new System.Drawing.Size(259, 108);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_TR, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btn_EN, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(253, 89);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label5, 2);
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 44);
            this.label5.TabIndex = 0;
            this.label5.Text = "Set Tool Display Language";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_TR
            // 
            this.btn_TR.BackColor = System.Drawing.Color.DarkRed;
            this.btn_TR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_TR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TR.ForeColor = System.Drawing.Color.White;
            this.btn_TR.Location = new System.Drawing.Point(3, 47);
            this.btn_TR.Name = "btn_TR";
            this.btn_TR.Size = new System.Drawing.Size(120, 39);
            this.btn_TR.TabIndex = 1;
            this.btn_TR.Text = "TR";
            this.btn_TR.UseVisualStyleBackColor = false;
            this.btn_TR.Click += new System.EventHandler(this.SetLangTr);
            // 
            // btn_EN
            // 
            this.btn_EN.BackColor = System.Drawing.Color.White;
            this.btn_EN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_EN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EN.ForeColor = System.Drawing.Color.Black;
            this.btn_EN.Location = new System.Drawing.Point(129, 47);
            this.btn_EN.Name = "btn_EN";
            this.btn_EN.Size = new System.Drawing.Size(121, 39);
            this.btn_EN.TabIndex = 2;
            this.btn_EN.Text = "EN";
            this.btn_EN.UseVisualStyleBackColor = false;
            this.btn_EN.Click += new System.EventHandler(this.SetLangEn);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel2.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(268, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "About Us";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.linkLabel1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.linkLabel2, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(262, 89);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::XmlRefactor.Properties.Resources._135021266;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel3.SetRowSpan(this.pictureBox1, 3);
            this.pictureBox1.Size = new System.Drawing.Size(81, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(90, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ethernal Prometheus Mod Team";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel1.Location = new System.Drawing.Point(90, 29);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(169, 29);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Visit to GitHub";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoGithubPage);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel2.Location = new System.Drawing.Point(90, 58);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(169, 31);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Join Discord Channel";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoDiscordChannel);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 7;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel6, 2);
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel6.Controls.Add(this.webControl1, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.txt_link, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.btn_wbhome, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 117);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.95327F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.04673F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(533, 214);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // webControl1
            // 
            this.webControl1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel6.SetColumnSpan(this.webControl1, 7);
            this.webControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webControl1.Location = new System.Drawing.Point(3, 34);
            this.webControl1.Name = "webControl1";
            this.webControl1.Size = new System.Drawing.Size(527, 177);
            this.webControl1.TabIndex = 2;
            this.webControl1.Text = "webControl1";
            this.webControl1.WebView = this.webView1;
            // 
            // webView1
            // 
            this.webView1.Url = "https://github.com/Ethernal-Prometheus-Mod-Ekibi/XmlRefactor/releases";
            this.webView1.UrlChanged += new System.EventHandler(this.ShowNowPage);
            // 
            // txt_link
            // 
            this.txt_link.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_link.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel6.SetColumnSpan(this.txt_link, 5);
            this.txt_link.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_link.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_link.Location = new System.Drawing.Point(155, 3);
            this.txt_link.Name = "txt_link";
            this.txt_link.ReadOnly = true;
            this.txt_link.Size = new System.Drawing.Size(375, 20);
            this.txt_link.TabIndex = 3;
            this.txt_link.Text = "https://github.com/Ethernal-Prometheus-Mod-Ekibi/XmlRefactor/releases";
            // 
            // btn_wbhome
            // 
            this.btn_wbhome.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel6.SetColumnSpan(this.btn_wbhome, 2);
            this.btn_wbhome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_wbhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_wbhome.ForeColor = System.Drawing.Color.White;
            this.btn_wbhome.Location = new System.Drawing.Point(3, 3);
            this.btn_wbhome.Name = "btn_wbhome";
            this.btn_wbhome.Size = new System.Drawing.Size(146, 25);
            this.btn_wbhome.TabIndex = 4;
            this.btn_wbhome.Text = "Check Latest Releases";
            this.btn_wbhome.UseVisualStyleBackColor = false;
            this.btn_wbhome.Click += new System.EventHandler(this.GoMainPage);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(545, 340);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Translater";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox4, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.btn_file2, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_start2, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.comboBox1, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.txt_foldpath2, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.btn_fold2, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.txt_filename2, 3, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 5;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(539, 334);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.groupBox4, 4);
            this.groupBox4.Controls.Add(this.tableLayoutPanel8);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(3, 119);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(533, 212);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "XML";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 4;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.65491F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.34509F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel8.Controls.Add(this.txtFile2, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.chkTableView2, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.cmbTableIndex2, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.xmlGridView2, 0, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.50777F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.49223F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(527, 193);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // txtFile2
            // 
            this.txtFile2.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel8.SetColumnSpan(this.txtFile2, 2);
            this.txtFile2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFile2.ForeColor = System.Drawing.Color.White;
            this.txtFile2.Location = new System.Drawing.Point(3, 3);
            this.txtFile2.Name = "txtFile2";
            this.txtFile2.ReadOnly = true;
            this.txtFile2.Size = new System.Drawing.Size(366, 20);
            this.txtFile2.TabIndex = 63;
            // 
            // chkTableView2
            // 
            this.chkTableView2.AutoSize = true;
            this.chkTableView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkTableView2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkTableView2.Location = new System.Drawing.Point(375, 3);
            this.chkTableView2.Name = "chkTableView2";
            this.chkTableView2.Size = new System.Drawing.Size(77, 21);
            this.chkTableView2.TabIndex = 61;
            this.chkTableView2.Text = "Table View";
            this.chkTableView2.UseVisualStyleBackColor = true;
            this.chkTableView2.CheckedChanged += new System.EventHandler(this.XmlSetView2);
            // 
            // cmbTableIndex2
            // 
            this.cmbTableIndex2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cmbTableIndex2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTableIndex2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTableIndex2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTableIndex2.ForeColor = System.Drawing.Color.White;
            this.cmbTableIndex2.Location = new System.Drawing.Point(458, 3);
            this.cmbTableIndex2.Name = "cmbTableIndex2";
            this.cmbTableIndex2.Size = new System.Drawing.Size(66, 21);
            this.cmbTableIndex2.TabIndex = 62;
            this.cmbTableIndex2.SelectedIndexChanged += new System.EventHandler(this.SelectXmlTableIndex2);
            // 
            // xmlGridView2
            // 
            this.xmlGridView2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.tableLayoutPanel8.SetColumnSpan(this.xmlGridView2, 4);
            this.xmlGridView2.DataSetTableIndex = 0;
            this.xmlGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xmlGridView2.ForeColor = System.Drawing.Color.White;
            this.xmlGridView2.Location = new System.Drawing.Point(3, 30);
            this.xmlGridView2.Name = "xmlGridView2";
            this.xmlGridView2.Size = new System.Drawing.Size(521, 160);
            this.xmlGridView2.TabIndex = 65;
            // 
            // btn_file2
            // 
            this.btn_file2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_file2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_file2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_file2.Location = new System.Drawing.Point(271, 32);
            this.btn_file2.Name = "btn_file2";
            this.btn_file2.Size = new System.Drawing.Size(128, 23);
            this.btn_file2.TabIndex = 8;
            this.btn_file2.Text = "Select Target File";
            this.btn_file2.UseVisualStyleBackColor = false;
            this.btn_file2.Click += new System.EventHandler(this.Select_File2);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel5.SetColumnSpan(this.label3, 4);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(533, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "THANKS FOR USING THIS TOOL <3 - Please give feedback on GITHUB";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_start2
            // 
            this.btn_start2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.tableLayoutPanel5.SetColumnSpan(this.btn_start2, 4);
            this.btn_start2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_start2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_start2.Location = new System.Drawing.Point(3, 90);
            this.btn_start2.Name = "btn_start2";
            this.btn_start2.Size = new System.Drawing.Size(533, 23);
            this.btn_start2.TabIndex = 0;
            this.btn_start2.Text = "Translate XML File";
            this.btn_start2.UseVisualStyleBackColor = false;
            this.btn_start2.Click += new System.EventHandler(this.StartTranslate);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "7",
            "33",
            "34",
            "39",
            "44",
            "45",
            "49",
            "81",
            "82",
            "86",
            "88"});
            this.comboBox1.Location = new System.Drawing.Point(137, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Select Language :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_foldpath2
            // 
            this.txt_foldpath2.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel5.SetColumnSpan(this.txt_foldpath2, 3);
            this.txt_foldpath2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_foldpath2.ForeColor = System.Drawing.Color.White;
            this.txt_foldpath2.Location = new System.Drawing.Point(137, 61);
            this.txt_foldpath2.Name = "txt_foldpath2";
            this.txt_foldpath2.ReadOnly = true;
            this.txt_foldpath2.Size = new System.Drawing.Size(399, 20);
            this.txt_foldpath2.TabIndex = 6;
            // 
            // btn_fold2
            // 
            this.btn_fold2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_fold2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_fold2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fold2.Location = new System.Drawing.Point(3, 61);
            this.btn_fold2.Name = "btn_fold2";
            this.btn_fold2.Size = new System.Drawing.Size(128, 23);
            this.btn_fold2.TabIndex = 7;
            this.btn_fold2.Text = "Select Folder";
            this.btn_fold2.UseVisualStyleBackColor = false;
            this.btn_fold2.Click += new System.EventHandler(this.Select_Folder);
            // 
            // txt_filename2
            // 
            this.txt_filename2.BackColor = System.Drawing.Color.Gray;
            this.txt_filename2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_filename2.ForeColor = System.Drawing.Color.White;
            this.txt_filename2.Location = new System.Drawing.Point(405, 32);
            this.txt_filename2.Name = "txt_filename2";
            this.txt_filename2.ReadOnly = true;
            this.txt_filename2.Size = new System.Drawing.Size(131, 20);
            this.txt_filename2.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(545, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Refactor";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn_file, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_start, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmb_langnum, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_foldpath, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_fold, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_filename, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_Revert, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(539, 334);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btn_file
            // 
            this.btn_file.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_file.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_file.Location = new System.Drawing.Point(271, 32);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(128, 23);
            this.btn_file.TabIndex = 8;
            this.btn_file.Text = "Select Target File";
            this.btn_file.UseVisualStyleBackColor = false;
            this.btn_file.Click += new System.EventHandler(this.Select_File);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 4);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(533, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "THANKS FOR USING THIS TOOL <3 - Please give feedback on GITHUB";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.tableLayoutPanel1.SetColumnSpan(this.btn_start, 2);
            this.btn_start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_start.Location = new System.Drawing.Point(3, 90);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(262, 23);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Refactor XML File";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.StartRefactor);
            // 
            // cmb_langnum
            // 
            this.cmb_langnum.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cmb_langnum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_langnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_langnum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_langnum.ForeColor = System.Drawing.Color.White;
            this.cmb_langnum.FormattingEnabled = true;
            this.cmb_langnum.Items.AddRange(new object[] {
            "7",
            "33",
            "34",
            "39",
            "44",
            "45",
            "49",
            "81",
            "82",
            "86",
            "88"});
            this.cmb_langnum.Location = new System.Drawing.Point(137, 32);
            this.cmb_langnum.Name = "cmb_langnum";
            this.cmb_langnum.Size = new System.Drawing.Size(128, 21);
            this.cmb_langnum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Language :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_foldpath
            // 
            this.txt_foldpath.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel1.SetColumnSpan(this.txt_foldpath, 3);
            this.txt_foldpath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_foldpath.ForeColor = System.Drawing.Color.White;
            this.txt_foldpath.Location = new System.Drawing.Point(137, 61);
            this.txt_foldpath.Name = "txt_foldpath";
            this.txt_foldpath.ReadOnly = true;
            this.txt_foldpath.Size = new System.Drawing.Size(399, 20);
            this.txt_foldpath.TabIndex = 6;
            // 
            // btn_fold
            // 
            this.btn_fold.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_fold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_fold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fold.Location = new System.Drawing.Point(3, 61);
            this.btn_fold.Name = "btn_fold";
            this.btn_fold.Size = new System.Drawing.Size(128, 23);
            this.btn_fold.TabIndex = 7;
            this.btn_fold.Text = "Select Folder";
            this.btn_fold.UseVisualStyleBackColor = false;
            this.btn_fold.Click += new System.EventHandler(this.Select_Folder);
            // 
            // txt_filename
            // 
            this.txt_filename.BackColor = System.Drawing.Color.Gray;
            this.txt_filename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_filename.ForeColor = System.Drawing.Color.White;
            this.txt_filename.Location = new System.Drawing.Point(405, 32);
            this.txt_filename.Name = "txt_filename";
            this.txt_filename.ReadOnly = true;
            this.txt_filename.Size = new System.Drawing.Size(131, 20);
            this.txt_filename.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox3, 4);
            this.groupBox3.Controls.Add(this.tableLayoutPanel7);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(3, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(533, 212);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "XML";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 4;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.65491F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.34509F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel7.Controls.Add(this.txtFile, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.chkTableView, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.cmbTableIndex, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.xmlGridView, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.50777F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.49223F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(527, 193);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // txtFile
            // 
            this.txtFile.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel7.SetColumnSpan(this.txtFile, 2);
            this.txtFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFile.ForeColor = System.Drawing.Color.White;
            this.txtFile.Location = new System.Drawing.Point(3, 3);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(366, 20);
            this.txtFile.TabIndex = 63;
            // 
            // chkTableView
            // 
            this.chkTableView.AutoSize = true;
            this.chkTableView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkTableView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkTableView.Location = new System.Drawing.Point(375, 3);
            this.chkTableView.Name = "chkTableView";
            this.chkTableView.Size = new System.Drawing.Size(77, 21);
            this.chkTableView.TabIndex = 61;
            this.chkTableView.Text = "Table View";
            this.chkTableView.UseVisualStyleBackColor = true;
            this.chkTableView.CheckedChanged += new System.EventHandler(this.XmlSetView);
            // 
            // cmbTableIndex
            // 
            this.cmbTableIndex.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cmbTableIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTableIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTableIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTableIndex.ForeColor = System.Drawing.Color.White;
            this.cmbTableIndex.Location = new System.Drawing.Point(458, 3);
            this.cmbTableIndex.Name = "cmbTableIndex";
            this.cmbTableIndex.Size = new System.Drawing.Size(66, 21);
            this.cmbTableIndex.TabIndex = 62;
            this.cmbTableIndex.SelectedIndexChanged += new System.EventHandler(this.SelectXmlTableIndex);
            // 
            // xmlGridView
            // 
            this.xmlGridView.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.tableLayoutPanel7.SetColumnSpan(this.xmlGridView, 4);
            this.xmlGridView.DataSetTableIndex = 0;
            this.xmlGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xmlGridView.ForeColor = System.Drawing.Color.White;
            this.xmlGridView.Location = new System.Drawing.Point(3, 30);
            this.xmlGridView.Name = "xmlGridView";
            this.xmlGridView.Size = new System.Drawing.Size(521, 160);
            this.xmlGridView.TabIndex = 65;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(553, 366);
            this.tabControl1.TabIndex = 6;
            // 
            // btn_Revert
            // 
            this.btn_Revert.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.tableLayoutPanel1.SetColumnSpan(this.btn_Revert, 2);
            this.btn_Revert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Revert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Revert.Location = new System.Drawing.Point(271, 90);
            this.btn_Revert.Name = "btn_Revert";
            this.btn_Revert.Size = new System.Drawing.Size(265, 23);
            this.btn_Revert.TabIndex = 11;
            this.btn_Revert.Text = "Revert XML File";
            this.btn_Revert.UseVisualStyleBackColor = false;
            this.btn_Revert.Click += new System.EventHandler(this.RevertRefactor);
            // 
            // MainUı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(553, 389);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.progressBar1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainUı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "X4 Foundations: XMLRefactor & Translator by HeX";
            this.Load += new System.EventHandler(this.FormFirstStart);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ErrorProvider errorProvider1;
        private ProgressBar progressBar1;
        private SaveFileDialog _sDialog;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_file;
        private Label label2;
        private Button btn_start;
        private ComboBox cmb_langnum;
        private Label label1;
        private TextBox txt_foldpath;
        private Button btn_fold;
        private TextBox txt_filename;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel7;
        private TabPage tabPage3;
        private TableLayoutPanel tableLayoutPanel5;
        private Button btn_file2;
        private Label label3;
        private Button btn_start2;
        private ComboBox comboBox1;
        private Label label6;
        private TextBox txt_foldpath2;
        private Button btn_fold2;
        private TextBox txt_filename2;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label5;
        private Button btn_TR;
        private Button btn_EN;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox pictureBox1;
        private Label label4;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private TableLayoutPanel tableLayoutPanel6;
        private WebControl webControl1;
        private TextBox txt_link;
        private Button btn_wbhome;
        private XmlGridView xmlGridView;
        private WebView webView1;
        private GroupBox groupBox4;
        private TableLayoutPanel tableLayoutPanel8;
        private TextBox txtFile2;
        private CheckBox chkTableView2;
        private ComboBox cmbTableIndex2;
        private XmlGridView xmlGridView2;
        private TextBox txtFile;
        private CheckBox chkTableView;
        private ComboBox cmbTableIndex;
        private Button btn_Revert;
    }
}

