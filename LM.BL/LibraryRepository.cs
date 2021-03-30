using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM.BL
{
    class LibraryRepository
    {
        public bool Save(Library library)
        {

            //Add some code

            return true;
        }

        public Library Retrive(int libraryID)
        {
            //Add some code to retrive special library
            Library library = new(libraryID);

            library.LibraryName = "Pod misiem";
            library.LibraryAddress = new();
            library.LibraryResources = new();
            
            return library;
        }

        public List<Library> Retrive()
        {
            //Add some code

            Library library = new();
            Library library2 = new();

            library.LibraryName = "Pod misiem";
            library.LibraryAddress = new();
            library.LibraryResources = new();

            library2.LibraryName = "Naszeeee Książki";
            library2.LibraryAddress = new();
            library2.LibraryResources = new();

            return new List<Library>() { library, library2 };
        }

    }
}
