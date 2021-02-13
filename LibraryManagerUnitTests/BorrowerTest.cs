using System;
using LibraryManager;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryManagerUnitTests
{
    [TestClass]
    public class BorrowerTest
    {
        [TestMethod]
        public void GoodPeselTest()
        {
            //Arange
            Borrower borrower = new Borrower
            {
                BirthDay = new DateTime(2001, 04, 02),
                Pesel = 01240259197
            };
            long expectedValue = 01240259197;

            //Act
            long actualValue = borrower.Pesel;

            //Assert
            Assert.AreEqual(expectedValue, actualValue);

        }

        [TestMethod]
        public void BadPeselTest()
        {
            //Arange
            //Bad CRC
            Borrower borrower = new Borrower
            {
                BirthDay = new DateTime(2001, 04, 02),
                Pesel = 01240259195
            };
            //Bad Birthdate number
            Borrower borrower1 = new Borrower
            {
                BirthDay = new DateTime(2001, 04, 02),
                Pesel = 01242259197
            };
            //Bad other number
            Borrower borrower2 = new Borrower
            {
                BirthDay = new DateTime(2001, 04, 02),
                Pesel = 01240259397
            };
            long expectedValue = 0;

            //Act
            long actualValue = borrower.Pesel;
            long actualValue1 = borrower1.Pesel;
            long actualValue2 = borrower2.Pesel;

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
            Assert.AreEqual(expectedValue, actualValue1);
            Assert.AreEqual(expectedValue, actualValue2);
        }

        [TestMethod]
        public void GoodValidateTest()
        {
            //Arange
            Borrower borrower = new Borrower()
            {
                Name = "Jan",
                LastName = "Kowalski",
                BorrowerAddress = new Address()
                {
                    Street = "Krakowska",
                    PostCode = "84-300",
                    City = "Robczyce",
                    Building = 5,
                    AddressID = 0
                },
                BirthDay = new DateTime(2001, 04, 02),
                Pesel = 01240259197,
                BorrowedBooks = new BooksCollection()
            };
            bool expectedValue = true;

            //Act
            bool actualValue = borrower.Validate();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }


        [TestMethod]
        public void BadValidateTest()
        {
            //Arange
            //Without name
            Borrower borrower = new Borrower()
            {
                LastName = "Kowalski",
                BorrowerAddress = new Address()
                {
                    Street = "Krakowska",
                    PostCode = "84-300",
                    City = "Robczyce",
                    Building = 5,
                    AddressID = 0
                },
                BirthDay = new DateTime(2001, 04, 02),
                Pesel = 01240259197,
                BorrowedBooks = new BooksCollection()
            };
            //Without lastname
            Borrower borrower1 = new Borrower()
            {
                Name = "Jan",
                BorrowerAddress = new Address()
                {
                    Street = "Krakowska",
                    PostCode = "84-300",
                    City = "Robczyce",
                    Building = 5,
                    AddressID = 0
                },
                BirthDay = new DateTime(2001, 04, 02),
                Pesel = 01240259197,
                BorrowedBooks = new BooksCollection()
            };
            //Without address
            Borrower borrower2 = new Borrower()
            {
                Name = "Jan",
                LastName = "Kowalski",
                BirthDay = new DateTime(2001, 04, 02),
                Pesel = 01240259197,
                BorrowedBooks = new BooksCollection()
            };
            //Without birthday
            Borrower borrower3 = new Borrower()
            {
                Name = "Jan",
                LastName = "Kowalski",
                BorrowerAddress = new Address()
                {
                    Street = "Krakowska",
                    PostCode = "84-300",
                    City = "Robczyce",
                    Building = 5,
                    AddressID = 0
                },
                Pesel = 01240259197,
                BorrowedBooks = new BooksCollection()
            };
            //Without pesel
            Borrower borrower4 = new Borrower()
            {
                Name = "Jan",
                LastName = "Kowalski",
                BorrowerAddress = new Address()
                {
                    Street = "Krakowska",
                    PostCode = "84-300",
                    City = "Robczyce",
                    Building = 5,
                    AddressID = 0
                },
                BirthDay = new DateTime(2001, 04, 02),
                BorrowedBooks = new BooksCollection()
            };
            //Without initialized book's collection
            Borrower borrower5 = new Borrower()
            {
                Name = "Jan",
                LastName = "Kowalski",
                BorrowerAddress = new Address()
                {
                    Street = "Krakowska",
                    PostCode = "84-300",
                    City = "Robczyce",
                    Building = 5,
                    AddressID = 0
                },
                BirthDay = new DateTime(2001, 04, 02),
                Pesel = 01240259197
            };
            bool expectedValue = false;

            //Act
            bool actualValue = borrower.Validate();
            bool actualValue1 = borrower1.Validate();
            bool actualValue2 = borrower2.Validate();
            bool actualValue3 = borrower3.Validate();
            bool actualValue4 = borrower4.Validate();
            bool actualValue5 = borrower5.Validate();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
            Assert.AreEqual(expectedValue, actualValue1);
            Assert.AreEqual(expectedValue, actualValue2);
            Assert.AreEqual(expectedValue, actualValue3);
            Assert.AreEqual(expectedValue, actualValue4);
            Assert.AreEqual(expectedValue, actualValue5);
        }
    }
}
