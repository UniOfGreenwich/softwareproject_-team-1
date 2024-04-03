using System.Windows;

namespace LMS_WPFApp
{
    public partial class paymentGateway : Window
    {
        private UserManager Users;
        private InventoryManager Inventory;
        private List<string> userData;
        private string username;
        private string initialBalance;

        public paymentGateway(UserManager users, InventoryManager inventory, string username, string initialBalance)
        {
            InitializeComponent();
            this.Users = users;
            this.Inventory = inventory;
            userData = Users.GetObjectInfo(username);
            this.username = username;
            this.initialBalance = initialBalance;


             owedMoniesLabel.Content = $"Owed Monies: £{initialBalance}";
        }
        private void payFeesButton_Click(object sender, RoutedEventArgs e)
        {
            string cardNumber = CardNumberText.Text;
            string expiryDate = ExpiryDateText.Text;
            string cvc = CvcText.Text;
            float paymentAmount = float.Parse(PaymentText.Text);

            // Calculate the new balance
            float currentBalance = float.Parse(initialBalance);
            float newBalance = currentBalance - paymentAmount;

            if (newBalance < 0)
            {
                MessageBox.Show("Payment amount exceeds the current debt.");
                return;
            }


            // Update the balance in the database
            Users.EditObject(username, newBalance.ToString(), "balance");

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
        public bool IsValidCreditCard(string cardNumber, string expiryDate, string cvc)
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
        public string GetCardType(string cardNumber)
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

