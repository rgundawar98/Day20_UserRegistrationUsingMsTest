using Day20UserRegistration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UserRegistrationTest
{
    [TestClass]
    public class UserRegistration
    {
        [TestMethod]
        [DataRow(new string[] {"Rahul","Siva","Ronny","Divya","Shivani"},true)]
        [DataRow(new string[] {"rahul","ganesh"},false)]
        public void Check_For_First_Name(string[] arr , bool expected)
        {
            //Arrange
            Registration register = new Registration();
            foreach(string data in arr)
            {
                bool actual = register.Check_First_Name(data);
                //Assert
                Assert.AreEqual(actual ,expected);
            }
        }
    }
}
