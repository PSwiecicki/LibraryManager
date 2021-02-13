using System;
using LibraryManager;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryManagerUnitTests
{
    [TestClass]
    public class BookCardTest
    {
        [TestMethod]
        public void GoodValidateTest()
        {
            //Arrange
            BookCard bookCard = new BookCard
            {
                LastBorrowers = new Queue<BorrowPeriod>()
            };
            BookCard bookCard1 = new BookCard
            {
                DateDue = new DateTime(),
                ActualBorrower = new Borrower(),
                LastBorrowers = new Queue<BorrowPeriod>()
            };
            bool expectedValue = true;

            //Act
            bool actualValue = bookCard.Validate();
            bool actualValue1 = bookCard1.Validate();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
            Assert.AreEqual(expectedValue, actualValue1);
        }

        [TestMethod]
        public void BadValidateTest()
        {
            //Without borrow date
            BookCard bookCard = new BookCard()
            {
                ActualBorrower = new Borrower(),
                LastBorrowers = new Queue<BorrowPeriod>()
            };
            //Without Borrower
            BookCard bookCard1 = new BookCard
            {
                DateDue = new DateTime(),
                LastBorrowers = new Queue<BorrowPeriod>()
            };
            //Without initialized Last borrowers list.
            BookCard bookCard2 = new BookCard
            {
                DateDue = new DateTime(),
                ActualBorrower = new Borrower()
            };
            bool expectedValue = false;

            //Act
            bool actualValue = bookCard.Validate();
            bool actualValue1 = bookCard1.Validate();
            bool actualValue2 = bookCard2.Validate();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
            Assert.AreEqual(expectedValue, actualValue1);
            Assert.AreEqual(expectedValue, actualValue2);
        }
    }
}