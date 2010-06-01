using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using FileNameRenamer.Properties;

namespace FileNameRenamer
{
    public partial class RenamerForm : Form
    {
        public RenamerForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                MessageBox.Show(Resources.textbox1_Validation);
                textBox1.Focus();
            }
            if (string.IsNullOrEmpty(textBox2.Text.Trim()))
            {
                MessageBox.Show(Resources.textbox2_Validation);
                textBox2.Focus();
            }

            tsl.Visible = true;
            tsl.Text = string.Empty;
            button2.Enabled = false;
            treeView1.Nodes.Clear();

            var di = new DirectoryInfo(textBox1.Text);

            FindFiles(di, null);


            button2.Enabled = true;
            tsl.Visible = false;
            treeView1.ExpandAll();
        }

        private void FindFiles(DirectoryInfo di, TreeNode rootNode)
        {
            Application.DoEvents();

            var treeNode = new TreeNode(di.Name);

            tsl.Text = string.Format(Resources.FindFile_Text1, di.Name);
            Application.DoEvents();

            if (rootNode == null)
            {
                treeView1.Nodes.Add(treeNode);
            }
            else
            {
                rootNode.Nodes.Add(treeNode);
            }

            foreach (var directoryInfo in di.GetDirectories())
            {
                FindFiles(directoryInfo, treeNode);
            }

            foreach (var fileInfo in di.GetFiles())
            {
                tsl.Text = string.Format(Resources.FindFile_Text2, fileInfo.Name);
                Application.DoEvents();

                var nn =
                    Path.Combine(
                        fileInfo.DirectoryName,
                        fileInfo.Name.Replace(textBox2.Text, textBox3.Text));

                if (nn != fileInfo.FullName)
                {
                    treeNode.Nodes.Add(string.Format("{0,20} => {1}", fileInfo.Name, Path.GetFileName(nn)));
                    fileInfo.MoveTo(nn);

                    Application.DoEvents();
                }
            }
            treeNode.ExpandAll();
        }

    }
}
