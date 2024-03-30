using System.Windows;

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

            LoadDebtFromCSV(username);
            
        }
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
        }

        private void inventoryButton_Click(object sender, RoutedEventArgs e)
        {
            //toby update this when you have inventory screen made. These params need to be passed in
            //inventoryScreen inventoryScreen = new inventoryScreen(Inventory, userData);
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