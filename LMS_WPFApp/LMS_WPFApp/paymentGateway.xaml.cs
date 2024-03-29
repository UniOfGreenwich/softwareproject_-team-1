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
<<<<<<< HEAD
        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
=======
        /*private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
>>>>>>> 70e15b7 (Part of PaymentGateway)
=======
        private UserManager Users;
        private InventoryManager Inventory;
        private List<string> userData;
        private string username;

        public paymentGateway(UserManager users, InventoryManager inventory, string username)
>>>>>>> 306453d (updates of paymentGateway)
        {
            InitializeComponent();
            this.Users = users;
            this.Inventory = inventory;
            userData = Users.GetObjectInfo(username);
            this.username = username;
        }
        private void payFeesButton_Click(object sender, RoutedEventArgs e)
        {
            string cardNumber = CardNumberText.Text;
            string expiryDate = ExpiryDateText.Text;
            string cvc = CvcText.Text;
            float paymentAmount = float.Parse(PaymentText.Text);

            if (!IsValidCreditCard(cardNumber, expiryDate, cvc))
            {
                MessageBox.Show("Invalid credit card details. Please check and try again.");
                return;
            }

            // Check if the payment amount is greater than 0
            if (paymentAmount <= 0)
            {
                MessageBox.Show("Payment amount must be greater than 0.");
                return;
            }

            // Payment successful
            string cardType = GetCardType(cardNumber);
            MessageBox.Show("Payment successful! Card Type: " + cardType);

            studentMenu menu = new studentMenu(Users, Inventory, username);
            menu.Show();
            // Close the paymentGateway window
            Close();
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
            

            // Show the studentMenu window
            studentMenu menu = new studentMenu(Users, Inventory,username);
            menu.Show();
            // Close the paymentGateway window
            Close();
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

