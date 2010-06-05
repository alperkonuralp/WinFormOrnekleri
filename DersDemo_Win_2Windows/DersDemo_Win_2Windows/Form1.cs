using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DersDemo_Win_2Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CommonDatas.Datas.Add("Cihan", "Denemedir");
            CommonDatas.Datas["Cihan"] = "Denemedir";
        }
        protected Form f2;
        private void Form1_Shown(object sender, EventArgs e)
        {
            f2 = new Form();
            f2.StartPosition = FormStartPosition.Manual;
            f2.Text = "Form 2";
            f2.Location =
                new Point(this.Location.X + this.Size.Width, this.Location.Y);

            Label l = new Label();
            l.Name = "l";
            l.Text = CommonDatas.Datas["Cihan"].ToString();
            l.Location = new Point(0, 0);
            f2.Controls.Add(l);
            f2.Show();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            if (f2 == null) return;
            f2.Location =
                            new Point(this.Location.X + this.Size.Width, this.Location.Y);
        }
    }
}
