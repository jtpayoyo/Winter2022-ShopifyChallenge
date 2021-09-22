using InventoryManagerData;
using Microsoft.EntityFrameworkCore;
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
            // Validate text fields
            if(Validator.IsPresent(txtItemName) &&
               Validator.IsPresent(txtItemDescription) &&
               Validator.IsPresent(txtItemQuantity) &&
               Validator.IsNonNegativeInt(txtItemQuantity) &&
               Validator.IsPresent(txtFactoryPrice) &&
               Validator.IsNonNegativeDecimal(txtFactoryPrice) &&
               Validator.IsPresent(txtFactoryDiscount) &&
               Validator.IsNonNegativeDecimal(txtFactoryDiscount) &&
               Validator.IsPresent(txtItemPrice) &&
               Validator.IsNonNegativeDecimal(txtItemPrice) &&
               Validator.IsPresent(txtItemDiscount) &&
               Validator.IsNonNegativeDecimal(txtItemDiscount))
            {
                // Try updating data
                try
                {
                    ItemManager.UpdateItem(itemId, txtItemName.Text, txtItemDescription.Text, Convert.ToInt32(txtItemQuantity.Text),
                        Convert.ToDecimal(txtFactoryPrice.Text), Convert.ToDecimal(txtFactoryDiscount.Text),
                        Convert.ToDecimal(txtItemPrice.Text), Convert.ToDecimal(txtItemDiscount.Text), myItem.ImageId);
                }
                // Catches errors and displays them
                catch (DbUpdateException ex)
                {
                    HandleException.DisplayDbError(ex);
                }
                catch (Exception ex)
                {
                    HandleException.DisplayGeneralError(ex);
                }

                // Send user back to frmMain
                this.DialogResult = DialogResult.OK;
            }
        } // End of btnSave_Click

    } // End of class
} // End of namespace
