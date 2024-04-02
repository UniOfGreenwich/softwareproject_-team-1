using System.Windows;
using System.Windows.Controls;

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
<<<<<<< HEAD
        public studentMenu(UserManager users, InventoryManager inventory)
>>>>>>> 9a8e0ad (Add/Mod: Lots of changes. Implemented interface in login screen. Teacher menu has some implementation as well. Moved csv files to /bin)
=======
=======

>>>>>>> d07a775 (What's New:)
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
<<<<<<< HEAD
=======

>>>>>>> d07a775 (What's New:)
        private void payFeesButton_Click(object sender, RoutedEventArgs e)
        {
            string balance = Users.GetSpecificObjectData(username, "balance");
            paymentGateway paymentWindow = new paymentGateway(Users, Inventory, username, balance);
            paymentWindow.Show();

            Close();
            LoadDebtFromCSV(username);
            // int newBalance = 0; //shuvo change this when you finish payment methods. need a return value for new balance
            // Users.EditObject(userData[0], newBalance.ToString(), "balance");
            return;
        }

        private void logoutStudentMenu_Click(object sender, RoutedEventArgs e)
        {
            loginScreen loginScreen = new loginScreen(Users, Inventory);
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

        // Open the book rental window
        private void rentBookButton_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
            //toby update this when you have inventory screen made. These params need to be passed in
            //inventoryScreen inventoryScreen = new inventoryScreen(Inventory, userData);
>>>>>>> d94b79e (Add/Mod: Removed redundant code from teacher.cs. Prepped Student.cs for payments and inventory)
            return;
=======
            bookRental bookRental = new bookRental(Users, Inventory, username);
            bookRental.Show();
            Close();
>>>>>>> d07a775 (What's New:)
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
