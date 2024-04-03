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
            UserManager testUserManager = new UserManager();
            testUserManager.OpenDatabaseFile();
            InventoryManager testInventoryManager = new InventoryManager();
            testInventoryManager.OpenDatabaseFile();

            string username = "jd1234a";
            string initialBalance = "100.00";
            

            paymentGateway paymentGatewayInstance = null;

            // Act: Instantiate the bookRental on the UI thread
            var thread = new Thread(() =>
            {
                paymentGatewayInstance = new paymentGateway(testUserManager, testInventoryManager, username, initialBalance);
                paymentGatewayInstance.Show();
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
            UserManager testUserManager = new UserManager();
            testUserManager.OpenDatabaseFile();
            InventoryManager testInventoryManager = new InventoryManager();
            testInventoryManager.OpenDatabaseFile();

            paymentGateway paymentGatewayInstance = null;

            string username = "jd1234a";
            string initialBalance = "100.00";

            // Act: Instantiate the bookRental on the UI thread
            var thread = new Thread(() =>
            {
                paymentGatewayInstance = new paymentGateway(testUserManager, testInventoryManager, username, initialBalance);
                paymentGatewayInstance.Show();
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


            string cardNumber = "4111111111111111";

            // Act
            string cardType = paymentGatewayInstance.GetCardType(cardNumber);

            // Assert
            Assert.AreEqual("Visa", cardType);
        }
    }
}
