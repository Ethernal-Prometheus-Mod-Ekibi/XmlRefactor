using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
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
            cmb_langnum.SelectedIndex = 4; //Default language set
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
            }
        }

        private void StartRefactor(object sender, EventArgs e)
        {
            _langNum = Convert.ToInt32(cmb_langnum.Text); //Set language number
            var opfile = _dialog2.FileName; //Set file path

            try //Try to refactor XML file
            {
                // Load XML file
                var doc = XDocument.Load(opfile);

                foreach (var languageElement in doc.Descendants("language")) //Replace 'language' elements with 'diff' elements
                {
                    languageElement.Name = "diff"; //Change element name
                }

                foreach (var pageElement in doc.Descendants("page")) //Replace 'page' elements with 'replace' elements
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
                                    new XAttribute("sel", $"//language[@id='{_langNum}']/page[@id='{pageId}']/t[@id='{tId}']"), //Set 'sel' attribute
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
                    FileName = Path.GetFileNameWithoutExtension(_dialog2.FileName) + "_Refactored", //Set default file name
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

            // Hakkında Sekmesi
            groupBox1.Text = @"Hakkımızda";
            label4.Text = @"Ethernal Prometheus Mod Ekibi";
            linkLabel1.Text = @"GitHub'ı Ziyaret Edin";
            linkLabel2.Text = @"Discord Kanalımıza Katılın";

            // Ayarlar Sekmesi
            label5.Text = @"Görüntüleme Dilini Ayarla";
            groupBox2.Text = @"Ayarlar";

            // Yeniden Düzenleme Sekmesi
            label2.Text = @"BU ARACI KULLANDIĞINIZ İÇİN TEŞEKKÜRLER <3 - Lütfen GITHUB üzerinden geri bildirimde bulunun";
            label1.Text = @"Dili Seçiniz :";
            btn_fold.Text = @"Klasör Seçiniz";
            btn_start.Text = @"XML Dosyasını Yeniden Düzenle";
            btn_file.Text = @"Hedef Dosyayı Seçiniz";
        }

        private void SetLangEn(object sender, EventArgs e) //Set language to English
        {
            _lngchck = 0; //Set language check to 0
            LangCheck(); //Check language

            // Main Tab
            tabPage1.Text = @"Refactor";
            tabPage2.Text = @"Info & Settings";

            // Info Tab
            groupBox1.Text = @"About Us";
            label4.Text = @"Ethernal Prometheus Mod Team";
            linkLabel1.Text = @"Visit to GitHub";
            linkLabel2.Text = @"Join Discord Channel";

            // Settings Tab
            label5.Text = @"Set Tool Display Language";
            groupBox2.Text = @"Settings";

            // Refactor Tab
            label2.Text = @"THANKS FOR USING THIS TOOL <3 - Please give feedback on GITHUB";
            label1.Text = @"Select Language :";
            btn_fold.Text = @"Select Folder";
            btn_start.Text = @"Refactor XML File";
            btn_file.Text = @"Select Target File";
        }
    }
}
