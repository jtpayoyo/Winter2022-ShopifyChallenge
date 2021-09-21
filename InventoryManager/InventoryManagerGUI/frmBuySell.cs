using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagerGUI
{
    public partial class frmBuySell : Form
    {
        public frmBuySell()
        {
            InitializeComponent();
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
    }
}
