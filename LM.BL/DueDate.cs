using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM.BL
{
    public class DueDate
    {
        public DueDate()
        {

        }

        public DueDate(int id)
        {
            BorrowDate = DateTime.Now;
            DueDateId = id;
        }

        public int DueDateId { get; private set; }
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int BorrowerId { get; set; }
        public int BookId { get; set; }

        public void ReturnBook()
        {
            if (ReturnDate == null)
                ReturnDate = DateTime.Now;
            else
                throw new InvalidOperationException($"Book was returned {ReturnDate.Value.ToShortDateString()}");
        }

        public bool Validate()
        {
            bool isValid = true;

            if (ReturnDate != null && ReturnDate.Value < BorrowDate) isValid = false;

            return isValid;
        }
    }
}
