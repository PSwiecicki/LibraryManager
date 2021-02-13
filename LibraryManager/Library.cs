using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
    public class Library
    {
        public int? LibraryID { get; private set; }
        public string Name { get; set; }
        public Address LibAddress { get; set; }
        public BooksCollection LibBooksCollection { get; set; }


        public bool Validate()
        {
            bool isCorrect = true;

            if (LibraryID == null)
                isCorrect = false;
            if (string.IsNullOrWhiteSpace(Name))
                isCorrect = false;
            if (LibAddress == null || !LibAddress.Validate())
                isCorrect = false;
            if (LibBooksCollection == null || !LibBooksCollection.Validate())
                isCorrect = false;

            return isCorrect;
        }

    }
}
