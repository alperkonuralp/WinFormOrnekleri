using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace DersDemo_Win_First
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Tag = "deneme";
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            for (double i = 0.01; i <= 1.00; i += 0.01)
            {
                Opacity = i;
                Application.DoEvents();
                Thread.Sleep(10);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (double i = 0.99; i >= 0.00; i -= 0.01)
            {
                Opacity = i;
                Application.DoEvents();
                Thread.Sleep(10);
            }
        }
    }
}
