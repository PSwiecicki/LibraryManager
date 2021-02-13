using System;
using System.Collections.Generic;
using LibraryManager;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryManagerUnitTests
{
    [TestClass]
    public class LibraryTest
    {
        [TestMethod]
        public void GoodValidateTest()
        {
            //Arrange
            Library library = new Library()
            {
                LibraryID = 0,
                Name = "Biblioteka",
                LibAddress = new Address()
                {
                    Street = "Krakowska",
                    PostCode = "84-300",
                    City = "Robczyce",
                    Building = 5,
                    AddressID = 0
                },
                LibBooksCollection = new BooksCollection()
                {
                    Books = new List<Book>()
                }
            };
            bool expectedValue = true;

            //Act
            bool actualValue = library.Validate();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void BadValidateTest()
        {
            //Arrange
            //No ID
            Library library = new Library()
            {
                Name = "Biblioteka",
                LibAddress = new Address()
                {
                    Street = "Krakowska",
                    PostCode = "84-300",
                    City = "Robczyce",
                    Building = 5,
                    AddressID = 0
                },
                LibBooksCollection = new BooksCollection()
                {
                    Books = new List<Book>()
                }
            };
            //Without name
            Library library1 = new Library()
            {
                LibraryID = 0,
                LibAddress = new Address()
                {
                    Street = "Krakowska",
                    PostCode = "84-300",
                    City = "Robczyce",
                    Building = 5,
                    AddressID = 0
                },
                LibBooksCollection = new BooksCollection()
                {
                    Books = new List<Book>()
                }
            };
            //Without address
            Library library2 = new Library()
            {
                LibraryID = 0,
                Name = "Biblioteka",
                LibBooksCollection = new BooksCollection()
                {
                    Books = new List<Book>()
                }
            };
            //With wrong address
            Library library3 = new Library()
            {
                LibraryID = 0,
                Name = "Biblioteka",
                LibAddress = new Address()
                {
                    Street = "Krakowska",
                    PostCode = "84-300",
                    City = "Robczyce",
                    Building = 5
                },
                LibBooksCollection = new BooksCollection()
                {
                    Books = new List<Book>()
                }
            };
            //Without book's collection
            Library library4 = new Library()
            {
                LibraryID = 0,
                Name = "Biblioteka",
                LibAddress = new Address()
                {
                    Street = "Krakowska",
                    PostCode = "84-300",
                    City = "Robczyce",
                    Building = 5,
                    AddressID = 0
                }
            };
            //With wrong collection
            Library library5 = new Library()
            {
                LibraryID = 0,
                Name = "Biblioteka",
                LibAddress = new Address()
                {
                    Street = "Krakowska",
                    PostCode = "84-300",
                    City = "Robczyce",
                    Building = 5,
                    AddressID = 0
                },
                LibBooksCollection = new BooksCollection()
            };
            bool expectedValue = false;

            //Act
            bool actualValue = library.Validate();
            bool actualValue1 = library1.Validate();
            bool actualValue2 = library2.Validate();
            bool actualValue3 = library3.Validate();
            bool actualValue4 = library4.Validate();
            bool actualValue5 = library5.Validate();

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
