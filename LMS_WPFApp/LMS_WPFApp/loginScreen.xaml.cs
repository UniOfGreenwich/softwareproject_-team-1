using System.Windows;
using System.Windows.Navigation;

namespace LMS_WPFApp
{
    public partial class loginScreen : Window
    {
        public loginScreen()
        {
            InitializeComponent();
        }

        private void loginButton_Click_1(object sender, RoutedEventArgs e)
        {
            teacherMenu teacherMenu = new teacherMenu();
            teacherMenu.Show();
            Close();
        }

        private void quitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


    }
}