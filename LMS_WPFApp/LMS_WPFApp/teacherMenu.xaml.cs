using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace LMS_WPFApp
{
    public partial class teacherMenu : Window
    {
       
        private void deleteUserButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void createUserButton_Click(object sender, RoutedEventArgs e)
        {
            string firstNameValue = firstName.Text;
            string lastNameValue = lastName.Text;
            string accessLevelValue = accessLevel.Text;
            string balanceValue = Balance.Text;

            string username = GenerateUsername(firstNameValue, lastNameValue);

            // Path to the CSV file
            string filePath = "userData.csv";

            // Write data to the CSV file
            using (StreamWriter writer = new StreamWriter(filePath, true, Encoding.UTF8))
            {
                // If the file doesn't exist, write header
                if (new FileInfo(filePath).Length == 0)
                {
                    writer.WriteLine("Username,First Name,Last Name,Access Level,Balance");
                }

                // Write data to the file
                writer.WriteLine($"{username},{firstNameValue},{lastNameValue},{accessLevelValue},{balanceValue}".ToLower()); ;
            }

            // Optionally, you can display a message indicating that the data has been saved.
            MessageBox.Show("User data has been saved to userData.csv", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private string ghostText = "enter text here";
        public teacherMenu()
        {
            InitializeComponent();
        }
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "Enter text here...")
            {
                tb.Text = "";
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                tb.Text = "Enter text here...";
            }
        }
        private string GenerateUsername(string firstName, string lastName)
        {
            // Generate a random 4-digit number
            Random random = new Random();
            int randomNumber = random.Next(1000, 10000);

            // Generate a random letter
            char randomLetter = (char)random.Next('a', 'z' + 1);

            // Construct username using first letters of first and last name, random number, and random letter
            string username = $"{firstName[0]}{lastName[0]}{randomNumber}{randomLetter}";

            return username;
        }


    }
}