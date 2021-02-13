using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
    public class BookCard
    {
        public DateTime? DateDue { get; set; }
        public Borrower ActualBorrower { get; set; }
        public Queue<BorrowPeriod> LastBorrowers { get; set; }


        public bool Validate()
        {
            bool isCorrect = true;

            if ((DateDue != null) && (ActualBorrower == null))
                isCorrect = false;
            if (DateDue == null && ActualBorrower != null)
                isCorrect = false;
            if (LastBorrowers == null)
                isCorrect = false;

            return isCorrect;
        }

    }
}
