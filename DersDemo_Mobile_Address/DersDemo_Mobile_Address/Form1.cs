using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsMobile.PocketOutlook;

namespace DersDemo_Mobile_Address
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OutlookSession sess = new OutlookSession();
            foreach (Contact item in sess.Contacts.Items)
            {
                var dr =
                    userDataSet.Contact.NewContactRow();

                dr.ID = item.ItemId.ToString();
                dr.FirstName = item.FirstName;
                dr.LastName = item.LastName;

                userDataSet.Contact.AddContactRow(dr);
            }
            userDataSet.Contact.AcceptChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OutlookSession sess = new OutlookSession();
            Contact c = new Contact();
            c.FirstName = textBox1.Text;
            c.LastName = textBox2.Text;

            sess.Contacts.Items.Add(c);
                       
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OutlookSession sess = new OutlookSession();

            sess.SmsAccount.Send(
                new SmsMessage(
                    textBox4.Text, textBox3.Text));
        }
    }
}