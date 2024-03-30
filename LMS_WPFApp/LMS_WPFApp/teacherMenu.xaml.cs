<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 832661b (Added functionality to the teacherMenu for methods for adding people to the database. More functionality is needed here, adding tomorrow.)
﻿using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 6544e31 (Added user creation, user deletion, login system, finished teacher menu basics)
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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            
=======
>>>>>>> 9a8e0ad (Add/Mod: Lots of changes. Implemented interface in login screen. Teacher menu has some implementation as well. Moved csv files to /bin)
            usernameToDeleteCombo.Items.Clear();
            foreach (string username in Users.GetObjectsFromField("username"))
            {
                usernameToDeleteCombo.Items.Add(username);
            }
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
        private string GenerateUsername(string firstName, string lastName)
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
=======
﻿using System.Windows;
=======
>>>>>>> 832661b (Added functionality to the teacherMenu for methods for adding people to the database. More functionality is needed here, adding tomorrow.)

namespace LMS_WPFApp
{
    public partial class teacherMenu : Window
    {
<<<<<<< HEAD
        private void createUserButton_Click(object sender, RoutedEventArgs e)
        {

<<<<<<< HEAD
>>>>>>> c12f289 (first UI additions)
=======
        }

=======
       
>>>>>>> 832661b (Added functionality to the teacherMenu for methods for adding people to the database. More functionality is needed here, adding tomorrow.)
=======
            // Clear the ComboBox items
=======
            
>>>>>>> 6544e31 (Added user creation, user deletion, login system, finished teacher menu basics)
            usernameToDeleteCombo.Items.Clear();

            
            string filePath = "userDatabase.csv";

            
            string[] lines = File.ReadAllLines(filePath);

            
            foreach (string line in lines.Skip(1))
            {
                string[] fields = line.Split(',');

                
                usernameToDeleteCombo.Items.Add(fields[0]);
            }
        }
        
>>>>>>> cf83c19 (Further Functionality to the User Management Window)
        private void deleteUserButton_Click(object sender, RoutedEventArgs e)
        {
            string usernameToDelete = usernameToDeleteCombo.Text;
            if (usernameToDelete == "Enter text here...")
            {
                return;
            }
            MessageBoxResult result = MessageBox.Show($"Are you sure you want to delete the user with the username '{usernameToDelete}'?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {

                string filePath = "userDatabase.csv";


                string[] lines = File.ReadAllLines(filePath);

                bool userFound = false;


                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (string line in lines)
                    {
                       
                        string[] fields = line.Split(',');

                       
                        if (fields.Length > 0 && fields[0] == usernameToDelete)
                        {
                       
                            userFound = true;
                            continue;
                        }

                       
                        writer.WriteLine(line);
                    }
                }

                if (userFound)
                {
                    MessageBox.Show($"User with username '{usernameToDelete}' has been deleted.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    usernameToDeleteCombo.Text = "Select a user to delete...";
                    PopulateComboBox();
                } else
                {
                    MessageBox.Show($"User '{usernameToDelete}' does not exist.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                
            }
            
        }
        private void createUserButton_Click(object sender, RoutedEventArgs e)
        {
            string firstNameValue = firstName.Text.ToLower();
            string lastNameValue = lastName.Text.ToLower();
            string accessLevelValue = accessLevel.Text;
            string balanceValue = balance.Text;
            string passwordValue = password.Text;

            if (firstNameValue == "Enter text here..." || lastNameValue == "Enter text here..." || accessLevelValue == "Enter text here..." || balanceValue == "Enter text here..." || passwordValue == "Enter text here..." || 
                ContainsNumber(firstNameValue) || ContainsNumber(lastNameValue) || !IsNumeric(accessLevelValue) || !IsNumeric(balanceValue) || (accessLevelValue != "0" && accessLevelValue != "1"))
            {
                MessageBox.Show("Incorrect Input", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            } else
            {
                firstName.Text = "Enter text here...";
                lastName.Text = "Enter text here...";
                accessLevel.Text = "Enter text here...";
                balance.Text = "Enter text here...";
                password.Text = "Enter text here...";

            }
            string username = GenerateUsername(firstNameValue, lastNameValue);


            string filePath = "userDatabase.csv";


            using (StreamWriter writer = new StreamWriter(filePath, true, Encoding.UTF8))
            {

                if (new FileInfo(filePath).Length == 0)
                {
                    writer.WriteLine("Username,Password,First Name,Last Name,Access Level,Balance");
                }


                writer.WriteLine($"{username},{passwordValue},{accessLevelValue},{firstNameValue},{lastNameValue},{balanceValue}");
                
            }


            MessageBox.Show($"Generated Username: '{username}' Password: '{passwordValue}'", "Information", MessageBoxButton.OK, MessageBoxImage.Information);

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

        public teacherMenu()
        {
            InitializeComponent();
            PopulateComboBox();
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
>>>>>>> 15a958a (updated cs files for functionality)
=======
﻿using System.Windows;


>>>>>>> 4b11006 (first UI additions)
