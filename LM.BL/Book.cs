using Common;
using System.Collections.Generic;

namespace LM.BL
{
    public class Book : EntityBase, ILoggable
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
        public int PublicationYear { get; set; }
        public List<DueDate> DueDates { get; set; }


        public override bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(Name)) isValid = false;
            if (string.IsNullOrEmpty(Author)) isValid = false;
            if (DueDates == null) isValid = false;

            return isValid;
        }

        public string Log() => $"{BookID}: {Name}, {Author} State: {EntityState.ToString()}";

    }
}