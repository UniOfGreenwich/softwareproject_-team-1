using System.Windows;

namespace LMS_WPFApp
{
    public partial class studentMenu : Window
    {
        public studentMenu()
        {
            InitializeComponent();
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