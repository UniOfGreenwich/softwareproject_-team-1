using System.Windows;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
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
=======
using System.Windows.Navigation;
>>>>>>> 832661b (Added functionality to the teacherMenu for methods for adding people to the database. More functionality is needed here, adding tomorrow.)
=======
using System.IO;
using System.Windows.Navigation;
using System.Windows.Shapes;
>>>>>>> 6544e31 (Added user creation, user deletion, login system, finished teacher menu basics)

namespace LMS_WPFApp
{
    public partial class loginScreen : Window
    {
        public loginScreen()
        {
            InitializeComponent();
        }

        public loginScreen(UserManager users, InventoryManager inventory)
        {
            InitializeComponent();
            this.Users = users;
            this.Inventory = inventory;
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

<<<<<<< HEAD
        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
=======
>>>>>>> 6544e31 (Added user creation, user deletion, login system, finished teacher menu basics)
            
=======
>>>>>>> 035a63d (Changed logic in loginScreen.xaml.cs to reflect new UserManager class.)
            string username = usernameTextBox.Text;
            string password = UserManager.ToSHA512(passwordTextBox.Password);
            
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
<<<<<<< HEAD
            
            //bool isAuthenticated = AuthenticateUser(username, password);

            //if (isAuthenticated)
            //{
                
            //    string accessLevel = GetUserAccessLevel(username);
                
            //    if (accessLevel == "1")
            //    {
            //        teacherMenu teacherMenu = new teacherMenu();
            //        teacherMenu.Show();
            //    }
            //    else if (accessLevel == "0")
            //    {
            //        studentMenu studentMenu = new studentMenu();
            //        studentMenu.Show();
            //    }

                
            //    Close();
            //}
            //else
            //{
                
<<<<<<< HEAD
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
<<<<<<< HEAD
=======
>>>>>>> 15a958a (updated cs files for functionality)
=======
            teacherMenu teacherMenu = new teacherMenu();
            teacherMenu.Show();
            Close();
>>>>>>> 832661b (Added functionality to the teacherMenu for methods for adding people to the database. More functionality is needed here, adding tomorrow.)
=======
>>>>>>> 6544e31 (Added user creation, user deletion, login system, finished teacher menu basics)
=======
            //    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            //}
>>>>>>> 035a63d (Changed logic in loginScreen.xaml.cs to reflect new UserManager class.)
=======
        
>>>>>>> 9a8e0ad (Add/Mod: Lots of changes. Implemented interface in login screen. Teacher menu has some implementation as well. Moved csv files to /bin)
        }

       /* private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            double scaleFactor = Math.Min(this.ActualWidth / 800, this.ActualHeight / 450)*0.5; // Adjust values according to your initial window size
                                                                                            // Now, you can scale your UI elements using the scaleFactor
                                                                                            // For example:
            usernameTextBox.FontSize = 14 * scaleFactor;
            // Adjust other UI elements similarly
        }*/

        // Closes application window if quit pressed
        private void quitButton_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
            Users.CloseDatabaseFile();
            Inventory.CloseDatabaseFile();
>>>>>>> 9a8e0ad (Add/Mod: Lots of changes. Implemented interface in login screen. Teacher menu has some implementation as well. Moved csv files to /bin)
            Close();
        }
<<<<<<< HEAD

        //TODO @george to update when authentication and password hashing complete. Is this method needed?
        private bool AuthenticateUser(string username, string password)
        {
            string filePath = "userDatabase.csv";
            string[] lines = File.ReadAllLines(filePath);
            
            foreach (string line in lines.Skip(1))
            {
                string[] fields = line.Split(',');
                string storedUsername = fields[0];
                string storedPassword = fields[1];

                if (username == storedUsername && password == storedPassword)
                {
                    return true;
                }
            }
            return false;
        }
<<<<<<< HEAD


        private string GetUserAccessLevel(string username)
        {
            string filePath = "userDatabase.csv";


            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines.Skip(1))
            {
                string[] fields = line.Split(',');

                string storedUsername = fields[0];
                string accessLevel = fields[2];

                
                if (username == storedUsername)
                {
                    return accessLevel;
                }
            }

            
            return "0";
        }


<<<<<<< HEAD

=======
>>>>>>> 035a63d (Changed logic in loginScreen.xaml.cs to reflect new UserManager class.)
=======
>>>>>>> 47e7a5a (Added password hashing.)
    }
}
=======


>>>>>>> c12f289 (first UI additions)
=======

=======
            Close();
>>>>>>> cf83c19 (Further Functionality to the User Management Window)
        }

=======
>>>>>>> 6544e31 (Added user creation, user deletion, login system, finished teacher menu basics)

    }
}
>>>>>>> 15a958a (updated cs files for functionality)
=======


>>>>>>> 4b11006 (first UI additions)
