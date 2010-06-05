using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using DersDemo_Win_Controls.Properties;

namespace DersDemo_Win_Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private Thread th;
        private bool b;

        private void Form1_Load(object sender, EventArgs e)
        {
            th = new Thread(delegate()
            {
                while (true)
                {
                    notifyIcon1.Icon = b ? Resources.Image : Resources.espn;

                    b = !b;
                    Thread.Sleep(1000);
                }
            });

            th.IsBackground = true;
            th.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }


    }
}
