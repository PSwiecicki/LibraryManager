using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
    public class BooksCollection
    {
        public List<Book> Books { get; set; } 

        public bool Validate()
        {
            bool isCorrect = true;

            if (Books == null)
                isCorrect = false;

            return isCorrect;
        }
    }
}
