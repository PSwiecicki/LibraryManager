using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM.BL
{
    public class DueDate
    {
        public DueDate(Borrower borrower)
        {
            Borrower = borrower;
            BorrowDate = DateTime.Now;
        }

        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public Borrower Borrower { get; set; }

        public void ReturnBook()
        {
            if (ReturnDate == null)
                ReturnDate = DateTime.Now;
            else
                throw new InvalidOperationException($"Book was returned {ReturnDate.Value.ToShortDateString()}");
        }

    }
}
