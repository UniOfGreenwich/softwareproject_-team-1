using System.Windows;
using System.IO;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;

namespace LMS_WPFApp
{
    public partial class loginScreen : Window
    {
        UserManager Users = new UserManager();
        InventoryManager Inventory = new InventoryManager();

        public loginScreen()
        {
            InitializeComponent();
            Users.OpenDatabaseFile();
            Inventory.OpenDatabaseFile();
        }

        public loginScreen(UserManager users, InventoryManager inventory)
        {
            InitializeComponent();
            this.Users = users;
            this.Inventory = inventory;
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = UserManager.ToSHA512(passwordTextBox.Password);
            //MessageBox.Show(UserManager.ToSHA512(password));
            
            // Checks if user exists in database.
            if (Users.FindObjectInList(username) == -1)
            {
                MessageBox.Show("Username not found. Are you a bot?", "Oopsie Poopsie!", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
                //throw new Exception("Username not found. Are you a bot?");
            }

            // Checks if password is null or password is not equal to value returned from database.
            if (password == null || password != Users.GetSpecificObjectData(username, "password"))
            {
                MessageBox.Show("Password not valid.", "Oopsie Poopsie!", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
                //throw new Exception("Invalid password! Try again..");
            }

            // Gets access level from Users. Switch statement to choose which menu based on access.
            switch(Int32.Parse(Users.GetSpecificObjectData(username, "accessLevel")))
            {
                default:
                    studentMenu studentMenu = new studentMenu(Users, Inventory, username);
                    studentMenu.Show();
                    break;

                case 1:
                    teacherMenu teacherMenu = new teacherMenu(Users, Inventory);
                    teacherMenu.Show();
                    break;
            }

            // Close window after login?
            Close();
        
        }

        // Closes application window if quit pressed
        private void quitButton_Click(object sender, RoutedEventArgs e)
        {
            Users.CloseDatabaseFile();
            Inventory.CloseDatabaseFile();
            Close();
        }
    }
}