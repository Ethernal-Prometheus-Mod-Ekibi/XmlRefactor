using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace XmlRefactor.UI
{
    public partial class MainUı : Form
    {
        //File language set variable
        private int _langNum;

        //Dialog variables
        private CommonOpenFileDialog _dialog;
        private OpenFileDialog _dialog2;

        //Language variables
        private int _lngchck;
        private string _compmsg = ""; //Process completed message
        private string _errormsg = ""; //Error message


        public MainUı()
        {
            InitializeComponent();
            LangCheck(); //Language check
            LoadReleases(); //Load Github Releases Page
            cmb_langnum.SelectedIndex = 4; //Default language set
            comboBox1.SelectedIndex = 4; //Default language set
        }

        private void FormFirstStart(object sender, EventArgs e)
        {
            SetBehavior();
            SetBehavior2();
        }

        private void SetBehavior()
        {
            _ = (txt_filename.Text.Trim() != string.Empty) && File.Exists(txt_filename.Text);

            if (chkTableView.Checked)
            {
                xmlGridView.ViewMode = XmlGridView.VıewMode.Table;
                cmbTableIndex.Enabled = true;
            }
            else
            {
                xmlGridView.ViewMode = XmlGridView.VıewMode.Xml;
                cmbTableIndex.Enabled = false;
            }
        }

        private void SetBehavior2()
        {
            _ = (txt_filename2.Text.Trim() != string.Empty) && File.Exists(txt_filename2.Text);

            if (chkTableView2.Checked)
            {
                xmlGridView2.ViewMode = XmlGridView.VıewMode.Table;
                cmbTableIndex2.Enabled = true;
            }
            else
            {
                xmlGridView2.ViewMode = XmlGridView.VıewMode.Xml;
                cmbTableIndex2.Enabled = false;
            }
        }

        private void LoadReleases()
        {
            const string mainlink = @"https://github.com/Ethernal-Prometheus-Mod-Ekibi/XmlRefactor/releases";
            txt_link.Text = mainlink;
            webControl1.WebView.Url = txt_link.Text;
            webControl1.WebView.Engine.Options.DisableGPU = true;
            webControl1.WebView.AllowDropLoad = false;
        }

        private void ShowNowPage(object sender, EventArgs e)
        {
            txt_link.Text = webControl1.WebView.Url;
        }

        private void GoMainPage(object sender, EventArgs e)
        {
            const string mainlink = @"https://github.com/Ethernal-Prometheus-Mod-Ekibi/XmlRefactor/releases";
            txt_link.Text = mainlink;
            webControl1.WebView.Url = mainlink;
        }

        private void LangCheck()
        {
            switch (_lngchck) //Language check
            {
                case 1: //English
                    _compmsg = "Process completed!";
                    _errormsg = "Error:";
                    break;
                case 0: //Turkish
                    _compmsg = "İşlem tamamlandı!";
                    _errormsg = "Hata:";
                    break;
            }
        }

        private void Select_Folder(object sender, EventArgs e)
        {
            _dialog = new CommonOpenFileDialog //Folder select dialog
            {
                RestoreDirectory = true, //Restore last selected directory
                IsFolderPicker = true //Select folder
            };
            if (_dialog.ShowDialog() == CommonFileDialogResult.Ok) //If selected folder is OK
            {
                txt_foldpath.Text = _dialog.FileName; //Set folder path to textbox
                txt_foldpath2.Text = _dialog.FileName; //Set folder path to textbox
            }
        }

        private void Select_File(object sender, EventArgs e)
        {
            _dialog2 = new OpenFileDialog //File select dialog
            {
                InitialDirectory = txt_foldpath.Text, //Set initial directory
                Filter = @"XML Files (*.xml)|*.xml" //Set filter
            };
            if (_dialog2.ShowDialog() == DialogResult.OK) //If selected file is OK
            {
                txt_filename.Text = Path.GetFileName(_dialog2.FileName); //Set file name to textbox
                ViewXml();
            }
        }

        private void Select_File2(object sender, EventArgs e)
        {
            _dialog2 = new OpenFileDialog //File select dialog
            {
                InitialDirectory = txt_foldpath.Text, //Set initial directory
                Filter = @"XML Files (*.xml)|*.xml" //Set filter
            };
            if (_dialog2.ShowDialog() == DialogResult.OK) //If selected file is OK
            {
                txt_filename2.Text = Path.GetFileName(_dialog2.FileName); //Set file name to textbox
                ViewXml2();
            }
        }

        private void StartRefactor(object sender, EventArgs e)
        {
            _langNum = Convert.ToInt32(cmb_langnum.Text); //Set language number

            if (_dialog?.FileName != null && _dialog2?.FileName != null)
            {
                var opfile = _dialog2.FileName; //Set file path
                try //Try to refactor XML file
                {
                    // Load XML file
                    var doc = XDocument.Load(opfile);

                    foreach (var languageElement in
                             doc.Descendants("language")) //Replace 'language' elements with 'diff' elements
                    {
                        languageElement.Name = "diff"; //Change element name
                    }

                    foreach (var pageElement in
                             doc.Descendants("page")) //Replace 'page' elements with 'replace' elements
                    {
                        var pageId = pageElement.Attribute("id")?.Value; //Get 'id' attribute value
                        var replaceElements = new List<XElement>(); //Create new list for 'replace' elements
                        var comments = new List<XNode>(); //Create new list for comments

                        foreach (var node in pageElement.Nodes()) //Get all child nodes of the 'page' element
                        {
                            if (node is XComment comment) //If node is comment
                            {
                                comments.Add(comment); //Add comment to the list
                            }
                            else if (node is XElement tElement && tElement.Name == "t") //If node is 't' element
                            {
                                var tId = tElement.Attribute("id")?.Value; //Get 'id' attribute value
                                var tContent = tElement.Value; //Get 't' element value

                                if (tId != null) //If 'id' attribute value is not null
                                {
                                    var replaceElement = new XElement("replace", //Create new 'replace' element
                                        new XAttribute("sel",
                                            $"//language[@id='{_langNum}']/page[@id='{pageId}']/t[@id='{tId}']"), //Set 'sel' attribute
                                        new XElement("t", new XAttribute("id", tId), tContent)); //Set 't' element

                                    replaceElements.Add(replaceElement); //Add 'replace' element to the list
                                }
                            }
                        }

                        foreach (var replaceElement in replaceElements) //For each 'replace' element in the list
                        {
                            doc.Descendants("diff").First().Add(replaceElement); // Add to the diff element
                        }

                        foreach (var commentNode in comments) //For each comment in the list
                        {
                            pageElement.AddFirst(commentNode); //Add comment to the 'page' element
                        }

                        pageElement.RemoveNodes(); // Remove all child nodes of the 'page' element
                    }

                    // Remove empty 'page' elements
                    doc.Descendants("page") //Get all 'page' elements
                        .Where(pageElement => !pageElement.HasElements) //If 'page' element has no child elements
                        .Remove(); //Remove 'page' element

                    var sDialog = new SaveFileDialog //Save file dialog
                    {
                        InitialDirectory = txt_foldpath.Text, //Set initial directory
                        RestoreDirectory = true, //Restore last selected directory
                        DefaultExt = "xml", //Set default extension
                        FileName = Path.GetFileNameWithoutExtension(_dialog2.FileName) +
                                   "_Refactored", //Set default file name
                        Filter = @"XML Files (*.xml)|*.xml" //Set filter
                    };

                    if (sDialog.ShowDialog() == DialogResult.OK) //If selected file is OK
                    {
                        doc.Save(sDialog.FileName); //Save XML file
                        MessageBox.Show(_compmsg); //Show completed message
                    }
                }
                catch (Exception ex) //If an error occurs
                {
                    MessageBox.Show(_errormsg + $@" {ex.Message}"); //Show error message
                }
            }
            else
            {
                // Kullanıcı bir veya her iki dosya seçimi yapmadı veya seçim işlemi iptal edildi
                MessageBox.Show(@"Lütfen dosya seçimlerini tamamlayınız.", @"Uyarı", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        private void RevertRefactor(object sender, EventArgs e)
        {
            if (_dialog?.FileName != null && _dialog2?.FileName != null)
            {
                var opfile = _dialog2.FileName; // Set file path
                try // Try to revert XML file
                {
                    // Load XML file
                    var doc = XDocument.Load(opfile);

                    // Find all "replace" elements within "diff" and group them by their "sel" attribute
                    var groupedReplaces = doc.Descendants("diff")
                        .Elements("replace")
                        .Where(replace => replace.Attribute("sel") != null)
                        .GroupBy(replace => replace.Attribute("sel")?.Value)
                        .ToList(); // Convert to list to avoid enumeration issues

                    foreach (var groupedReplace in groupedReplaces)
                    {
                        var selValue = groupedReplace.Key;

                        if (!string.IsNullOrEmpty(selValue))
                        {
                            var pageId = GetAttributeValue(selValue, "page", "id");
                            var languageId = GetAttributeValue(selValue, "language", "id");

                            XElement languageElement = null;
                            foreach (var e1 in doc.Descendants("language"))
                            {
                                if (e1.Attribute("id")?.Value == languageId)
                                {
                                    languageElement = e1;
                                    break;
                                }
                            }

                            if (languageElement == null)
                            {
                                languageElement = new XElement("language", new XAttribute("id", languageId));
                                doc.Root?.Add(languageElement);
                            }

                            XElement pageElement = null;
                            foreach (var e1 in languageElement.Descendants("page"))
                            {
                                if (e1.Attribute("id")?.Value == pageId)
                                {
                                    pageElement = e1;
                                    break;
                                }
                            }

                            if (pageElement == null)
                            {
                                if (_lngchck == 0)
                                {
                                    pageElement = new XElement("page",
                                        new XAttribute("id", pageId),
                                        new XAttribute("title", "BLANK"),
                                        new XAttribute("descr", "BLANK2"),
                                        new XAttribute("voice", "YES/NO PLEASE CORRECT FILLING")
                                    );
                                    languageElement.Add(pageElement);
                                }
                                else if (_lngchck == 1)
                                {
                                    pageElement = new XElement("page",
                                        new XAttribute("id", pageId),
                                        new XAttribute("title", "İSTEĞE BAĞLI"),
                                        new XAttribute("descr", "İSTEĞE BAĞLI"),
                                        new XAttribute("voice", "YES/NO DOĞRU DOLDURUN")
                                    );
                                    languageElement.Add(pageElement);
                                }
                            }

                            foreach (var replaceElement in groupedReplace.ToList())
                            {
                                var tId = GetAttributeValue(replaceElement.Attribute("sel")?.Value, "t", "id");
                                var tContent = replaceElement.Element("t")?.Value;
                                var tElement = new XElement("t", new XAttribute("id", tId), tContent);
                                pageElement?.Add(tElement);
                                replaceElement.Remove();
                            }
                        }
                    }

                    var sDialog = new SaveFileDialog
                    {
                        InitialDirectory = txt_foldpath.Text,
                        RestoreDirectory = true,
                        DefaultExt = "xml",
                        FileName = Path.GetFileNameWithoutExtension(_dialog2.FileName) + "_Reverted",
                        Filter = @"XML Files (*.xml)|*.xml"
                    };

                    if (sDialog.ShowDialog() == DialogResult.OK)
                    {
                        doc.Save(sDialog.FileName);
                        MessageBox.Show(@"Reverted successfully! - Please open file and delete diff block!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show(@"Lütfen dosya seçimlerini tamamlayınız.", @"Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private static string GetAttributeValue(string sel, string element, string attribute)
        {
            var pattern = $@"{element}\[@{attribute}='([^']+)'\]";
            var matches = Regex.Matches(sel, pattern);
            var attributeValues = new List<string>();

            foreach (Match match in matches)
            {
                string attributeValue = match.Groups[1].Value;
                attributeValues.Add(string.IsNullOrEmpty(attributeValue) ? "" : attributeValue);
            }

            return string.Join(" ", attributeValues);
        }

        private void StartTranslate(object sender, EventArgs e)
        {
            if (_dialog?.FileName != null && _dialog2?.FileName != null)
            {
                var translateForm = new TranslateUı(this);
                translateForm.Show();
            }
            else
            {
                // Kullanıcı bir veya her iki dosya seçimi yapmadı veya seçim işlemi iptal edildi
                MessageBox.Show(@"Lütfen dosya seçimlerini tamamlayınız.", @"Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public string GetFilenameValue()
        {
            var file = _dialog2.FileName;
            return file;
        }

        private void GoGithubPage(object sender, LinkLabelLinkClickedEventArgs e)
        {
            const string url = "https://github.com/Ethernal-Prometheus-Mod-Ekibi"; //Github page url
            try
            {
                Process.Start(url); //Open github page
            }
            catch (Exception ex) //If an error occurs
            {
                MessageBox.Show(_errormsg + $@" {ex.Message}"); //Show error message
            }
        }

        private void GoDiscordChannel(object sender, LinkLabelLinkClickedEventArgs e)
        {
            const string url = "https://discord.gg/zSJMF774ex"; //Discord channel url
            try
            {
                Process.Start(url); //Open discord channel
            }
            catch (Exception ex) //If an error occurs
            {
                MessageBox.Show(_errormsg + $@" {ex.Message}"); //Show error message
            }
        }

        private void SetLangTr(object sender, EventArgs e) //Set language to Turkish
        {
            _lngchck = 1; //Set language check to 1
            LangCheck(); //Check language

            // Ana Sekme
            tabPage1.Text = @"Yeniden Düzenleme";
            tabPage2.Text = @"Bilgi & Ayarlar";
            tabPage3.Text = @"Çevirici";

            // Hakkında Sekmesi
            groupBox1.Text = @"Hakkımızda";
            label4.Text = @"Ethernal Prometheus Mod Ekibi";
            linkLabel1.Text = @"GitHub'ı Ziyaret Edin";
            linkLabel2.Text = @"Discord Kanalımıza Katılın";

            // Ayarlar Sekmesi
            btn_wbhome.Text = @"Son Sürümleri Kontrol Edin";
            label5.Text = @"Görüntüleme Dilini Ayarla";
            groupBox2.Text = @"Ayarlar";

            // Çevirici Sekmesi
            label3.Text = @"BU ARACI KULLANDIĞINIZ İÇİN TEŞEKKÜRLER <3 - Lütfen GITHUB üzerinden geri bildirimde bulunun";
            label6.Text = @"Dili Seçiniz :";
            btn_fold2.Text = @"Klasör Seçiniz";
            btn_file2.Text = @"Hedef Dosyayı Seçiniz";
            btn_start2.Text = @"XML Dosyasını Çevir";

            // Yeniden Düzenleme Sekmesi
            label2.Text = @"BU ARACI KULLANDIĞINIZ İÇİN TEŞEKKÜRLER <3 - Lütfen GITHUB üzerinden geri bildirimde bulunun";
            label1.Text = @"Dili Seçiniz :";
            btn_fold.Text = @"Klasör Seçiniz";
            btn_start.Text = @"XML Dosyasını Yeniden Düzenle";
            btn_file.Text = @"Hedef Dosyayı Seçiniz";
            chkTableView.Text = @"Tablo Görünümü";
            chkTableView2.Text = @"Tablo Görünümü";
        }

        private void SetLangEn(object sender, EventArgs e) //Set language to English
        {
            _lngchck = 0; //Set language check to 0
            LangCheck(); //Check language

            // Main Tab
            tabPage1.Text = @"Refactor";
            tabPage2.Text = @"Info & Settings";
            tabPage3.Text = @"Translater";

            // Info Tab
            groupBox1.Text = @"About Us";
            label4.Text = @"Ethernal Prometheus Mod Team";
            linkLabel1.Text = @"Visit to GitHub";
            linkLabel2.Text = @"Join Discord Channel";

            // Settings Tab
            btn_wbhome.Text = @"Check Latest Releases";
            label5.Text = @"Set Tool Display Language";
            groupBox2.Text = @"Settings";

            // Translater Tab
            label3.Text = @"THANKS FOR USING THIS TOOL <3 - Please give feedback on GITHUB";
            label6.Text = @"Select Language :";
            btn_fold2.Text = @"Select Folder";
            btn_file2.Text = @"Select Target File";
            btn_start2.Text = @"Translate XML File";

            // Refactor Tab
            label2.Text = @"THANKS FOR USING THIS TOOL <3 - Please give feedback on GITHUB";
            label1.Text = @"Select Language :";
            btn_fold.Text = @"Select Folder";
            btn_start.Text = @"Refactor XML File";
            btn_file.Text = @"Select Target File";
            chkTableView.Text = @"Table View";
            chkTableView2.Text = @"Table View";
        }

        /*
         * XML View
         */

        private void ViewXml()
        {
            if (_dialog2 == null) return;
            var sOpenPath = _dialog2.FileName;
            if (sOpenPath != string.Empty)
            {
                txtFile.Text = sOpenPath;
                xmlGridView.DataFilePath = txtFile.Text;

                cmbTableIndex.Items.Clear();
                for (var i = 0; i < xmlGridView.DataTableCount; i++)
                {
                    cmbTableIndex.Items.Add(i.ToString());
                }

                if (cmbTableIndex != null)
                {
                    cmbTableIndex.SelectedIndex = 0;
                    xmlGridView.DataSetTableIndex = Convert.ToInt32(cmbTableIndex.Text.Trim());
                }

                SetBehavior();
            }
        }

        private void ViewXml2()
        {
            if (_dialog2 == null) return;
            var sOpenPath = _dialog2.FileName;
            if (sOpenPath != string.Empty)
            {
                txtFile2.Text = sOpenPath;
                xmlGridView2.DataFilePath = txtFile2.Text;

                cmbTableIndex2.Items.Clear();
                for(var i=0; i<xmlGridView2.DataTableCount; i++)
                {
                    cmbTableIndex2.Items.Add(i.ToString());
                }

                if (cmbTableIndex2 != null)
                {
                    cmbTableIndex2.SelectedIndex = 0;
                    xmlGridView2.DataSetTableIndex = Convert.ToInt32(cmbTableIndex2.Text.Trim());
                }

                SetBehavior2();
            }
        }

        private void SelectXmlTableIndex(object sender, EventArgs e)
        {
            xmlGridView.DataSetTableIndex = Convert.ToInt32(cmbTableIndex.Text.Trim());
        }

        private void SelectXmlTableIndex2(object sender, EventArgs e)
        {
            xmlGridView2.DataSetTableIndex = Convert.ToInt32(cmbTableIndex2.Text.Trim());
        }

        private void XmlSetView(object sender, EventArgs e)
        {
            SetBehavior();
        }

        private void XmlSetView2(object sender, EventArgs e)
        {
            SetBehavior2();
        }
    }
}
