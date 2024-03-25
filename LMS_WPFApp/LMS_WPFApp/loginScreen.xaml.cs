using System.Windows;
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

        public loginScreen()
        {
            InitializeComponent();
            
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
            string password = passwordTextBox.Password;

            // Is authenticate needed? We can split the following logic into its own "Authenticate method". Speak to George/Toby
            
            // Checks if user exists in database.
            if (Users.FindObjectInList(username) == -1)
            {
                throw new Exception("Username not found. Are you a bot?");
            }

            // Checks if password is null or password is not equal to value returned from database.
            if (password == null || password != Users.GetSpecificObjectData(username, "Password"))
            {
                throw new Exception("Invalid password! Try again..");
            }

            // Gets access level from Users. Switch statement to choose which menu based on access.
            switch(Int32.Parse(Users.GetSpecificObjectData(username, "AccessLevel")))
            {
                default:
                    studentMenu studentMenu = new studentMenu();
                    break;

                case 1:
                    teacherMenu teacherMenu = new teacherMenu();
                    break;
            }

            // Close window after login?
            Close();
            
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
        }

        // Closes application window if quit pressed
        private void quitButton_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            Close();
        }

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
