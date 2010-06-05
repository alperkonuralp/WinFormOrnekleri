using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DersDemo_Win_Data1.DataLayer;
using System.Data.SqlClient;
using DersDemo_Win_Data1.Properties;

namespace DersDemo_Win_Data1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        protected DataSet ds;

        private void Form3_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            using (SqlConnection scon =
                new SqlConnection(Settings.Default.NorthwindConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM Products", scon);

                da.Fill(ds, "Products");

                dataGridView1.DataSource = ds.Tables["Products"];
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow a in dataGridView1.SelectedRows)
            {
                ((DataRowView)a.DataBoundItem).Delete();
            }
        }
    }
}
