using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM.BL
{
    public class Library
    {
        public Library()
        {

        }

        public Library(int id)
        {
            LibraryID = id;
        }


        public int LibraryID { get; private set; }
        public string LibraryName { get; set; }
        public Address LibraryAddress { get; set; }
        public List<Book> LibraryResources { get; set; }

        //Methods to Add
        //AddResources()
        //RemoveResources()


        public void Save()
        {
            //Add some code
        }

        public Library Retrive(int libraryID)
        {
            //Add some code
            return new Library();
        }

        public List<Library> Retrive()
        {
            //Add some code
            return new List<Library>();
        }


        public bool Validate()
        {
            bool isValid = true;

            if (LibraryName == null) isValid = false;
            if (LibraryAddress == null) isValid = false;
            if (LibraryResources == null) isValid = false;

            return isValid;
        }
        //Retrive
        //Validate
    }
}
