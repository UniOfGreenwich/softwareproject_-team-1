using System.Windows;
using System.Windows.Controls;

namespace LMS_WPFApp
{
    public partial class bookRental : Window
    {
        // Initialize the UserManager and InventoryManager objects
        private UserManager Users;
        private InventoryManager Inventory;
        private List<string> userData;
        private string username;

        public bookRental(UserManager users, InventoryManager inventory, string username)
        {
            // Initialize the window
            InitializeComponent();

            // Set the UserManager and InventoryManager objects
            this.Users = users;
            this.Inventory = inventory;
            userData = Users.GetObjectInfo(username);
            this.username = username;

            // Set default text for search boxes
            titleSearch.Text = "Search Title";
            authorSearch.Text = "Search Author";
            isbnSearch.Text = "Search ISBN";

            // Populate the rent duration combobox
            List<String> durations = "Select Duration,3 Days,7 Days,14 Days".Split(',').ToList();
            rentDuration.ItemsSource = durations;
            rentDuration.SelectedIndex = 0;

        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            // If the textbox contains default text, clear it
            TextBox tb = (TextBox)sender;
            if ((tb.Text == "Search Title") || (tb.Text == "Search Author") || (tb.Text == "Search ISBN"))
            {
                tb.Text = "";
            }
        }
        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            // If the textbox is empty, fill with default text
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
        
        // Search for books by title
        private void titleSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Get the search string
            string searchTitle = titleSearch.Text;
            // Create a list to store matching titles
            List<string> matchingTitles = new List<string>();
            // Add the default text to the list of matching titles
            matchingTitles.Insert(0, "Select Result");

            // If the search string is not empty and not the default text
            if (!string.IsNullOrWhiteSpace(searchTitle) && searchTitle != "Search Title")
            {
                // Disable the other search boxes
                authorSearch.IsEnabled = false;
                isbnSearch.IsEnabled = false;
                // Search for books with matching titles
                foreach (var bookInfo in Inventory.inventoryList)
                {
                    // Get the title of the book
                    string title = bookInfo[Inventory.inventoryHeaders.IndexOf("title")];
                    // If the title contains the search string and the book is not rented
                    if (title.ToLower().Contains(searchTitle.ToLower()))
                    {
                        // If the book is not rented, add it to the list of matching titles
                        if (bookInfo[Inventory.inventoryHeaders.IndexOf("possession")] == "")
                        {
                            // Add the title to the list of matching titles
                            matchingTitles.Add(title);

                        }
                    }
                }
            }
            else
            {
                // Enable the other search boxes
                authorSearch.IsEnabled = true;
                isbnSearch.IsEnabled = true;
            }
            // Set the list of matching titles as the source for the results combobox
            results.ItemsSource = matchingTitles;
            results.SelectedIndex = 0;
        }

        // Search for books by author
        private void authorSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Get the search string
            string searchAuthor = authorSearch.Text;
            // Create a list to store matching titles
            List<string> matchingTitles = new List<string>();
            // Add the default text to the list of matching titles
            matchingTitles.Insert(0, "Select Result");

            // If the search string is not empty and not the default text
            if (!string.IsNullOrWhiteSpace(searchAuthor) && searchAuthor != "Search Author")
            {
                // Disable the other search boxes
                titleSearch.IsEnabled = false;
                isbnSearch.IsEnabled = false;
                // Search for books with matching authors
                foreach (var bookInfo in Inventory.inventoryList)
                {
                    // Get the author of the book
                    string author = bookInfo[Inventory.inventoryHeaders.IndexOf("authors")];
                    // If the author contains the search string and the book is not rented
                    if (author.ToLower().Contains(searchAuthor.ToLower()))
                    {
                        // If the book is not rented, add it to the list of matching titles
                        if (bookInfo[Inventory.inventoryHeaders.IndexOf("possession")] == "")
                        {
                            // Add the title to the list of matching titles
                            matchingTitles.Add(bookInfo[Inventory.inventoryHeaders.IndexOf("title")]);

                        }
                    }
                }
                // Set the list of matching titles as the source for the results combobox
                results.ItemsSource = matchingTitles;
            }
            else
            {
                // Enable the other search boxes
                titleSearch.IsEnabled = true;
                isbnSearch.IsEnabled = true;
            }
            // Set the selected index of the results combobox to 0
            results.ItemsSource = matchingTitles;
            results.SelectedIndex = 0;
        }

        // Search for books by ISBN
        private void isbnSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Get the search string
            string searchISBN = isbnSearch.Text;
            // Create a list to store matching titles
            List<string> matchingTitles = new List<string>();
            // Add the default text to the list of matching titles
            matchingTitles.Insert(0, "Select Result");

            // If the search string is not empty and not the default text
            if (!string.IsNullOrWhiteSpace(searchISBN) && searchISBN != "Search ISBN")
            {
                // Disable the other search boxes
                titleSearch.IsEnabled = false;
                authorSearch.IsEnabled = false;
                // Search for books with matching ISBNs
                foreach (var bookInfo in Inventory.inventoryList)
                {
                    // Get the ISBN of the book
                    string isbn = bookInfo[Inventory.inventoryHeaders.IndexOf("ISBN")];
                    // If the ISBN contains the search string and the book is not rented
                    if (isbn.ToLower().Contains(searchISBN.ToLower()))
                    {
                        // If the book is not rented, add it to the list of matching titles
                        if (bookInfo[Inventory.inventoryHeaders.IndexOf("possession")] == "")
                        {
                            // Add the title to the list of matching titles
                            matchingTitles.Add(bookInfo[Inventory.inventoryHeaders.IndexOf("title")]);

                        }
                    }
                }
                // Set the list of matching titles as the source for the results combobox
                results.ItemsSource = matchingTitles;
            }
            else
            {
                // Enable the other search boxes
                titleSearch.IsEnabled = true;
                authorSearch.IsEnabled = true;
            }
            // Set the selected index of the results combobox to 0
            results.ItemsSource = matchingTitles;
            results.SelectedIndex = 0;
        }

        // Submit the book rental
        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected book title
            string title = results.SelectedItem.ToString();
            // If no book is selected, display an error message
            if (title == "Select Result")
            {
                // Display an error message
                MessageBox.Show("Please select a book.");
                return;
            }
            // Get the selected rental duration
            string duration = rentDuration.SelectedItem.ToString();
            // If no duration is selected, display an error message
            if (duration == "Select Duration")
            {
                // Display an error message
                MessageBox.Show("Please select a duration.");
                return;
            }
            // Get the current date
            string currentDate = DateTime.Now.ToString();

            // Edit the book information in the inventory
            Inventory.EditObject(title, username, "possession");
            Inventory.EditObject(title, currentDate, "possessionStart");
            Inventory.EditObject(title, duration, "duration");

            // Get the current balance
            MessageBox.Show("Book Rental Successfully Registered", "Poopsie Whoopsie", MessageBoxButton.OK, MessageBoxImage.Information);

            // Return to the student menu
            bookRental bookRental = new bookRental(Users, Inventory, username);
            bookRental.Show();
            Close();
        }

        // Return to the student menu
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            studentMenu studentMenu = new studentMenu(Users, Inventory, username);
            studentMenu.Show();
            Close();
        }
    }
}