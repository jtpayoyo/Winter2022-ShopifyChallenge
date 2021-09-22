using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Text.RegularExpressions;
using InventoryManagerData;

namespace InventoryManagerGUI
{
    /// <summary>
    /// Title: Validator
    /// Date: July 19, 2021
    /// Name: Jeanne Payoyo
    /// Description: Used to validate user-input data
    ///              Created for course work at SAIT and modified for Shopify W2022 Challenge
    /// </summary>

    public static class Validator
    {
        /// <summary>
        /// checks if text box is not empty
        /// </summary>
        /// <param name="txtInput">text box to validate 
        /// (must have Tag set to meaningful name for error message)</param>
        /// <returns>true is present and false if not</returns>
        public static bool IsPresent(TextBox txtInput)
        {
            bool isValid = true; // "innocent until proven guilty"
            if(txtInput.Text == "")
            {
                MessageBox.Show(txtInput.Tag + " must be provided", "Input Error");
                txtInput.Focus(); // put focus on the text box to guide the user
                isValid = false;
            }
            return isValid;
        }

        /// <summary>
        /// checks if text box contains non-negative int number
        /// </summary>
        /// <param name="txtInput">text box to validate 
        /// (must have Tag set to meaningful name for error message)</param>
        /// <returns>true if valid, and false if not</returns>
        public static bool IsNonNegativeInt(TextBox txtInput)
        {
            bool isValid = true;
            int value;

            if(!Int32.TryParse(txtInput.Text, out value)) // if not an int
            {
                MessageBox.Show(txtInput.Tag + " should be a whole number", "Input Error");
                txtInput.SelectAll();
                txtInput.Focus();
                isValid = false;
            }
            else // it is an int, but could be negative
            {
                if(value < 0)
                {
                    MessageBox.Show(txtInput.Tag + " should be positive or zero", "Input Error");
                    txtInput.SelectAll();
                    txtInput.Focus();
                    isValid = false;
                }
            }

            return isValid;
        }

        /// <summary>
        /// checks if text box contains non-negative double number
        /// </summary>
        /// <param name="txtInput">text box to validate 
        /// (must have Tag set to meaningful name for error message)</param>
        /// <returns>true if valid, and false if not</returns>
        public static bool IsNonNegativeDouble(TextBox txtInput)
        {
            bool isValid = true;
            double value;

            if (!Double.TryParse(txtInput.Text, out value)) // if not a double
            {
                MessageBox.Show(txtInput.Tag + " should be a number", "Input Error");
                txtInput.SelectAll();
                txtInput.Focus();
                isValid = false;
            }
            else // it is a double, but could be negative
            {
                if (value < 0)
                {
                    MessageBox.Show(txtInput.Tag + " should be positive or zero", "Input Error");
                    txtInput.SelectAll();
                    txtInput.Focus();
                    isValid = false;
                }
            }

            return isValid;
        }

        /// <summary>
        /// checks if text box contains non-negative decimal number
        /// </summary>
        /// <param name="txtInput">text box to validate 
        /// (must have Tag set to meaningful name for error message)</param>
        /// <returns>true if valid, and false if not</returns>
        public static bool IsNonNegativeDecimal(TextBox txtInput)
        {
            bool isValid = true;
            decimal value;

            if (!Decimal.TryParse(txtInput.Text, out value)) // if not a decimal
            {
                MessageBox.Show(txtInput.Tag + " should be a number", "Input Error");
                txtInput.SelectAll();
                txtInput.Focus();
                isValid = false;
            }
            else // it is a decimal, but could be negative
            {
                if (value < 0)
                {
                    MessageBox.Show(txtInput.Tag + " should be positive or zero", "Input Error");
                    txtInput.SelectAll();
                    txtInput.Focus();
                    isValid = false;
                }
            }
            return isValid;
        }

        /// <summary>
        /// checks if text box contains positive int number
        /// </summary>
        /// <param name="txtInput">text box to validate 
        /// (must have Tag set to meaningful name for error message)</param>
        /// <returns>true if valid, and false if not</returns>
        public static bool IsPositiveInt(TextBox txtInput)
        {
            bool isValid = true;
            int value;

            if (!Int32.TryParse(txtInput.Text, out value)) // if not an int
            {
                MessageBox.Show(txtInput.Tag + " should be a whole number", "Input Error");
                txtInput.SelectAll();
                txtInput.Focus();
                isValid = false;
            }
            else // it is an int, but could be negative
            {
                if (value <= 0)
                {
                    MessageBox.Show(txtInput.Tag + " should be positive", "Input Error");
                    txtInput.SelectAll();
                    txtInput.Focus();
                    isValid = false;
                }
            }

            return isValid;
        }

    } // End of class
} // End of namespace
