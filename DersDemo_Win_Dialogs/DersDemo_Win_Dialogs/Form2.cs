using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace DersDemo_Win_Dialogs
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown)
            {
                return;
            }

            e.Cancel = true;
            
            notifyIcon1.Visible = true;
            this.ShowInTaskbar = false;
            this.Visible = false;
            notifyIcon1.BalloonTipText = "Bu Bir Denemedir";
            notifyIcon1.BalloonTipTitle = "Form2";
            notifyIcon1.ShowBalloonTip(1000);
            Thread.Sleep(1000);
            notifyIcon1.Visible = false;
            notifyIcon1.Visible = true;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.Visible = true;
            notifyIcon1.Visible = false;
        }
    }
}
