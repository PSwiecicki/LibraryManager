﻿using System.Collections.Generic;

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
        private  List<DueDate> _dueDates;



        public void Save()
        {
            //Add some code
        }

        public Book Retrive(int bookID)
        {
            //Add some code
            return new Book();
        }

        public List<Book> Retrive()
        {
            //Add some code
            return new List<Book>();
        }


        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(Name)) isValid = false;
            if (string.IsNullOrEmpty(Author)) isValid = false;
            if (_dueDates == null) isValid = false;

            return isValid;
        }

    }

    public enum BookCategory { none = 0, Biographies, Cooking, Fantasy, Thriller, ScienceFiction };
    public enum BookStatus { ToTake, Reserved, Borrowed};
}