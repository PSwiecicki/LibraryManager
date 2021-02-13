using System;
using LibraryManager;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryManagerUnitTests
{
    [TestClass]
    public class AddressTest
    {
        [TestMethod]
        public void GoodPostCodeTest()
        {
            //Arrange
            Address address = new Address
            {
                PostCode = "50-420"
            };
            string expectedValue = "50-420";

            //Act
            string actualValue = address.PostCode;

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void BadPostCodeTest()
        {
            //Arrange
            Address badAddress = new Address
            {
                PostCode = "5-420"
            };
            Address badAddress1 = new Address
            {
                PostCode = "5a-420"
            };
            Address badAddress2 = new Address
            {
                PostCode = "500420"
            };
            Address badAddress3 = new Address();
            badAddress2.PostCode = "50-42a";
            string expectedValue = null;

            //Act
            string actualValue = badAddress.PostCode;
            string actualValue1 = badAddress1.PostCode;
            string actualValue2 = badAddress2.PostCode;
            string actualValue3 = badAddress3.PostCode;

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
            Assert.AreEqual(expectedValue, actualValue1);
            Assert.AreEqual(expectedValue, actualValue2);
            Assert.AreEqual(expectedValue, actualValue3);
        }

        [TestMethod]
        public void GoodValidateTest()
        {
            //Arrange
            Address address = new Address()
            {
                Street = "Krakowska",
                PostCode = "84-300",
                City = "Robczyce",
                Building = 5,
                AddressID = 0
            };
            bool expectedValue = true;

            //Act
            bool actualValue = address.Validate();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void BadValidateTest()
        {
            //Arrange
            //Without street
            Address address = new Address()
            {
                PostCode = "84-300",
                City = "Robczyce",
                Building = 5,
                AddressID = 0
            };
            //Without post-code
            Address address1 = new Address()
            {
                Street = "Krakowska",
                City = "Robczyce",
                Building = 5,
                AddressID = 0
            };
            //Without city
            Address address2 = new Address()
            {
                Street = "Krakowska",
                PostCode = "84-300",
                Building = 5,
                AddressID = 0
            };
            //Without building number
            Address address3 = new Address()
            {
                Street = "Krakowska",
                PostCode = "84-300",
                City = "Robczyce",
                AddressID = 0
            };
            //WithoutID
            Address address4 = new Address()
            {
                Street = "Krakowska",
                PostCode = "84-300",
                City = "Robczyce",
                Building = 5
            };


            bool expectedValue = false;

            //Act
            bool actualValue = address.Validate();
            bool actualValue1 = address1.Validate();
            bool actualValue2 = address2.Validate();
            bool actualValue3 = address3.Validate();
            bool actualValue4 = address4.Validate();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
            Assert.AreEqual(expectedValue, actualValue1);
            Assert.AreEqual(expectedValue, actualValue2);
            Assert.AreEqual(expectedValue, actualValue3);
            Assert.AreEqual(expectedValue, actualValue4);
        }
    }
}
