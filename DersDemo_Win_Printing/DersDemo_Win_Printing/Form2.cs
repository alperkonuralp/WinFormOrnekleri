﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DersDemo_Win_Printing
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nWDataSet.EmployeeOrderReport' table. You can move, or remove it, as needed.
            this.employeeOrderReportTableAdapter.Fill(this.nWDataSet.EmployeeOrderReport);

            this.reportViewer1.RefreshReport();
        }
    }
}
