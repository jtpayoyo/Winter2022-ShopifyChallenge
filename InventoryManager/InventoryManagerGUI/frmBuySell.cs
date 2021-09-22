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
        const int minBuy = 1;       // Minimum items to buy
        const int maxBuy = 500;     // Maximum items to buy
        const int minSell = 1;      // Minimum items to sell
        int maxSell;                // Maximum items to sell
        
        // Completes on form load
        private void frmBuySell_Load(object sender, EventArgs e)
        {
            myItem = ItemManager.GetItemById(itemId);
            maxSell = myItem.ItemQuantity;

            // Buy operation
            if (this.isBuy)
            {
                this.Text = "Buy Items";
                gbBuySell.Text = "Buy Items";
                lblTotalCostSale.Text = "Total Cost";
                btnBuySell.Text = "&Buy";
                nupQuantity.Maximum = maxBuy;
            }
            // Sell operation
            else
            {
                this.Text = "Sell Items";
                gbBuySell.Text = "Sell Items";
                lblTotalCostSale.Text = "Total Sale";
                btnBuySell.Text = "&Sell";
                nupQuantity.Maximum = maxSell;
            }

            displayData();
            nupQuantity.Value = 1;
            nupQuantity.Minimum = 1;
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
            if (isBuy)
            {
                BuyItems();
            }
            else
            {
                SellItems();
            }
        } // End of btnBuySell_Click

        private void BuyItems()
        {
            // Validate quantity
            if (Validator.IsPresentNUP(nupQuantity) &&
                Validator.IsIntWithinRangeInclusiveNUP(nupQuantity, minBuy, maxBuy))
            {
                // Update total and confirm sale with user
                calculateTotal();
                DialogResult result = MessageBox.Show($"Do you want to buy {nupQuantity.Value} item(s) for {myTotal.ToString("c")}?",
                    "Buy Items", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Sell item
                if (result == DialogResult.Yes)
                {
                    // try updating
                    try
                    {
                        int newQuantity = myItem.ItemQuantity + (int)nupQuantity.Value;
                        ItemManager.BuySellItem(itemId, newQuantity);
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
            }
        } // End of BuyItems

        // Validate quantity and sell items
        private void SellItems()
        {
            // Validate quantity
            if (Validator.IsPresentNUP(nupQuantity) &&
                Validator.IsIntWithinRangeInclusiveNUP(nupQuantity, minSell, maxSell))
            {
                // Update total and confirm sale with user
                calculateTotal();
                DialogResult result = MessageBox.Show($"Do you want to sell {nupQuantity.Value} item(s) for {myTotal.ToString("c")}?",
                    "Sell Items", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Sell item
                if (result == DialogResult.Yes)
                {
                    // try updating
                    try
                    {
                        int newQuantity = myItem.ItemQuantity - (int) nupQuantity.Value;
                        ItemManager.BuySellItem(itemId, newQuantity);
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
            }
        } // End of SellItems

        // Updates txtTotal when Quantity is changed
        private void nupQuantity_ValueChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

    } // End of class
} // End of namespace
