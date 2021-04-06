using Microsoft.VisualStudio.TestTools.UnitTesting;
using LM.BL;

namespace LM.BLTest
{
    [TestClass]
    public class BorrowerRepositoryTest
    {
        //[TestMethod]
        public void RetriveValid()
        {
            var borrowerRepository = new BorrowerRepository();
            var expected = new Borrower(1)
            {
                FirstName = "Jan",
                LastName = "Kowalski",
                EmailAddress = "JaneKowalski@poczta.pl"
            };

            var actual = borrowerRepository.Retrive(1);

            Assert.AreEqual(expected.BorrowerId, actual.BorrowerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
        }
    }
}
