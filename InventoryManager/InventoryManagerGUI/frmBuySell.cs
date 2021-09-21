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
    /// Title: frmBuySell
    /// Date: Sep 20, 2021
    /// Author: Jeanne Payoyo
    /// Description: Allows user to buy or sell items
    /// </summary>
    public partial class frmBuySell : Form
    {
        public frmBuySell()
        {
            InitializeComponent();
        }

        // Initialize properties
        public bool isBuy;          // Checks if form is for Buy or Sell operation
        public int itemId;          // Selected itemId
        private Item myItem;        // Item from itemId
        private decimal myTotal;    // Total cost/price
        
        // Completes on form load
        private void frmBuySell_Load(object sender, EventArgs e)
        {
            myItem = ItemManager.GetItemById(itemId);

            // Buy operation
            if (this.isBuy)
            {
                this.Text = "Buy Items";
                gbBuySell.Text = "Buy Items";
                lblTotalCostSale.Text = "Total Cost";
                btnBuySell.Text = "&Buy";
            }
            // Sell operation
            else
            {
                this.Text = "Sell Items";
                gbBuySell.Text = "Sell Items";
                lblTotalCostSale.Text = "Total Sale";
                btnBuySell.Text = "&Sell";
            }

            displayData();
            nupQuantity.Value = 1;
            nupQuantity.Minimum = 1;
            nupQuantity.Maximum = myItem.ItemQuantity;
            nupQuantity.Focus();

        } // End of Load

        // Display item data
        private void displayData()
        {
            txtItemId.Text = myItem.ItemId.ToString();
            txtItemName.Text = myItem.ItemName;

            if (isBuy)
            {
                txtPrice.Text = myItem.FactoryPrice.ToString("c");
                txtDiscount.Text = myItem.FactoryDiscount.ToString("c");
            }
            else
            {
                txtPrice.Text = myItem.ItemPrice.ToString("c");
                txtDiscount.Text = myItem.ItemDiscount.ToString("c");
            }
            
            calculateTotal();
        }

        // Updates txtTotal
        private void calculateTotal()
        {
            if (isBuy)
            {
                myTotal = myItem.FactoryPrice * (1 - myItem.FactoryDiscount) * nupQuantity.Value;
            }
            else
            {
                myTotal = myItem.ItemPrice * (1 - myItem.ItemDiscount) * nupQuantity.Value;
            }
            txtTotal.Text = myTotal.ToString("c");
        }

        // Close the page without saving changes
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Validates data and saves changes to the database
        private void btnBuySell_Click(object sender, EventArgs e)
        {

        }

        // Updates txtTotal when Quantity is changed
        private void nupQuantity_ValueChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

    } // End of class
} // End of namespace
