using System.Windows;
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

namespace LMS_WPFApp
{
    public partial class loginScreen : Window
    {
        private void loginButton_Click_1(object sender, RoutedEventArgs e)
        {

<<<<<<< HEAD
        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            
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
=======
>>>>>>> 15a958a (updated cs files for functionality)
        }

        private void quitButton_Click(object sender, RoutedEventArgs e)
        {
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



    }
}
=======


>>>>>>> c12f289 (first UI additions)
=======

        }
    }
}
>>>>>>> 15a958a (updated cs files for functionality)
