using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
    public class Book
    {
        public string Title { get; set; }
        public string Autor { get; set; }
        public int? ReleaseYear { get; set; }
        public string LibraryNumber { get; set; }
        public BookCard Bookcard { get; set; }


        public bool Validate()
        {
            bool isCorrect = true;

            if (string.IsNullOrEmpty(Title))
                isCorrect = false;
            if (string.IsNullOrEmpty(Autor))
                isCorrect = false;
            if (string.IsNullOrWhiteSpace(LibraryNumber))
                isCorrect = false;
            if (Bookcard == null || !Bookcard.Validate())
                isCorrect = false;

            return isCorrect;
        }
    }
}
