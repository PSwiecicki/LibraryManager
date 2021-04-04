using System;
using System.Collections.Generic;

namespace LM.BL
{
    public class Borrower : EntityBase
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
                if (addressSpliter.Length == 2 && !value[0].Equals('@'))
                {
                    string[] domainSpliter = addressSpliter[1].Split('.');
                    if (domainSpliter.Length >= 2 && !addressSpliter[1][0].Equals('.') && !addressSpliter[1][addressSpliter[1].Length-1].Equals('.'))
                        emailAddress = value;
                }
            }
        }
        public string PhoneNumber
        {
            get
            {
                if (phoneNumber != null)
                    return phoneNumber.Insert(6, " ").Insert(3, " ");
                else
                    return phoneNumber;
            }
            set
            {
                int i;
                string number = value.Trim();
                if (number.Length == 9 && int.TryParse(number, out i))
                {
                    phoneNumber = value;
                }
            }
        }
        public DateTime? BirthdayDate { get; set; }
        public List<Book> BorrowedBooksList { get; set; }
        public List<Book> LoanHistory { get; set; }
        public Address BorrowerAddress { get; set; }

        public string Log()
        {
            var logString = BorrowerId + ": " +
                            FullName + " " +
                            "Email: " + EmailAddress + " " +
                            "Status: " + EntityState.ToString();
            return logString;
        }

        public override bool Validate()
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
