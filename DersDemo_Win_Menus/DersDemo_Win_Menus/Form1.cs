using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DersDemo_Win_Menus.Properties;
using System.Threading;

namespace DersDemo_Win_Menus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStrip1ToolStripMenuItem.Tag =
                toolStrip1;
            toolStrip2ToolStripMenuItem.Tag =
                toolStrip2;
            toolStrip3ToolStripMenuItem.Tag =
                toolStrip3;
            toolStrip4ToolStripMenuItem.Tag =
                toolStrip4;
        }

        private void toolStrip1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible =
            toolStrip1ToolStripMenuItem.Checked =
                !toolStrip1ToolStripMenuItem.Checked;
        }

        private void toolStrip2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip2.Visible =
            toolStrip2ToolStripMenuItem.Checked =
                !toolStrip2ToolStripMenuItem.Checked;
        }

        private void toolStripsToolStripMenuItem_Click(
            object sender, EventArgs e)
        {
            ToolStripMenuItem t = sender as ToolStripMenuItem;
            t.Checked = !t.Checked;
            ToolStrip ts = t.Tag as ToolStrip;
            if (ts != null)
            {
                ts.Visible = t.Checked;
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.Text = "Options";
            f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < r.Next(1, 5); i++)
            {
                ToolStripMenuItem mi = new ToolStripMenuItem("Dosya " + (i + 1));
                recientToolStripMenuItem.DropDownItems.Add(mi);
            }

            comboBox1.Items.Add(string.Empty);
            comboBox1.Items.AddRange(
                panel1.Controls.OfType<TextBox>().Select(x => x.Name).OrderBy(x => x).ToArray());

            pictureBox1.Width = pictureBox1.Image.Width;
            pictureBox1.Height = pictureBox1.Image.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //foreach (object item in panel1.Controls)
            //{
            //    if (item is TextBox)
            //    {
            //        ((TextBox)item).Text = DateTime.Now.ToString();
            //    }
            //}
            panel1.Controls.OfType<TextBox>().OrderBy(x => x.Name).Take(1).Select(x => x.Text = DateTime.Now.ToString()).FirstOrDefault();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            TextBox[] dizi =
                panel1.Controls
                .OfType<TextBox>()
                .OrderBy(x => x.Name)
                .ToArray();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i].Visible = (i == (comboBox1.SelectedIndex - 1));
            }


        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.Font =
                new Font(label1.Font, FontStyle.Underline);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Font =
                new Font(label1.Font,
                    label1.Font.Style & (~FontStyle.Underline));
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Visible = true;

            for (int i = toolStripProgressBar1.Minimum;
                i < toolStripProgressBar1.Maximum; i++)
            {
                toolStripProgressBar1.Value = i;
                Thread.Sleep(100);
                Application.DoEvents();
            }
            toolStripProgressBar1.Visible = false;
        }
    }
}
