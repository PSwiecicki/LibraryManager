using Microsoft.VisualStudio.TestTools.UnitTesting;
using LM.BL;

namespace LM.BLTest
{
    [TestClass]
    public class BorrowerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            Borrower borrower = new() { FirstName = "Jan", LastName = "Kowalski" };
            string expected = "Jan Kowalski";

            string actual = borrower.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            Borrower borrower = new() { LastName = "Kowalski" };
            string expected = "Kowalski";

            string actual = borrower.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            Borrower borrower = new() { FirstName = "Jan" };
            string expected = "Jan";

            string actual = borrower.FullName;

            Assert.AreEqual(expected, actual);
        }
    }
}
