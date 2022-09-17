using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Email_Assist_Tool
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            string user = Environment.UserName;
            tbxUsername.Text = "Welcome " + user + "!";

            string initialPath = Environment.CurrentDirectory;

            DirectoryInfo di = new DirectoryInfo(initialPath + @"\config\Templates");
            string dirTemplates = initialPath + @"\config\Templates";

            if (!Directory.Exists(dirTemplates))
            {
                MessageBox.Show("Templates folder does not exist.");
                return;
            }

            FileInfo[] files = di.GetFiles("*.msg");

            List<string> list = new List<string>();
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
            string initialPath = Environment.CurrentDirectory;
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
    }
}
