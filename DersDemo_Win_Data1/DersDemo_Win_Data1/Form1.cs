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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dataSet1.Products);

        }

        private void productsDataGridView_CellMouseEnter(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            this.SuspendLayout();
            productsDataGridView.Rows[e.RowIndex]
                .DefaultCellStyle.BackColor =
            productsDataGridView.Columns[e.ColumnIndex]
                .DefaultCellStyle.BackColor = Color.Blue;
            productsDataGridView.Rows[e.RowIndex]
                .DefaultCellStyle.ForeColor =
            productsDataGridView.Columns[e.ColumnIndex]
                .DefaultCellStyle.ForeColor = Color.White;

            toolStripStatusLabel1.Text =
                string.Format(
                "Row: {0}, Column: {1}, Value: {2}",
                e.RowIndex + 1,
                e.ColumnIndex + 1,
                productsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

            this.ResumeLayout();
        }

        private void productsDataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            productsDataGridView.SuspendLayout();
            productsDataGridView.Rows[e.RowIndex]
                .DefaultCellStyle.BackColor = Color.Empty;

            productsDataGridView.Columns[e.ColumnIndex]
                .DefaultCellStyle.BackColor = Color.Empty;

            productsDataGridView.Rows[e.RowIndex]
                .DefaultCellStyle.ForeColor =
            productsDataGridView.Columns[e.ColumnIndex]
                .DefaultCellStyle.ForeColor = Color.Empty;
            productsDataGridView.ResumeLayout();
        }
    }
}
