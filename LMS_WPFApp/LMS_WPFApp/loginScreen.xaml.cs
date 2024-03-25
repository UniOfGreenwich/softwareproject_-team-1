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

        public loginScreen()
        {
            InitializeComponent();
            
        }


        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
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
                
            //    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            //}
        }

        // Closes application window if quit pressed
        private void quitButton_Click(object sender, RoutedEventArgs e)
        {
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
    }
}