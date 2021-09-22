using InventoryManagerData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagerGUI
{
    /// <summary>
    /// Title: frmMain
    /// Date: Sep 20, 2021
    /// Author: Jeanne Payoyo
    /// Description: Main page for InventoryManager App
    /// </summary>
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // Displays current data on form load
        private void frmMain_Load(object sender, EventArgs e)
        {
            DisplayItems();
        } // End of form load

        // Displays item data to grid view
        private void DisplayItems()
        {
            dgvItems.Columns.Clear();
            List<Item> items = ItemManager.GetItems();
            dgvItems.DataSource = items;

            // Add Edit, Buy and Sell button columns
            var editColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Edit"
            };
            var buyColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Buy"
            };
            var sellColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Sell"
            };
            dgvItems.Columns.Add(editColumn);
            dgvItems.Columns.Add(buyColumn);
            dgvItems.Columns.Add(sellColumn);

            // Format the header
            dgvItems.EnableHeadersVisualStyles = false;
            dgvItems.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvItems.ColumnHeadersDefaultCellStyle.BackColor = Color.SkyBlue;
            dgvItems.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            
            // Format odd rows
            dgvItems.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;

            // Format columns                     
            dgvItems.Columns[0].HeaderText = "Item ID";
            dgvItems.Columns[0].Width = 100;
            dgvItems.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvItems.Columns[1].HeaderText = "Name";
            dgvItems.Columns[1].Width = 300;
            dgvItems.Columns[3].HeaderText = "Quantity";
            dgvItems.Columns[3].Width = 100;
            dgvItems.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Hide detailed columns
            dgvItems.Columns[2].Visible = false;
            dgvItems.Columns[4].Visible = false;
            dgvItems.Columns[5].Visible = false;
            dgvItems.Columns[6].Visible = false;
            dgvItems.Columns[7].Visible = false;
            dgvItems.Columns[8].Visible = false;
            dgvItems.Columns[9].Visible = false;

        } // End of DisplayItems

        // Exit application by clicking button, ESC, or Alt + E
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Checks if the user has clicked a button
        // Handles Edit, Buy or Sell option
        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            const int EDIT_INDEX = 10;
            const int BUY_INDEX = 11;
            const int SELL_INDEX = 12;

            // Gets itemId if button is clicked
            if ((e.ColumnIndex == EDIT_INDEX || e.ColumnIndex == BUY_INDEX || e.ColumnIndex == SELL_INDEX ) 
                && e.RowIndex != -1)
            {
                int itemId = (int)dgvItems.Rows[e.RowIndex].Cells[0].Value;
                Item myItem = ItemManager.GetItemById(itemId);

                // Calls edit operation
                if (e.ColumnIndex == EDIT_INDEX)
                {
                    EditItem(itemId);
                }
                // Calls buy operation
                else if (e.ColumnIndex == BUY_INDEX)
                {
                    BuyItem(itemId);
                }
                // Calls sell operation
                else if (e.ColumnIndex == SELL_INDEX)
                {
                    // Checks if there is stock
                    if (myItem.ItemQuantity != 0)
                        SellItem(itemId);
                    else
                    {
                        string message = $"{myItem.ItemName} is out of stock! You must buy more items first.";
                        MessageBox.Show(message, "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                        
                }
            }
        } // End of CellClick

        // Opens frmDetail
        private void EditItem(int myId)
        {
            frmDetail editItem = new frmDetail()
            {
                itemId = myId       // Pass the selected itemId
            };
            DialogResult result = editItem.ShowDialog();

            // Checks if edit succeeded
            if (result == DialogResult.OK)
            {
                DisplayItems();
            }

        } // End of EditItem

        // Opens frmBuySell for Buy operation
        private void BuyItem(int myId)
        {
            frmBuySell buyItem = new frmBuySell()
            {
                isBuy = true,       // Buy operation
                itemId = myId       // Pass the selected itemId
            };
            DialogResult result = buyItem.ShowDialog();

            // Checks if buy succeeded
            if (result == DialogResult.OK)
            {
                DisplayItems();
            }
        }

        // Opens frmBuySell for Sell operation
        private void SellItem(int myId)
        {
            frmBuySell sellItem = new frmBuySell()
            {
                isBuy = false,      // Sell operation
                itemId = myId       // Pass the selected itemId
            };
            DialogResult result = sellItem.ShowDialog();

            // Checks if buy succeeded
            if (result == DialogResult.OK)
            {
                DisplayItems();
            }
        }    

        
    } // End of class 
} // End of namespace
