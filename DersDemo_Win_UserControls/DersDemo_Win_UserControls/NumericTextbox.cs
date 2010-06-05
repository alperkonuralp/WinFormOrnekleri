using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DersDemo_Win_UserControls
{
    public class NumericTextbox : TextBox
    {
        public NumericTextbox()
            : base()
        {

        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
        }

        protected override void OnKeyPress(
            KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') ||
                e.KeyChar == '\b' || e.KeyChar == '.' ||
                e.KeyChar == ',')
            {
                base.OnKeyPress(e);
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
