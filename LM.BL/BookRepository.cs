using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM.BL
{
    class BookRepository
    {
        public bool Save(Book book)
        {
            //Add some code to save book
            return true;
        }

        public Book Retrive(int bookID)
        {
            //Add some code to retrive book 
            Book book = new(bookID);

            book.Author = "Gerwalt Wieśmin";
            book.Name = "Przygody Sampkowskiego";
            book.DueDates = new();

            return book;
        }

        public List<Book> Retrive()
        {
            //Add some code to retrive all books
            Book book = new();
            Book book2 = new();

            book.Author = "Gerwalt Wieśmin";
            book.Name = "Przygody Sampkowskiego";
            book.DueDates = new();

            book2.Author = "Hodor";
            book2.Name = "Hodor Hodor - Hodor";
            book2.DueDates = new();

            return new List<Book>() { book, book2 };
        }
    }
}
