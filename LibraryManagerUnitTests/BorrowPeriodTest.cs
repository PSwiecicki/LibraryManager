using System;
using LibraryManager;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryManagerUnitTests
{
    [TestClass]
    public class BorrowPeriodTest
    {
        [TestMethod]
        public void GoodValidateTest()
        {
            //Arrange
            BorrowPeriod borrowPeriod = new BorrowPeriod()
            {
                Borrower = new Borrower(),
                BorrowDate = new DateTime(),
                ReturnDate = new DateTime()
            };
            bool expectedValue = true;

            //Act
            bool actualValue = borrowPeriod.Validate();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void BadValidateTest()
        {
            //Arrange
            //Without borrower
            BorrowPeriod borrowPeriod = new BorrowPeriod()
            {
                BorrowDate = new DateTime(),
                ReturnDate = new DateTime()
            };
            //Without borrow date
            BorrowPeriod borrowPeriod1 = new BorrowPeriod()
            {
                Borrower = new Borrower(),
                ReturnDate = new DateTime()
            };
            //Without return date
            BorrowPeriod borrowPeriod2 = new BorrowPeriod()
            {
                Borrower = new Borrower(),
                BorrowDate = new DateTime()
            };
            bool expectedValue = false;

            //Act
            bool actualValue = borrowPeriod.Validate();
            bool actualValue1 = borrowPeriod1.Validate();
            bool actualValue2 = borrowPeriod2.Validate();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
            Assert.AreEqual(expectedValue, actualValue1);
            Assert.AreEqual(expectedValue, actualValue2);
        }
    }
}
