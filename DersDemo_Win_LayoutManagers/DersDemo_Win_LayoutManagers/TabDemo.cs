using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DersDemo_Win_LayoutManagers
{
    public partial class TabDemo : Form
    {
        public TabDemo()
        {
            InitializeComponent();

        }

        private void TabDemo_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[2];
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, 0, 0, tabControl1.Width, tabControl1.Height);

            e.DrawBackground();
            e.Graphics.FillRectangle(Brushes.Blue, e.Bounds);
            e.Graphics.DrawString("A", new Font("Arial", 12f), Brushes.White, e.Bounds);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            tabControl1.SelectedIndex =
                int.Parse(b.Tag.ToString());
        }
    }
}
