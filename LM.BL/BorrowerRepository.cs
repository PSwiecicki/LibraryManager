using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM.BL
{
    public class BorrowerRepository
    {
        public bool Save(Borrower borrower)
        {
            //Add some code to save boorower
            return true;
        }

        public Borrower Retrive(int borrowerID)
        {
            //Add some code to retrive borrower with borrowerID
            return new Borrower(borrowerID)
            {
                FirstName = "Jan",
                LastName = "Kowalski",
                BorrowerAddress = new Address(),
                EmailAddress = "JaneKowalski@poczta.pl",
                BirthdayDate = new DateTime(1990, 10, 12),
                BorrowedBooksList = new(),
                LoanHistory = new()
            };
        }

        public List<Borrower> Retrive()
        {
            //Add some code to retrive all borrowers
            return new List<Borrower>()
            {
                new Borrower()
                {
                    FirstName = "Jan",
                    LastName = "Kowalski",
                    BorrowerAddress = new Address(),
                    EmailAddress = "JaneKowalski@poczta.pl",
                    BirthdayDate = new DateTime(1990, 10, 12),
                    BorrowedBooksList = new(),
                    LoanHistory = new()
                },
                new Borrower()
                {
                    FirstName = "Henryk",
                    LastName = "Pocierak",
                    BorrowerAddress = new Address(),
                    PhoneNumber = "528609217",
                    BirthdayDate = new DateTime(1983, 5, 6),
                    BorrowedBooksList = new(),
                    LoanHistory = new()
                }
            };
        }
    }
}
