using System;
using System.Collections.Generic;

namespace LM.BL
{
    public class Borrower
    {
        public Borrower()
        {

        }

        public Borrower(int id)
        {
            BorrowerId = id;
        }

        public int BorrowerId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                string fullName = FirstName;
                if(!string.IsNullOrWhiteSpace(LastName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += " ";
                    }
                    fullName += LastName;
                }
                return fullName;
            }
        }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? BirthdayDate { get; set; }

        public List<Book> BorrowedBooksList { get; set; }
        public List<Book> LoanHistory { get; set; }
        public Address BorowerAddress { get; set; }

        public void Save()
        {
            //Add some code
        }

        public Borrower Retrive(int borrowerID)
        {
            //Add some code
            return new Borrower();
        }

        public List<Borrower> Retrive()
        {
            //Add some code
            return new List<Borrower>();
        }


        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(FirstName)) isValid = false;
            if (string.IsNullOrEmpty(LastName)) isValid = false;
            if (BorowerAddress == null) isValid = false;
            if (PhoneNumber == null && EmailAddress == null) isValid = false; //Need define one 
            if (BirthdayDate == null) isValid = false;
            if (BorrowedBooksList == null) isValid = false;
            if (LoanHistory == null) isValid = false;

            return isValid;
        }
    }
}
