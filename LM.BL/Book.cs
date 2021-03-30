using System.Collections.Generic;

namespace LM.BL
{
    public class Book
    {
        public Book()
        {

        }

        public Book(int id)
        {
            BookID = id;
        }


        public int BookID { get; private set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public BookCategory _category;
        public int PublicationYear { get; set; }
        public BookStatus _status { get; set; }
        public List<DueDate> DueDates { get; set; }


        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(Name)) isValid = false;
            if (string.IsNullOrEmpty(Author)) isValid = false;
            if (DueDates == null) isValid = false;

            return isValid;
        }

    }

    public enum BookCategory { none = 0, Biographies, Cooking, Fantasy, Thriller, ScienceFiction };
    public enum BookStatus { ToTake, Reserved, Borrowed};
}