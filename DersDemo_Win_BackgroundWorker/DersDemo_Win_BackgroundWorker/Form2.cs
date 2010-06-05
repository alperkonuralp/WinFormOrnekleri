using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace DersDemo_Win_BackgroundWorker
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(
            object sender, DoWorkEventArgs e)
        {
            int[] veri = e.Argument as int[];
            if (veri == null)
            {
                veri = new[] { 0, 100 };
            }
            for (int i = veri[0]; i <= veri[1]; i++)
            {
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                backgroundWorker1.ReportProgress(i);
                Thread.Sleep(1000);
            }
            e.Result = "OK";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync(new[] { 
                progressBar1.Minimum, progressBar1.Maximum
            });
        }

        private void backgroundWorker1_ProgressChanged(
            object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(
            object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
                backgroundWorker1.CancelAsync();
        }
    }
}
