using System.Windows;
using System.Windows.Controls;

namespace LMS_WPFApp
{
    public partial class bookRental : Window
    {
        private UserManager Users;
        private InventoryManager Inventory;
        private List<string> userData;
        private string username;

        public bookRental(UserManager users, InventoryManager inventory, string username)
        {
            InitializeComponent();
            this.Users = users;
            this.Inventory = inventory;
            userData = Users.GetObjectInfo(username);
            this.username = username;
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if ((tb.Text == "Search Title") || (tb.Text == "Search Author") || (tb.Text == "Search ISBN"))
            {
                tb.Text = "";
            }
        }
        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                if (tb.Name == "titleSearch")
                {
                    tb.Text = "Search Title";
                }
                else if (tb.Name == "authorSearch")
                {
                    tb.Text = "Search Author";
                }
                else if (tb.Name == "isbnSearch")
                {
                    tb.Text = "Search ISBN";
                }
            }
        }
        
        private void titleSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchTitle = titleSearch.Text;
            List<string> matchingTitles = new List<string>();

            if (!string.IsNullOrWhiteSpace(searchTitle) && searchTitle != "Search Title")
            {
                authorSearch.IsEnabled = false;
                isbnSearch.IsEnabled = false;
                foreach (var bookInfo in Inventory.inventoryList)
                {
                    string title = bookInfo[Inventory.tableHeaders.IndexOf("title")];
                    if (title.ToLower().Contains(searchTitle.ToLower()))
                    {
                        matchingTitles.Add(title);
                    }
                }
                results.ItemsSource = matchingTitles;
            }
            else
            {
                authorSearch.IsEnabled = true;
                isbnSearch.IsEnabled = true;
            }
        }

        private void authorSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchAuthor = authorSearch.Text;
            List<string> matchingTitles = new List<string>();

            if (!string.IsNullOrWhiteSpace(searchAuthor) && searchAuthor != "Search Author")
            {
                titleSearch.IsEnabled = false;
                isbnSearch.IsEnabled = false;
                foreach (var bookInfo in Inventory.inventoryList)
                {
                    string author = bookInfo[Inventory.tableHeaders.IndexOf("authors")];
                    if (author.ToLower().Contains(searchAuthor.ToLower()))
                    {
                        matchingTitles.Add(bookInfo[Inventory.tableHeaders.IndexOf("title")]);
                    }
                }
                results.ItemsSource = matchingTitles;
            }
            else
            {
                titleSearch.IsEnabled = true;
                isbnSearch.IsEnabled = true;
            }
        }

        private void isbnSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchISBN = isbnSearch.Text;
            List<string> matchingTitles = new List<string>();

            if (!string.IsNullOrWhiteSpace(searchISBN) && searchISBN != "Search ISBN")
            {
                titleSearch.IsEnabled = false;
                authorSearch.IsEnabled = false;
                foreach (var bookInfo in Inventory.inventoryList)
                {
                    string isbn = bookInfo[Inventory.tableHeaders.IndexOf("ISBN")];
                    if (isbn.ToLower().Contains(searchISBN.ToLower()))
                    {
                        matchingTitles.Add(bookInfo[Inventory.tableHeaders.IndexOf("title")]);
                    }
                }
                results.ItemsSource = matchingTitles;
            }
            else
            {
                titleSearch.IsEnabled = true;
                authorSearch.IsEnabled = true;
            }
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            studentMenu studentMenu = new studentMenu(Users, Inventory, username);
            studentMenu.Show();
            Close();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            studentMenu studentMenu = new studentMenu(Users, Inventory, username);
            studentMenu.Show();
            Close();
        }
    }
}