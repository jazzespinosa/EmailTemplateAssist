using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Configuration;
using System.Windows.Forms;

namespace Email_Assist_Tool
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private const string folderIdentifier = "(var.)";
        string initialPath = Environment.CurrentDirectory;
        private string selectedFolder = "";

        private void mainForm_Load(object sender, EventArgs e)
        {
            cbxTemplate.SelectedItem = "";
            this.MinimumSize = new System.Drawing.Size(340, 175);

            string user = Environment.UserName;
            tbxUsername.Text = "Welcome " + user + "!";

            DirectoryInfo di = new DirectoryInfo(initialPath + @"\config\Templates");
            string dirTemplates = initialPath + @"\config\Templates";

            if (!Directory.Exists(dirTemplates))
            {
                MessageBox.Show("Templates folder does not exist.");
                return;
            }

            string[] directories = Directory.GetDirectories(dirTemplates);
            FileInfo[] files = di.GetFiles("*.msg");

            List<string> list = new List<string>();

            foreach (string directory in  directories)
            {
                string folderName = $"{Path.GetFileName(directory)} {folderIdentifier}";
                list.Add(folderName);
            }

            foreach (FileInfo file in files)
            {
                string fileString = file.Name;
                string newstring = fileString.Substring(0, fileString.Length - 4);
                list.Add(newstring);

            }
            String[] str = list.ToArray();

            cbxTemplate.DataSource = str;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (cboxSubTemplate.Visible == false)
            {
                string templateSelected = cbxTemplate.Text;
                string templatePath = initialPath + @"\config\Templates\" + templateSelected + ".msg";

                string templateDir = initialPath + @"\config\Templates";
                string trashDir = initialPath + @"\config\trash";

                if (!File.Exists(templatePath))
                {
                    MessageBox.Show("Email template does not exist.");
                    return;
                }
                else
                {
                    if (!Directory.Exists(trashDir))
                    {
                        Directory.CreateDirectory(trashDir);
                    }

                    string fName = templateSelected + ".msg";
                    string newName = templateSelected + "-Copy.msg";
                    string copyEmailPath = trashDir + "\\" + newName;
                    try
                    {
                        File.Copy(Path.Combine(templateDir, fName), Path.Combine(trashDir, newName), true);
                        new Process
                        {
                            StartInfo = new ProcessStartInfo(copyEmailPath)
                            {
                                UseShellExecute = true
                            }
                        }.Start();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                        throw;
                    }
                }
            }

            else
            {
                string templateSelectedSubTemplate = cboxSubTemplate.Text;
                string templatePathSubTemplate = initialPath + $@"\config\Templates\{selectedFolder}\" + templateSelectedSubTemplate + ".msg";

                string templateDirSubTemplate = initialPath + $@"\config\Templates\{selectedFolder}";
                string trashDir = initialPath + @"\config\trash";

                if (!File.Exists(templatePathSubTemplate))
                {
                    MessageBox.Show("Email template does not exist.");
                    return;
                }
                else
                {
                    if (!Directory.Exists(trashDir))
                    {
                        Directory.CreateDirectory(trashDir);
                    }

                    string fNameSubTemplate = templateSelectedSubTemplate + ".msg";
                    string newNameSubTemplate = templateSelectedSubTemplate + "-Copy.msg";
                    string copyEmailPathSubTemplate = trashDir + "\\" + newNameSubTemplate;
                    try
                    {
                        File.Copy(Path.Combine(templateDirSubTemplate, fNameSubTemplate), Path.Combine(trashDir, newNameSubTemplate), true);
                        new Process
                        {
                            StartInfo = new ProcessStartInfo(copyEmailPathSubTemplate)
                            {
                                UseShellExecute = true
                            }
                        }.Start();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                        throw;
                    }
                }
            }
            
        }

        private void cboxSubTemplate_VisibleChanged(object sender, EventArgs e)
        {
            if (cboxSubTemplate.Visible == true)
            {
                this.MinimumSize = new System.Drawing.Size(340, 215);
                this.Size = new System.Drawing.Size(this.Size.Width, 215);
            }
            else
            {
                this.MinimumSize = new System.Drawing.Size(340, 175);
                this.Size = new System.Drawing.Size(this.Size.Width, 175);
            } 
        }

        private void cbxTemplate_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedApp = cbxTemplate.Text;

            if (selectedApp.Substring(Math.Max(0, selectedApp.Length - 6)) == folderIdentifier)
            {
                cboxSubTemplate.Visible = true;
                labelSubTemplate.Visible = true;

                selectedFolder = selectedApp.Substring(0, selectedApp.Length - 7);

                cboxSubTemplate.DataSource = null;

                DirectoryInfo diSubTemplate = new DirectoryInfo(initialPath + $@"\config\Templates\{selectedFolder}");

                FileInfo[] filesSubTemplate = diSubTemplate.GetFiles("*.msg");

                List<string> listSubTemplate = new List<string>();

                foreach (FileInfo file in filesSubTemplate)
                {
                    string fileStringSubTemplate = file.Name;
                    string newstringSubTemplate = fileStringSubTemplate.Substring(0, fileStringSubTemplate.Length - 4);
                    listSubTemplate.Add(newstringSubTemplate);

                }
                String[] strSubTemplate = listSubTemplate.ToArray();

                cboxSubTemplate.DataSource = strSubTemplate;
            }
            else 
            {
                cboxSubTemplate.Visible = false;
                labelSubTemplate.Visible = false;
            }
            
        }
    }
}
