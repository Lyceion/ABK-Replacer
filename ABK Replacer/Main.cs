using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABK_Replacer
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        string AbkName;
        string aud1Name;
        string aud2Name;
        string aud3Name;
        string aud4Name;
        string aud5Name;
        string aud6Name;
        string aud7Name;
        string aud8Name;
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            this.Height = 180;
        }

        private void abkOpen_Click(object sender, EventArgs e)
        {
            getFile(abkLocTXT, audioPanel,"abk");
            
        }
        void getFile(MetroFramework.Controls.MetroTextBox textBox,Panel panel ,string fileType)
        {
            OpenFileDialog openABK = new OpenFileDialog();
            openABK.Filter = fileType.ToUpper() + " Files | *." + fileType;
            openABK.FilterIndex = 1;
            openABK.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openABK.Title = "Cylops' ABK Replacer -|- Select " + fileType.ToUpper() + " File";
            openABK.Multiselect = false;
            if (openABK.ShowDialog() == DialogResult.OK)
            {
                textBox.Text = openABK.FileName;
                panel.Enabled = true;
                abkSelected.Start();
                if (fileType == "abk")
                    AbkName = openABK.SafeFileName;
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Please Insert a Valid " + fileType.ToUpper() + " File.", "ABK Replacer by Cylops", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
            //if(openABK.DialogResult)
        }

        private void abkSelected_Tick(object sender, EventArgs e)
        {
            if (this.Height < 680)
                this.Height = this.Height + 20;
            else
                abkSelected.Stop();
        }

        private void aud1Check_CheckedChanged(object sender, EventArgs e)
        {
            if (aud1Check.Checked == true)
                aud1Panel.Enabled = true;
            else
                aud1Panel.Enabled = false;
        }

        private void aud2Check_CheckedChanged(object sender, EventArgs e)
        {
            if (aud2Check.Checked == true)
                aud2Panel.Enabled = true;
            else
                aud2Panel.Enabled = false;
        }

        private void aud3Check_CheckedChanged(object sender, EventArgs e)
        {
            if (aud3Check.Checked == true)
                aud3Panel.Enabled = true;
            else
                aud3Panel.Enabled = false;
        }

        private void aud4Check_CheckedChanged(object sender, EventArgs e)
        {
            if (aud4Check.Checked == true)
                aud4Panel.Enabled = true;
            else
                aud4Panel.Enabled = false;
        }

        private void aud5Check_CheckedChanged(object sender, EventArgs e)
        {
            if (aud5Check.Checked == true)
                aud5Panel.Enabled = true;
            else
                aud5Panel.Enabled = false;
        }

        private void aud6Check_CheckedChanged(object sender, EventArgs e)
        {
            if (aud6Check.Checked == true)
                aud6Panel.Enabled = true;
            else
                aud6Panel.Enabled = false;
        }

        private void aud7Check_CheckedChanged(object sender, EventArgs e)
        {
            if (aud7Check.Checked == true)
                aud7Panel.Enabled = true;
            else
                aud7Panel.Enabled = false;
        }

        private void aud8Check_CheckedChanged(object sender, EventArgs e)
        {
            if (aud8Check.Checked == true)
                aud8Panel.Enabled = true;
            else
                aud8Panel.Enabled = false;
        }

        private void buttonTimer_Tick(object sender, EventArgs e)
        {
            if (aud1Check.Checked == true || aud2Check.Checked == true || aud3Check.Checked == true || aud4Check.Checked == true || aud5Check.Checked == true || aud6Check.Checked == true || aud7Check.Checked == true || aud8Check.Checked == true)
                startButton.Enabled = true;
            else
                startButton.Enabled = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (aud1Check.Checked == true || aud2Check.Checked == true || aud3Check.Checked == true || aud4Check.Checked == true || aud5Check.Checked == true || aud6Check.Checked == true || aud7Check.Checked == true || aud8Check.Checked == true)
            {
                //Base ---> ABK_insert abkfile soundfile number
                string deps_loc = (Application.StartupPath) + @"\debs";
                string commandTxt = @"@echo off";
                if (aud1Check.Checked == true)
                {
                    commandTxt = commandTxt + Environment.NewLine + deps_loc + '"' + @"\ABK_insert.exe" + '"' + " " + '"' + abkLocTXT.Text + '"' + " " + '"' + aud1TXT.Text + '"' + " " + 1.ToString();
                }
                if (aud2Check.Checked)
                {
                    commandTxt = commandTxt + Environment.NewLine + deps_loc +'"' + @"\ABK_insert.exe" + '"' + " "+ '"' + abkLocTXT.Text + '"' + " " + '"' + aud2TXT.Text + '"' + " " + 2.ToString();
                }
                if (aud3Check.Checked)
                {
                    commandTxt = commandTxt + Environment.NewLine + deps_loc +'"' + @"\ABK_insert.exe" + '"' + " "+ '"' + abkLocTXT.Text + '"' + " " + '"' + aud3TXT.Text + '"' + " " + 3.ToString();
                }
                if (aud4Check.Checked)
                {
                    commandTxt = commandTxt + Environment.NewLine + deps_loc +'"' + @"\ABK_insert.exe" + '"' + " "+ '"' + abkLocTXT.Text + '"' + " " + '"' + aud4TXT.Text + '"' + " " + 4.ToString();
                }
                if (aud5Check.Checked)
                {
                    commandTxt = commandTxt + Environment.NewLine + deps_loc +'"' + @"\ABK_insert.exe" + '"' + " "+ '"' + abkLocTXT.Text + '"' + " " + '"' + aud5TXT.Text + '"' + " " + 5.ToString();
                }
                if (aud6Check.Checked)
                {
                    commandTxt = commandTxt + Environment.NewLine + deps_loc +'"' + @"\ABK_insert.exe" + '"' + " "+ '"' + abkLocTXT.Text + '"' + " " + '"' + aud6TXT.Text + '"' + " " + 6.ToString();
                }
                if (aud7Check.Checked)
                {
                    commandTxt = commandTxt + Environment.NewLine + deps_loc +'"' + @"\ABK_insert.exe" + '"' + " "+ '"' + abkLocTXT.Text + '"' + " " + '"' + aud7TXT.Text + '"' + " " + 7.ToString();
                }
                if (aud8Check.Checked)
                {
                    commandTxt = commandTxt + Environment.NewLine + deps_loc +'"' + @"\ABK_insert.exe" + '"' + " "+ '"' + abkLocTXT.Text + '"' + " " + '"' + aud8TXT.Text + '"' + " " + 8.ToString();
                }
                commandTxt = commandTxt + Environment.NewLine + "pause";
                MessageBox.Show(commandTxt);
                TextWriter bat = new StreamWriter(deps_loc + @"\start.bat");
                bat.Write(commandTxt);
                bat.Close();
                Process abk_init = Process.Start(deps_loc + @"\start.bat");
                abk_init.WaitForExit();
                Thread.Sleep(5000);
                //File.Delete(deps_loc + @"\start.bat");
                if (!File.Exists((Application.StartupPath) + @"\output"))
                    Directory.CreateDirectory((Application.StartupPath) + @"\output");
                Directory.Move(deps_loc + @"\" + AbkName + "m", (Application.StartupPath) + @"\output");
                MetroFramework.MetroMessageBox.Show(this, "ABK File is Replaced. Replaced One is On->\n" + (Application.StartupPath) + @"\output", "Cylops", MessageBoxButtons.OK, MessageBoxIcon.Information, 300);

            }
        }
        void commandAdder(string baseboi, string audio, int number)
        {
            
        }

        private void aud1Open_Click(object sender, EventArgs e)
        {
            getFile(aud1TXT, aud1Panel, "wav");
        }

        private void aud2Open_Click(object sender, EventArgs e)
        {
            getFile(aud2TXT, aud2Panel, "wav");
        }

        private void aud3Open_Click(object sender, EventArgs e)
        {
            getFile(aud3TXT, aud3Panel, "wav");
        }

        private void aud4Open_Click(object sender, EventArgs e)
        {
            getFile(aud4TXT, aud4Panel, "wav");
        }

        private void aud5Open_Click(object sender, EventArgs e)
        {
            getFile(aud5TXT, aud5Panel, "wav");
        }

        private void aud6Open_Click(object sender, EventArgs e)
        {
            getFile(aud6TXT, aud6Panel, "wav");
        }

        private void aud7Open_Click(object sender, EventArgs e)
        {
            getFile(aud7TXT, aud7Panel, "wav");
        }

        private void aud8Open_Click(object sender, EventArgs e)
        {
            getFile(aud8TXT, aud8Panel, "wav");
        }
    }
}
