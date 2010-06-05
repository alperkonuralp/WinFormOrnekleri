using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web.Security;

namespace DersDemo_Win_Dialogs
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void tbUserName_Validating(
            object sender, CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null)
            {
                if (string.IsNullOrEmpty(tb.Text.Trim()))
                {
                    errorProvider1.SetError(
                        tb, "Lütfen veri giriniz.");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider1.SetError(
                        tb, string.Empty);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MembershipCreateStatus mcs;
            //Membership.CreateUser(
            //    "deneme",
            //    "deneme",
            //    "asd@asd.com",
            //    "merhaba",
            //    "naber",
            //    true,
            //    out mcs);

            if (Membership.ValidateUser(
                tbUserName.Text, tbPassword.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Üye adınız ve/veya şifreniz hatalı",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
