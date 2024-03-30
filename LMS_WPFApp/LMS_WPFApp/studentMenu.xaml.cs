using System.Windows;

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 15a958a (updated cs files for functionality)
namespace LMS_WPFApp
{
    public partial class studentMenu : Window
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 6544e31 (Added user creation, user deletion, login system, finished teacher menu basics)
        public studentMenu()
=======
        private UserManager Users;
        private InventoryManager Inventory;
<<<<<<< HEAD
        public studentMenu(UserManager users, InventoryManager inventory)
>>>>>>> 9a8e0ad (Add/Mod: Lots of changes. Implemented interface in login screen. Teacher menu has some implementation as well. Moved csv files to /bin)
=======
        private List<string> userData;
        private string username;
        public studentMenu(UserManager users, InventoryManager inventory, string username)
>>>>>>> d94b79e (Add/Mod: Removed redundant code from teacher.cs. Prepped Student.cs for payments and inventory)
        {
            InitializeComponent();
            
            this.Users = users;
            this.Inventory = inventory;
            userData = Users.GetObjectInfo(username);
            this.username = username;

            LoadDebtFromCSV(username);
            
        }
<<<<<<< HEAD
        private void payFeesButton_Click(object sender, RoutedEventArgs e)
        {
            paymentGateway paymentWindow = new paymentGateway(Users, Inventory,username);
            paymentWindow.Show();

            Close();
            int newBalance = 0; //shuvo change this when you finish payment methods. need a return value for new balance
            Users.EditObject(userData[0], newBalance.ToString(), "balance");
            return;
        }

        private void logoutStudentMenu_Click(object sender, RoutedEventArgs e)
        {
            loginScreen loginScreen = new loginScreen(Users,Inventory);
            loginScreen.Show();
            Close();
=======
=======
>>>>>>> 6544e31 (Added user creation, user deletion, login system, finished teacher menu basics)
        private void payFeesButton_Click(object sender, RoutedEventArgs e)
        {
            return;
        }

        private void logoutStudentMenu_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD

>>>>>>> 15a958a (updated cs files for functionality)
=======
            loginScreen loginScreen = new loginScreen();
            loginScreen.Show();
            Close();
>>>>>>> 6544e31 (Added user creation, user deletion, login system, finished teacher menu basics)
        }

        private void inventoryButton_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
            //toby update this when you have inventory screen made. These params need to be passed in
            //inventoryScreen inventoryScreen = new inventoryScreen(Inventory, userData);
>>>>>>> d94b79e (Add/Mod: Removed redundant code from teacher.cs. Prepped Student.cs for payments and inventory)
            return;
        }

        private void LoadDebtFromCSV(string username)
        {
            try
            {
                string balance = Users.GetSpecificObjectData(username, "balance");
                double currentDebt = double.Parse(balance);
                currentDebtLabel.Content = $"Current Debt: £{currentDebt.ToString("0.00")}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading debt: {ex.Message}");
            }
        }

        
        private void populateBookInfo(string deweyDecimal)
        {
            return;

        }


    }
}
=======

>>>>>>> c12f289 (first UI additions)
=======

=======
            return;
>>>>>>> 6544e31 (Added user creation, user deletion, login system, finished teacher menu basics)
        }
    }
}
>>>>>>> 15a958a (updated cs files for functionality)
=======

>>>>>>> 4b11006 (first UI additions)
