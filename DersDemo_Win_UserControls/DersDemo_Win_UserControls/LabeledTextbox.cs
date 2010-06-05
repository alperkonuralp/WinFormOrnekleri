using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DersDemo_Win_UserControls
{
    public partial class LabeledTextbox : UserControl
    {

        public LabeledTextbox()
        {
            InitializeComponent();
        }

        [Category("Label Properties")]
        [Description("Label'ın içeriğini verir.")]
        public string LabelText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        [Category("Textbox Properties")]
        public int TextBoxLeft
        {
            get { return textBox1.Left; }
            set
            {
                SuspendLayout();
                textBox1.Left = value;
                textBox1.Width = this.Width - value - 3;
                ResumeLayout();
            }
        }

        [Category("Textbox Properties")]
        public string TextBoxText
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        [Browsable(false)]
        [Category("Textbox Properties")]
        public Color TextboxBackColor
        {
            get { return textBox1.BackColor; }
            set { textBox1.BackColor = value; }
        }

        [Browsable(true)]
        new public event EventHandler TextChanged;

        private void textBox1_TextChanged(
            object sender, EventArgs e)
        {
            if (TextChanged != null)
            {
                TextChanged(this, e);
            }
        }
    }
}
