using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DersDemo_Win_UserControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labeledTextbox1.TextChanged += new EventHandler(labeledTextbox1_TextChanged2);
            textBox1.Text = DateTime.Now.ToString("dd MM yyyy");
        }

        private void labeledTextbox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = labeledTextbox1.TextBoxText;
        }

        private void labeledTextbox1_TextChanged2(object sender, EventArgs e)
        {
            textBox1.Text = labeledTextbox1.TextBoxText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayac1.Start();
        }

        private void directoryTreeView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var sec =
                    directoryTreeView1.GetNodeAt(e.Location);


                directoryTreeView1.SelectedNode = sec;
            }
        }
    }
}
