<<<<<<< HEAD
<<<<<<< HEAD
﻿using System.Windows;
=======
﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
//using System.Windows.Forms;
>>>>>>> d5f169f (added payment window UI start)
=======
﻿using System.Windows;
>>>>>>> 15a958a (updated cs files for functionality)

namespace LMS_WPFApp
{
    public partial class paymentGateway : Window
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
=======
        /*private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
>>>>>>> 70e15b7 (Part of PaymentGateway)
        {
         

        }*/

        private void payFeesButton_Click(object sender, RoutedEventArgs e)
        {
            string cardNumber = CardNumberText.Text;
            string expiryDate = ExpiryDateText.Text;
            string cvc = CvcText.Text;
            float paymentAmount = float.Parse(PaymentText.Text);

            if (IsValidCreditCard(cardNumber, expiryDate, cvc) && paymentAmount > 0)
            {
                // Check card type
                string cardType = GetCardType(CardNumberText.Text);
                MessageBox.Show("Payment successful! Card Type: " + cardType);
            }
            else
            {
                MessageBox.Show("Invalid credit card details. Please check and try again.");
            }
        }

        // Method to validate credit card details
        private bool IsValidCreditCard(string cardNumber, string expiryDate, string cvc)
        {
            // Simple validation for demonstration purposes
            if (cardNumber.Length == 16 && expiryDate.Length == 5 && cvc.Length == 3)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        // Method to determine the card type
        private string GetCardType(string cardNumber)
        {
            // Remove any non-numeric characters from the card number
            string cleanCardNumber = cardNumber.Replace(" ", "").Replace("-", "");

            // Check card prefix to determine card type
            if (cleanCardNumber.StartsWith("4"))
            {
                return "Visa";
            }
            else if (cleanCardNumber.StartsWith("5"))
            {
                return "Mastercard";
            }
            else if (cleanCardNumber.StartsWith("34") || cleanCardNumber.StartsWith("37"))
            {
                return "American Express";
            }
            else
            {
                return "Unknown";
            }
        }

        private void cancelPayFeesButton_Click(object sender, RoutedEventArgs e)
=======
        public paymentGateway()
=======
        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
>>>>>>> 15a958a (updated cs files for functionality)
        {

        }

<<<<<<< HEAD
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
>>>>>>> d5f169f (added payment window UI start)
=======
        private void payFeesButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cancelPayFeesButton_Click(object sender, RoutedEventArgs e)
>>>>>>> 15a958a (updated cs files for functionality)
        {

        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void CardNumberText_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void PaymentText_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }

   
}

