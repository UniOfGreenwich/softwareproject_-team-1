using System.Windows;

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
        public studentMenu(UserManager users, InventoryManager inventory)
>>>>>>> 9a8e0ad (Add/Mod: Lots of changes. Implemented interface in login screen. Teacher menu has some implementation as well. Moved csv files to /bin)
        {
            InitializeComponent();
            this.Users = users;
            this.Inventory = inventory;
        }
<<<<<<< HEAD
        private void payFeesButton_Click(object sender, RoutedEventArgs e)
        {
            return;
        }

        private void logoutStudentMenu_Click(object sender, RoutedEventArgs e)
        {
            loginScreen loginScreen = new loginScreen();
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
