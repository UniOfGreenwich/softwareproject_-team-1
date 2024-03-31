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

            titleSearch.Text = "Search Title";
            authorSearch.Text = "Search Author";
            isbnSearch.Text = "Search ISBN";

            List<String> durations = "Select Duration,3 Days,7 Days,14 Days".Split(',').ToList();
            rentDuration.ItemsSource = durations;
            rentDuration.SelectedIndex = 0;

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
            matchingTitles.Insert(0, "Select Result");

            if (!string.IsNullOrWhiteSpace(searchTitle) && searchTitle != "Search Title")
            {
                authorSearch.IsEnabled = false;
                isbnSearch.IsEnabled = false;
                foreach (var bookInfo in Inventory.inventoryList)
                {
                    string title = bookInfo[Inventory.inventoryHeaders.IndexOf("title")];
                    if (title.ToLower().Contains(searchTitle.ToLower()))
                    {
                        if (bookInfo[Inventory.inventoryHeaders.IndexOf("possession")] == "")
                        {
                            matchingTitles.Add(title);

                        }
                    }
                }
            }
            else
            {
                authorSearch.IsEnabled = true;
                isbnSearch.IsEnabled = true;
            }
            results.ItemsSource = matchingTitles;
            results.SelectedIndex = 0;
        }

        private void authorSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchAuthor = authorSearch.Text;
            List<string> matchingTitles = new List<string>();
            matchingTitles.Insert(0, "Select Result");

            if (!string.IsNullOrWhiteSpace(searchAuthor) && searchAuthor != "Search Author")
            {
                titleSearch.IsEnabled = false;
                isbnSearch.IsEnabled = false;
                foreach (var bookInfo in Inventory.inventoryList)
                {
                    string author = bookInfo[Inventory.inventoryHeaders.IndexOf("authors")];
                    if (author.ToLower().Contains(searchAuthor.ToLower()))
                    {
                        if (bookInfo[Inventory.inventoryHeaders.IndexOf("possession")] == "")
                        {
                            matchingTitles.Add(bookInfo[Inventory.inventoryHeaders.IndexOf("title")]);

                        }
                    }
                }
                results.ItemsSource = matchingTitles;
            }
            else
            {
                titleSearch.IsEnabled = true;
                isbnSearch.IsEnabled = true;
            }
            results.ItemsSource = matchingTitles;
            results.SelectedIndex = 0;
        }

        private void isbnSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchISBN = isbnSearch.Text;
            List<string> matchingTitles = new List<string>();
            matchingTitles.Insert(0, "Select Result");

            if (!string.IsNullOrWhiteSpace(searchISBN) && searchISBN != "Search ISBN")
            {
                titleSearch.IsEnabled = false;
                authorSearch.IsEnabled = false;
                foreach (var bookInfo in Inventory.inventoryList)
                {
                    string isbn = bookInfo[Inventory.inventoryHeaders.IndexOf("ISBN")];
                    if (isbn.ToLower().Contains(searchISBN.ToLower()))
                    {
                        if (bookInfo[Inventory.inventoryHeaders.IndexOf("possession")] == "")
                        {
                            matchingTitles.Add(bookInfo[Inventory.inventoryHeaders.IndexOf("title")]);

                        }                    }
                }
                results.ItemsSource = matchingTitles;
            }
            else
            {
                titleSearch.IsEnabled = true;
                authorSearch.IsEnabled = true;
            }
            results.ItemsSource = matchingTitles;
            results.SelectedIndex = 0;
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            string title = results.SelectedItem.ToString();
            if (title == "Select Result")
            {
                MessageBox.Show("Please select a book.");
                return;
            }
            string duration = rentDuration.SelectedItem.ToString();
            if (duration == "Select Duration")
            {
                MessageBox.Show("Please select a duration.");
                return;
            }
            string currentDate = DateTime.Now.ToString();

            Inventory.EditObject(title, username, "possession");
            Inventory.EditObject(title, currentDate, "possessionStart");
            Inventory.EditObject(title, duration, "duration");

            MessageBox.Show("Book Rental Successfully Registered", "Poopsie Whoopsie", MessageBoxButton.OK, MessageBoxImage.Information);

            bookRental bookRental = new bookRental(Users, Inventory, username);
            bookRental.Show();
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