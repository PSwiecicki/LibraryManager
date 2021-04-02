using System;
using System.Collections.Generic;

namespace LM.BL
{
    public class Borrower
    {
        public Borrower() : this(0)
        {

        }

        public Borrower(int id)
        {
            BorrowerId = id;
            BorrowerAddress = new();
            BorrowedBooksList = new();
            LoanHistory = new();
        }

        private string emailAddress;
        private string phoneNumber;

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
        public string EmailAddress 
        { 
            get
            {
                return emailAddress;
            }
            set
            {
                string[] addressSpliter = value.Split('@');
                if(addressSpliter.Length == 2)
                {
                    string[] domainSpliter = addressSpliter[1].Split('.');
                    if (domainSpliter.Length > 2)
                        emailAddress = value;
                }
            }
        }
        public string PhoneNumber
        {
            get
            {

                return phoneNumber.Insert(6, " ").Insert(3, " ");
            }
            set
            {
                int i;
                if (value.Length == 9 && int.TryParse(value, out i))
                {
                    phoneNumber = value;
                }
            }
        }
        public DateTime? BirthdayDate { get; set; }
        public List<Book> BorrowedBooksList { get; set; }
        public List<Book> LoanHistory { get; set; }
        public Address BorrowerAddress { get; set; }

        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(FirstName)) isValid = false;
            if (string.IsNullOrEmpty(LastName)) isValid = false;
            if (BorrowerAddress == null) isValid = false;
            if (PhoneNumber == null && EmailAddress == null) isValid = false; //Need define one 
            if (BirthdayDate == null) isValid = false;
            if (BorrowedBooksList == null) isValid = false;
            if (LoanHistory == null) isValid = false;

            return isValid;
        }
    }
}
