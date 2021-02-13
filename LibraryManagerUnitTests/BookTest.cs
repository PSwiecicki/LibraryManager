using System;
using System.Collections.Generic;
using LibraryManager;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryManagerUnitTests
{
    [TestClass]
    public class BookTest
    {
        [TestMethod]
        public void PropTest()
        {
            //Arrange
            Book book = new Book
            {
                Title = "Witcher",
                Autor = "Andrzej Sapkowski",
                ReleaseYear = 2000,
                LibraryNumber = "ASWI2000"
            };
            string expectedValue = "Witcher, Andrzej Sapkowski, 2000, ASWI2000";

            //Act
            string actualValue = $"{book.Title}, {book.Autor}, {book.ReleaseYear}, {book.LibraryNumber}";

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void GoodValidateTest()
        {
            //Arange
            Book book = new Book()
            {
                Title = "Wiedźmin: Krew elfów",
                Autor = "Andrzej Sapkowiski",
                LibraryNumber = "AV34C",
                Bookcard = new BookCard()
                {
                    LastBorrowers = new Queue<BorrowPeriod>()
                }
            };
            bool expectedValue = true;

            //Act
            bool actualValue = book.Validate();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void BadValidateTest()
        {
            //Arange
            //Without title
            Book book = new Book()
            {
                Autor = "Andrzej Sapkowiski",
                LibraryNumber = "AV34C",
                Bookcard = new BookCard()
                {
                    LastBorrowers = new Queue<BorrowPeriod>()
                }
            };
            //Without autor
            Book book1 = new Book()
            {
                Title = "Wiedźmin: Krew elfów",
                LibraryNumber = "AV34C",
                Bookcard = new BookCard()
                {
                    LastBorrowers = new Queue<BorrowPeriod>()
                }
            };
            //Without LibraryNumber
            Book book2 = new Book()
            {
                Title = "Wiedźmin: Krew elfów",
                Autor = "Andrzej Sapkowiski",
                Bookcard = new BookCard()
                {
                    LastBorrowers = new Queue<BorrowPeriod>()
                }
            };
            //Without bookcard
            Book book3 = new Book()
            {
                Title = "Wiedźmin: Krew elfów",
                Autor = "Andrzej Sapkowiski",
                LibraryNumber = "AV34C"
            };
            //With wrong bookcard
            Book book4 = new Book()
            {
                Title = "Wiedźmin: Krew elfów",
                Autor = "Andrzej Sapkowiski",
                LibraryNumber = "AV34C",
                Bookcard = new BookCard()
            };
            bool expectedValue = false;

            //Act
            bool actualValue = book.Validate();
            bool actualValue1 = book1.Validate();
            bool actualValue2 = book2.Validate();
            bool actualValue3 = book3.Validate();
            bool actualValue4 = book4.Validate();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
            Assert.AreEqual(expectedValue, actualValue1);
            Assert.AreEqual(expectedValue, actualValue2);
            Assert.AreEqual(expectedValue, actualValue3);
            Assert.AreEqual(expectedValue, actualValue4);
        }
    }
}