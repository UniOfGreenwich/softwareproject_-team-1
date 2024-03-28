using System.Windows;

namespace LMS_WPFApp
{
    public partial class paymentGateway : Window
    {
        /*private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
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
        {

        }

       
    }

   
}

