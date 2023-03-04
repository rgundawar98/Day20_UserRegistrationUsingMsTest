using Day20UserRegistration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UserRegistrationTest
{
    [TestClass]
    public class UserRegistration
    {
        [TestMethod]
        [DataRow(new string[] { "Rahul", "Siva", "Ronny", "Divya", "Shivani" }, true)]
        [DataRow(new string[] { "rahul", "ganesh" }, false)]
        public void Check_For_First_Name(string[] arr, bool expected)
        {
            //Arrange
            Registration register = new Registration();
            foreach (string data in arr)
            {
                bool actual = register.Check_First_Name(data);
                //Assert
                Assert.AreEqual(actual, expected);
            }
        }
        [TestMethod]
        [DataRow(new string[] { "Dey", "Dixit", "Gundawar", "Rane" }, true)]
        [DataRow(new string[] { "gunne", "molly", "peter" }, false)]
        public void Check_For_Last_Name(string[] arr, bool expected)
        {
            Registration register = new Registration();
            foreach (string data in arr)
            {
                bool actual = register.Check_Last_Name(data);
                Assert.AreEqual(actual, expected);
            }
        }

        [TestMethod]
        [DataRow(new string[] { "abc.xyz@bl.co.in", "rahul.abc@bridglabz.co.in" }, true)]
        [DataRow(new string[] { "abc100@gmail.com" }, false)]
        public void Check_For_Email(string[] arr, bool expected)
        {
            Registration register = new Registration();
            foreach (string email in arr)
            {
                bool actual = register.Check_For_Email(email);
                Assert.AreEqual(actual, expected);
            }
        }

        [TestMethod]
        [DataRow(new string[] { "91 8087905735", "91 8421719373", "91 1234567890", "91 7894561230" }, true)]
        [DataRow(new string[] { "1 45677845", "2- 123456" }, false)]
        public void Check_For_Mobile_Number(string[] arr, bool expected)
        {
            Registration register = new Registration();
            foreach (string number in arr)
            {
                bool actual = register.Check_For_Mobile_Number(number);
                Assert.AreEqual(actual, expected);
            }
        }

        [TestMethod]
        [DataRow(new string[] { "RAHULg@1234", "123rahul@12", "Rahul@123", "111@rahul" }, true)]
        [DataRow(new string[] { "RAHL@1", "SSS#" }, false)]
        public void check_Password_Contains_Eight_Character(string[] arr, bool expected)
        {
            Registration register = new Registration();
            foreach (string passwd in arr)
            {
                bool actual = register.Password_Contains_Eight_Character(passwd);
                Assert.AreEqual(actual, expected);
            }
        }

        [TestMethod]
        [DataRow(new string[] { "RAHULg@1234", "A123rahul@12", "reva@123" },true)]
        [DataRow(new string[] { "rahul@1" },false)]
        public void Check_Password_Conatain_Atleast_One_UpperCase(string[] arr, bool expected)
        {
            Registration register = new Registration();
            foreach (string passwd in arr)
            {
                bool actual = register.Password_Contains_Atleast_One_UpperCase(passwd);
                Assert.AreEqual(actual, expected);
            }
        }
        [TestMethod]
        [DataRow(new string[] { "Rahul1#0", "Rahul12@1", "Rupali@11" },true)]
        [DataRow(new string[] {"H1234@","RUTa%%%&"},false)]
        public void Check_Password_Contains_One_Numeric_Number(string[] arr, bool expected)
        {
            Registration register = new Registration();
            foreach(string passwd in arr)
            {
                bool actual = register.Password_Contains_One_Numeric_Number(passwd);
                Assert.AreEqual(actual, expected);
            }
        }
    }
}
