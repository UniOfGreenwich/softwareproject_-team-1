using System.Windows;
using System.Windows.Controls;

namespace LMS_WPFApp
{
    public partial class studentMenu : Window
    {
        private UserManager Users;
        private InventoryManager Inventory;

        private List<string> userData;
        private string username;

        public studentMenu(UserManager users, InventoryManager inventory, string username)
        {
            InitializeComponent();
            this.Users = users;
            this.Inventory = inventory;
            userData = Users.GetObjectInfo(username);
            this.username = username;
        }

        private void payFeesButton_Click(object sender, RoutedEventArgs e)
        {
            paymentGateway paymentWindow = new paymentGateway(Users, Inventory, username);
            paymentWindow.Show();

            Close();
            int newBalance = 0; //shuvo change this when you finish payment methods. need a return value for new balance
            Users.EditObject(userData[0], newBalance.ToString(), "balance");
            return;
        }

        private void logoutStudentMenu_Click(object sender, RoutedEventArgs e)
        {
            loginScreen loginScreen = new loginScreen(Users, Inventory);
            loginScreen.Show();
            Close();
        }

        private void rentBookButton_Click(object sender, RoutedEventArgs e)
        {
            bookRental bookRental = new bookRental(Users, Inventory, username);
            bookRental.Show();
            Close();
        }
    }
}