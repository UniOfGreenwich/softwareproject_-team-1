using System.Windows;

namespace LMS_WPFApp
{
    public partial class studentMenu : Window
    {
        private UserManager Users;
        private InventoryManager Inventory;
        public studentMenu(UserManager users, InventoryManager inventory)
        {
            InitializeComponent();
            this.Users = users;
            this.Inventory = inventory;
        }
        private void payFeesButton_Click(object sender, RoutedEventArgs e)
        {
            return;
        }

        private void logoutStudentMenu_Click(object sender, RoutedEventArgs e)
        {
            loginScreen loginScreen = new loginScreen();
            loginScreen.Show();
            Close();
        }

        private void inventoryButton_Click(object sender, RoutedEventArgs e)
        {
            return;
        }
    }
}