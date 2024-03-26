using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Threading;

namespace LMS_WPFApp
{
    public partial class teacherMenu : Window
    {
        private UserManager Users;
        private InventoryManager Inventory;

        public teacherMenu(UserManager users, InventoryManager inventory)
        {
            InitializeComponent();
            this.Users = users;
            this.Inventory = inventory;
            PopulateComboBox();
        }

        private void backTeacherMenuButton_Click(object sender, RoutedEventArgs e)
        {
            loginScreen loginScreen = new loginScreen(Users,Inventory);
            loginScreen.Show();
            Close();
        }
        private void PopulateComboBox()
        {
            usernameToDeleteCombo.Items.Clear();
            foreach (string username in Users.GetObjectsFromField("username"))
            {
                usernameToDeleteCombo.Items.Add(username);
            }

            //TOBY!!! Delete this if you're happy with the above^

            //string filePath = "userDatabase.csv";
            //string[] lines = File.ReadAllLines(filePath);
            //foreach (string line in lines.Skip(1))
            //{
            //    string[] fields = line.Split(',');
            //    usernameToDeleteCombo.Items.Add(fields[0]);
        }
        
        private void deleteUserButton_Click(object sender, RoutedEventArgs e)
        {
            string usernameToDelete = usernameToDeleteCombo.Text;
            
            MessageBoxResult result = MessageBox.Show($"Are you sure you want to delete the user with the username '{usernameToDelete}'?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                Users.DeleteObject(usernameToDelete);

                MessageBox.Show($"User with username '{usernameToDelete}' has been deleted.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                usernameToDeleteCombo.Text = "Select a user to delete...";
                PopulateComboBox();
            }   
        }
        private void createUserButton_Click(object sender, RoutedEventArgs e)
        {
            List<string> newUserList = new List<string>();

            string username = GenerateUsername(firstName.Text, lastName.Text);

            newUserList.Add(username);
            newUserList.Add(accessLevel.Text);
            newUserList.Add(lastName.Text.ToLower());
            newUserList.Add(firstName.Text.ToLower());
            newUserList.Add(balance.Text);
            newUserList.Add(password.Text);

            Users.CreateNewObject(newUserList);
            MessageBox.Show($"Generated Username: '{username}' Password: '{password.Text}'", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            return;
        }
        
        private bool ContainsNumber(string text)
        {
            return text.Any(char.IsDigit);
        }

        private bool IsNumeric(string text)
        {
            return double.TryParse(text, out _);
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
            // RNG x4
            Random random = new Random();
            int randomNumber = random.Next(1000, 10000);

            // RLG x1
            char randomLetter = (char)random.Next('a', 'z' + 1);

            // Username Construction
            string username = $"{firstName[0]}{lastName[0]}{randomNumber}{randomLetter}";

            string filePath = "userDatabase.csv";

            if (UsernameExists(filePath,username))
            {
                return GenerateUsername(firstName, lastName);
            }

            return username;
        }
        private bool UsernameExists(string filePath, string username)
        {

            string[] lines = File.ReadAllLines(filePath);


            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                string existingUsername = fields[0];

                
                if (existingUsername == username)
                {
                    return true;
                }
            }

            return false;
        }

        private void usernameComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            return;
        }

        private void balance_TextChanged(object sender, TextChangedEventArgs e)
        {
            return;
        }
    }
}