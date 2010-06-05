using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DersDemo_Win_Data1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dataSet1.Products);
            // TODO: This line of code loads data into the 'dataSet1.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.dataSet1.Categories);

        }
    }
}
