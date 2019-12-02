﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalManagementApp.BLL;

namespace MedicalManagementApp.Common
{
    public partial class PurchaseReportForm : Form
    {
        PurchaseReportManager purchaseReportManager= new PurchaseReportManager();
        public PurchaseReportForm()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = purchaseReportManager.AllData();
        }
    }
}
