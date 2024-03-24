using System.Windows;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
using System.IO;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LMS_WPFApp
{
    public partial class loginScreen : Window
    {
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
        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
=======
>>>>>>> 6544e31 (Added user creation, user deletion, login system, finished teacher menu basics)
            
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Password;

            
            bool isAuthenticated = AuthenticateUser(username, password);

            if (isAuthenticated)
            {
                
                string accessLevel = GetUserAccessLevel(username);

                
                if (accessLevel == "1")
                {
                    teacherMenu teacherMenu = new teacherMenu();
                    teacherMenu.Show();
                }
                else if (accessLevel == "0")
                {
                    studentMenu studentMenu = new studentMenu();
                    studentMenu.Show();
                }

                
                Close();
            }
            else
            {
                
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
        }

        private void quitButton_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            Close();
        }

        
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
