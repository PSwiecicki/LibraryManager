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

        [TestMethod]
        public void EmailAddressWithoutAt()
        {
            Borrower borrower = new() { EmailAddress = "jankowalskigmail.com" };
            string expected = null;

            string actual = borrower.EmailAddress;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EmailAddressWithoutLocalPart()
        {
            Borrower borrower = new() { EmailAddress = "@gmail.com" };
            string expected = null;

            string actual = borrower.EmailAddress;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EmailAddressWithoutDot()
        {
            Borrower borrower = new() { EmailAddress = "jankowalski@gmailcom" };
            string expected = null;

            string actual = borrower.EmailAddress;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EmailAddressWithoutFirstDomainPart()
        {
            Borrower borrower = new() { EmailAddress = "jankowlaki@.com" };
            Borrower borrower2 = new() { EmailAddress = "jankowlaki@.gmail.com" };
            string expected = null;

            string actual = borrower.EmailAddress;
            string actual2 = borrower2.EmailAddress;

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected, actual2);
        }

        [TestMethod]
        public void EmailAddressWithoutLastDomainPart()
        {
            Borrower borrower = new() { EmailAddress = "jankowlaki@gmail" };
            Borrower borrower2 = new() { EmailAddress = "jankowlaki@gmail.com." };
            string expected = null;

            string actual = borrower.EmailAddress;
            string actual2 = borrower2.EmailAddress;

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected, actual2);
        }

        [TestMethod]
        public void EmailAddressValid()
        {
            Borrower borrower = new() { EmailAddress = "jankowalski@gmail.com" };
            Borrower borrower2 = new() { EmailAddress = "jankowalski@uczelnia.edu.pl" };
            string expected = "jankowalski@gmail.com";
            string expected2 = "jankowalski@uczelnia.edu.pl";

            string actual = borrower.EmailAddress;
            string actual2 = borrower2.EmailAddress;

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        public void PhoneNumberValid()
        {
            Borrower borrower = new() { PhoneNumber = "123123123" };
            string expected = "123 123 123";

            string actual = borrower.PhoneNumber;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PhoneNumberLessNumbers()
        {
            Borrower borrower = new() { PhoneNumber = "123123" };
            string expected = null;

            string actual = borrower.PhoneNumber;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PhoneNumberMoreNumbers()
        {
            Borrower borrower = new() { PhoneNumber = "1123123123" };
            string expected = null;

            string actual = borrower.PhoneNumber;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PhoneNumberWithChars()
        {
            Borrower borrower = new() { PhoneNumber = "1a31fd123" };
            string expected = null;

            string actual = borrower.PhoneNumber;

            Assert.AreEqual(expected, actual);
        }
    }
}