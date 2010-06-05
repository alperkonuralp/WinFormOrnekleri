using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace DersDemo_Mobile_First
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;

            for (int i = 0; i < 101; i++)
            {
                progressBar1.Value = i;
                Application.DoEvents();
                Thread.Sleep(300);
            }

            progressBar1.Visible = false;
        }
    }
}