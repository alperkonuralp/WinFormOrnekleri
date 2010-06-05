using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace DersDemo_Win_CopyFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = textBox1.Text;
            var dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = textBox2.Text;
            var dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                textBox2.Text = saveFileDialog1.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show(
                    "Lütfen kaynak dosyayı seçiniz.",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textBox1.Focus();
            }
            if (textBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show(
                    "Lütfen hedef dosyayı seçiniz.",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textBox2.Focus();
            }

            if (!File.Exists(textBox1.Text))
            {
                MessageBox.Show(
                    "Kaynak dosya bulunamadı.",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textBox1.Focus();
            }

            if (!Directory.Exists(Path.GetDirectoryName(textBox1.Text)))
            {
                MessageBox.Show(
                    "Hedef dizin bulunamadı.",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textBox2.Focus();
            }

            button3.Text = "İptal";
            dl.Visible =
                dp.Visible =
                dl2.Visible = true;
            backgroundWorker1.RunWorkerAsync(
                new[] { textBox1.Text, textBox2.Text }
                );
        }

        private void backgroundWorker1_DoWork(
            object sender, DoWorkEventArgs e)
        {
            var arg = e.Argument as string[];
            if (arg == null)
            {
                e.Cancel = true;
                e.Result = "Argüman yok.";
                return;
            }


            using (var fsSource = new FileStream(
                arg[0], FileMode.Open,
                FileAccess.Read, FileShare.None))
            using (var fsDestination = new FileStream(
                arg[1], FileMode.Create,
                FileAccess.Write, FileShare.None))
            {
                byte[] tampon = new byte[1 * 1024];
                int elsay;

                while ((elsay = fsSource.Read(tampon, 0, tampon.Length)) > 0)
                {
                    fsDestination.Write(tampon, 0, elsay);

                    backgroundWorker1.ReportProgress(
                        (int)(fsSource.Position * 100 / fsSource.Length),
                        new[] { fsSource.Position, fsSource.Length });

                    Thread.Sleep(50);

                    if (fsSource.Position >= fsSource.Length)
                        break;
                }
            }
            e.Result = "Ok";
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            dp.Value = e.ProgressPercentage;
            long[] ld = e.UserState as long[];
            dl2.Text = string.Format("{0} / {1} ({2:P})",
                CO.GetSizeString(ld[0]),
                CO.GetSizeString(ld[1]),
                e.ProgressPercentage / 100.0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            button3.Text = "Kopyala";
            dl.Visible =
                dp.Visible =
                dl2.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = textBox4.Text;
            var dr = folderBrowserDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                textBox4.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = textBox3.Text;
            var dr = folderBrowserDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                textBox3.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            backgroundWorker2.RunWorkerAsync(
                new[] { textBox4.Text, textBox3.Text });

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            var arg = e.Argument as string[];
            if (arg == null)
            {
                e.Cancel = true;
                e.Result = "Argüman yok.";
                return;
            }

            List<string> dizinler; //= new List<string>();
            List<string> dosyalar = new List<string>();
            long toplamBoyut = 0L;
            long durum = 0L;
            int no = 0;
            int toplamIs = 2;

            DirectoryInfo di =
                new DirectoryInfo(arg[0]);

            dizinler = di
                .GetDirectories("*.*", SearchOption.AllDirectories)
                .Select(x => x.FullName.Replace(arg[0] + "\\", ""))
                .ToList();

            backgroundWorker2.ReportProgress(++no, new object[] { "Dizinler Alnıyor", toplamIs += dizinler.Count });

            dosyalar = di
                .GetFiles("*.*", SearchOption.AllDirectories)
                .Select(x => { toplamBoyut += x.Length; return x.FullName.Replace(arg[0] + "\\", ""); })
                .ToList();

            backgroundWorker2.ReportProgress(++no, new object[] { "Dosyalar Alnıyor", toplamIs += dosyalar.Count });

            // dizinlerin oluşturulması
            string fn;
            foreach (var item in dizinler)
            {
                no++;
                fn = Path.Combine(arg[1], item);
                if (!Directory.Exists(fn))
                {
                    Directory.CreateDirectory(fn);
                    backgroundWorker2.ReportProgress(
                        no,
                        new object[] { 
                            string.Format("'{0}' dizini oluşturuldu.", item), toplamIs });
                }
            }

            // dosyaların kopyalanması
            byte[] tampon = new byte[2 * 1024];
            int elsay;
            foreach (var item in dosyalar)
            {
                using (FileStream fsSource =
                    new FileStream(
                        Path.Combine(arg[0], item),
                        FileMode.Open,
                        FileAccess.Read,
                        FileShare.None))
                using (FileStream fsDestination =
                    new FileStream(
                        Path.Combine(arg[1], item),
                        FileMode.Create,
                        FileAccess.Write,
                        FileShare.None))
                {
                    ++no;
                    while (fsSource.Position < fsSource.Length)
                    {
                        elsay = fsSource.Read(tampon, 0, tampon.Length);
                        fsDestination.Write(tampon, 0, elsay);
                        durum += elsay;
                        backgroundWorker2.ReportProgress(
                           no,
                           new object[] { 
                               string.Format("'{0}' dosyası kopyalanıyor.", item), 
                               toplamIs, 
                               durum,
                               toplamBoyut,
                               (int)fsSource.Position,
                               (int)fsSource.Length
                           });


                    }
                }
            }
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            object[] arg = e.UserState as object[];
            toolStripStatusLabel5.Text =
                string.Format("{0} ({1} / {2})",
                arg[0], e.ProgressPercentage, arg[1]
                );
            toolStripStatusLabel5.Visible = true;

            if (arg.Length > 2)
            {
                int yuzde =
                    (int)((long)arg[2] * 100 / (long)arg[3]);
                tip.Value = yuzde;
                til2.Text = string.Format("{0} / {1} (%{2})",
                    CO.GetSizeString((long)arg[2]),
                    CO.GetSizeString((long)arg[3]),
                    yuzde);

                til.Visible =
                    tip.Visible =
                    til2.Visible = true;

                yuzde =
                    ((int)arg[4] * 100 / (int)arg[5]);
                dp.Value = yuzde;
                dl2.Text = string.Format("{0} / {1} (%{2})",
                    CO.GetSizeString((int)arg[4]),
                    CO.GetSizeString((int)arg[5]),
                    yuzde);

                dl.Visible =
                    dp.Visible =
                    dl2.Visible = true;
            }
            Application.DoEvents();
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            til.Visible =
                tip.Visible =
                til2.Visible =
                dl.Visible =
                dl2.Visible =
                dp.Visible =
                toolStripStatusLabel5.Visible = false;
        }
    }
}
