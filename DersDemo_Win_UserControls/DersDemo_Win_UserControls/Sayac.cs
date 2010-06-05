using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace DersDemo_Win_UserControls
{
    public partial class Sayac : UserControl
    {
        public Sayac()
        {
            InitializeComponent();
            WaitTime = 1000;
        }

        public int WaitTime { get; set; }

        private void backgroundWorker1_DoWork(
            object sender, DoWorkEventArgs e)
        {

            for (int i = 0; i < 101; i++)
            {
                backgroundWorker1.ReportProgress(i);
                Thread.Sleep((int)e.Argument);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label1.Text = e.ProgressPercentage.ToString();
            Application.DoEvents();
        }

        public void Start()
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync(WaitTime);
            }
        }
    }
}
