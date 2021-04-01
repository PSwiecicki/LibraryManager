using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM.BL
{
    public class Library
    {
        public Library() : this(0)
        {

        }

        public Library(int id)
        {
            LibraryID = id;
            LibraryAddress = new();
            LibraryResources = new();
        }

        public int LibraryID { get; private set; }
        public string LibraryName { get; set; }
        public Address LibraryAddress { get; set; }
        public List<Book> LibraryResources { get; set; }

        public bool Validate()
        {
            bool isValid = true;

            if (LibraryName == null) isValid = false;
            if (LibraryAddress == null) isValid = false;
            if (LibraryResources == null) isValid = false;

            return isValid;
        }
    }
}
