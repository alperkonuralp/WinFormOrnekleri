using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DersDemo_Win_Dialogs.Properties;

namespace DersDemo_Win_Dialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Bütün Veriler Silindi.");

            //MessageBox.Show("Bütün Veriler Silindi.", "Uyarı");

            //DialogResult dr = MessageBox.Show("Bütün verileri silmek istedinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            //MessageBox.Show(dr.ToString());

            DialogResult dr = MessageBox.Show("Bütün verileri silmek istedinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            MessageBox.Show(dr.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
                Settings.Default.BackColor = colorDialog1.Color;
                Settings.Default.Save();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.Font = fontDialog1.Font;
                Settings.Default.Font = fontDialog1.Font;
                Settings.Default.Save();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.ForeColor = colorDialog1.Color;
                Settings.Default.ForeColor = colorDialog1.Color;
                Settings.Default.Save();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Settings.Default.BackColor;
            this.ForeColor = Settings.Default.ForeColor;
            this.Font = Settings.Default.Font;

            textBox1.Text = Application.ExecutablePath;
            //Resources.Culture = new System.Globalization.CultureInfo("tr-TR");
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Dosya Aç";
            openFileDialog1.Filter = "Image Files|*.jpg;*.bmp;*.gif;*.png|Exe Files|*.exe|All Files|*.*";
            DialogResult dr =
                openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Dosya Sakla";
            saveFileDialog1.Filter = "Image Files|*.jpg;*.bmp;*.gif;*.png|Exe Files|*.exe|All Files|*.*";
            DialogResult dr =
                saveFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                textBox1.Text = saveFileDialog1.FileName;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            DialogResult dr = MessageBox.Show(
                "Çıkmak istediğinize emin misiniz?",
                "Çıkış Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
