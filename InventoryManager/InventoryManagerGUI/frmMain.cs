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

        // Exit application by clicking button, ESC, or Alt + E
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    } // End of class 
} // End of namespace
