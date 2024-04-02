using System.Windows;
using System.Windows.Controls;

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
            loginScreen loginScreen = new loginScreen(Users, Inventory);
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
        }
        public void deleteUserButton_Click(object sender, RoutedEventArgs e)
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
        private void balance_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Add your implementation here
        }
        private void usernameComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Add your implementation here
        }

        public void createUserButton_Click(object sender, RoutedEventArgs e)
        {
            List<string> newUserList = new List<string>();

            string username = GenerateUsername(firstName.Text, lastName.Text);
            string newPassword = UserManager.ToSHA512(password.Text);
            
            newUserList.Add(username);
            newUserList.Add(newPassword);
            newUserList.Add(accessLevel.Text);
            newUserList.Add(lastName.Text.ToLower());
            newUserList.Add(firstName.Text.ToLower());
            newUserList.Add(balance.Text);

            Users.CreateNewObject(newUserList);
            MessageBox.Show($"Generated Username: '{username}' Password: '{newPassword}'", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            return;
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
        public string GenerateUsername(string firstName, string lastName)
        {
            // RNG x4
            Random random = new Random();
            int randomNumber = random.Next(1000, 10000);

            // RLG x1
            char randomLetter = (char)random.Next('a', 'z' + 1);

            // Username Construction
            string username = $"{firstName[0]}{lastName[0]}{randomNumber}{randomLetter}";

            if (Users.FindObjectInList(username) == -1)
            {
                return username;
            }
            else
            {
                return GenerateUsername(firstName, lastName);
            }
        }

        private void firstName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void lastName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void accessLevel_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void balance_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void usernameToDeleteCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void password_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}