using InventoryManagerData;
using System;
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

        // Initialize properties
        public int itemId;          // Selected itemId
        private Item myItem;        // Item from itemId

        // Completes on form load
        private void frmDetail_Load(object sender, EventArgs e)
        {
            myItem = ItemManager.GetItemById(itemId);
            txtItemId.Text = myItem.ItemId.ToString();
            txtItemName.Text = myItem.ItemName;
            txtItemDescription.Text = myItem.ItemDescription;
            txtItemQuantity.Text = myItem.ItemQuantity.ToString();
            txtFactoryPrice.Text = myItem.FactoryPrice.ToString("f2");
            txtFactoryDiscount.Text = myItem.FactoryDiscount.ToString("f2");
            txtItemPrice.Text = myItem.ItemPrice.ToString("f2");
            txtItemDiscount.Text = myItem.ItemDiscount.ToString("f2");
            txtItemName.Focus();
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
