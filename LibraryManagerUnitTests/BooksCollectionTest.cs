using System;
using LibraryManager;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryManagerUnitTests
{
    [TestClass]
    public class BooksCollectionTest
    {
        [TestMethod]
        public void GoodValidateTest()
        {
            //Arange
            BooksCollection booksCollection = new BooksCollection()
            {
                Books = new List<Book>()
            };
            bool expectedValue = true;

            //Act
            bool actualValue = booksCollection.Validate();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void BadValidateTest()
        {
            //Arange
            BooksCollection booksCollection = new BooksCollection();
            bool expectedValue = false;

            //Act
            bool actualValue = booksCollection.Validate();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
