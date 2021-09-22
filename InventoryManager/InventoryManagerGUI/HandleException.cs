using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagerGUI
{
    /// <summary>
    /// Title: HandleException
    /// Date: July 19, 2021
    /// Author: Jeanne Payoyo
    /// Description: Class that handles database update and general exceptions
    ///              Created for course work at SAIT and modified for Shopify W2022 Challenge
    /// </summary>
    public static class HandleException
    {
        // Displays database update exception
        public static void DisplayDbError(DbUpdateException ex)
        {
            string message = "";
            var sqlException = (SqlException)ex.InnerException;
            foreach (SqlError error in sqlException.Errors)
            {
                message += "ERROR CODE: " + error.Number + " " +
                                error.Message + "\n";
            }
            MessageBox.Show(message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Displays general exceptions
        public static void DisplayGeneralError(Exception ex)
        {
            MessageBox.Show("ERROR: " + ex.Message, ex.GetType().ToString(),
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
