using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DersDemo_Mobile_Sql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (AdresDefteriDataSetUtil.DesignerUtil.IsRunTime())
            {
                // TODO: Delete this line of code to remove the default AutoFill for 'adresDefteriDataSet.AdresDefteri'.
                this.adresDefteriTableAdapter.Fill(this.adresDefteriDataSet.AdresDefteri);
            }

        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adresDefteriBindingSource.EndEdit();
            adresDefteriTableAdapter.Update(
                adresDefteriDataSet);
        }
    }
}