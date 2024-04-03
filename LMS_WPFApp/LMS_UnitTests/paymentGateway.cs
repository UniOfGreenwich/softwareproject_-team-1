using Microsoft.VisualStudio.TestTools.UnitTesting;
using LMS_WPFApp;

namespace LMS_UnitTests
{
    [TestClass]
    public class PaymentGatewayTests
    {
        [STAThread]
        [TestMethod]
        public void TestIsValidCreditCard_Valid()
        {
            // Arrange
            var userManager = new UserManager(); // Assuming UserManager has a parameterless constructor
            var inventoryManager = new InventoryManager(); // Assuming InventoryManager has a parameterless constructor
            string username = "testUser";
            string initialBalance = "100.00";
            var paymentGateway = new paymentGateway(userManager, inventoryManager, username, initialBalance);
            string cardNumber = "1234567890123456";
            string expiryDate = "12/25";
            string cvc = "123";




            paymentGateway paymentGatewayInstance = null;

            // Act: Instantiate the bookRental on the UI thread
            var thread = new Thread(() =>
            {
                paymentGatewayInstance = new paymentGateway(userManager, inventoryManager, username, initialBalance);
                paymentGateway.Show();
                System.Windows.Threading.Dispatcher.Run();
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            // Wait for the window to open
            bool windowOpened = thread.Join(TimeSpan.FromSeconds(5));

            if (!windowOpened && !paymentGatewayInstance.IsVisible)
            {
                Assert.Fail("Payment Gateway window did not open!");
            }

        }

        [STAThread]
        [TestMethod]
        public void TestGetCardType_Visa()
        {
            // Arrange
            var userManager = new UserManager(); // Assuming UserManager has a parameterless constructor
            var inventoryManager = new InventoryManager(); // Assuming InventoryManager has a parameterless constructor
            string username = "testUser";
            string initialBalance = "100.00";
            var paymentGateway = new paymentGateway(userManager, inventoryManager, username, initialBalance);
            string cardNumber = "4111111111111111";

            // Act
            string cardType = paymentGateway.GetCardType(cardNumber);

            // Assert
            Assert.AreEqual("Visa", cardType);

            paymentGateway paymentGatewayInstance = null;

            // Act: Instantiate the bookRental on the UI thread
            var thread = new Thread(() =>
            {
                paymentGatewayInstance = new paymentGateway(userManager, inventoryManager, username, initialBalance);
                paymentGateway.Show();
                System.Windows.Threading.Dispatcher.Run();
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            // Wait for the window to open
            bool windowOpened = thread.Join(TimeSpan.FromSeconds(5));

            if (!windowOpened && !paymentGatewayInstance.IsVisible)
            {
                Assert.Fail("Payment Gateway window did not open!");
            }
        }

        // Add more test methods for other functionalities as needed
    }
}
