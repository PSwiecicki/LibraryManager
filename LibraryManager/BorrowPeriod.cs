using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
    public class BorrowPeriod
    {
        public Borrower Borrower { get; set; }
        public DateTime? BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public bool Validate()
        {
            bool isCorrect = true;

            if (BorrowDate == null || Borrower == null || ReturnDate == null)
                isCorrect = false;

            return isCorrect;
        }
    }
}
