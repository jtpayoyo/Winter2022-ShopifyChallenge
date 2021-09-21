﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagerGUI
{
    /// <summary>
    /// Title: frmDetail
    /// Date: Sep 20, 2021
    /// Author: Jeanne Payoyo
    /// Description: Contains details for the selected item
    ///              Allows user to edit the data
    /// </summary>
    public partial class frmDetail : Form
    {
        public frmDetail()
        {
            InitializeComponent();
        }
        
        // Close the page without saving changes
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Validates data and saves changes to the database
        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    } // End of class
} // End of namespace
