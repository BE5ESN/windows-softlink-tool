using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SoftLinkTool
{
    public partial class softLink : Form
    {
        public softLink()
        {
            InitializeComponent();
        }

        private void button_target_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            var ret = fb.ShowDialog();
            if(ret == DialogResult.OK)
            {
                textBox_target.Text = fb.SelectedPath;
            }
        }

        private void button_dest_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            var ret = fb.ShowDialog();
            if (ret == DialogResult.OK)
            {
                textBox_dest.Text = fb.SelectedPath;
            }
        }
        public static string ExecuteInCmd(string cmdline)
        {
            using (var process = new Process())
            {
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;
                process.Start();
                process.StandardInput.AutoFlush = true;
                process.StandardInput.WriteLine(cmdline + "&exit");

                //获取cmd窗口的输出信息  
                string output = process.StandardOutput.ReadToEnd();

                process.WaitForExit();
                process.Close();
                return output;
            }
        }
        private void button_create_Click(object sender, EventArgs e)
        {
            ExecuteInCmd("mklink /j \"" + textBox_dest.Text+"\\"+textBox_linkName.Text + "\" \"" + textBox_target.Text + "\"");
        }
    }
}
