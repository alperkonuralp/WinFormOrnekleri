using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

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
                MessageBox.Show("Lütfen dizini seçiniz.");
                textBox1.Focus();
            }
            if (string.IsNullOrEmpty(textBox2.Text.Trim()))
            {
                MessageBox.Show("Lütfen aranacak kelime/harf'i giriniz.");
                textBox2.Focus();
            }

            button2.Enabled = false;
            treeView1.Nodes.Clear();

            DirectoryInfo di = new DirectoryInfo(textBox1.Text);

            FindFiles(di, null);


            button2.Enabled = true;
            treeView1.ExpandAll();
        }

        private void FindFiles(DirectoryInfo di, TreeNode rootNode)
        {
            Application.DoEvents();

            var treeNode = new TreeNode(di.Name);

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
                string nn =
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
