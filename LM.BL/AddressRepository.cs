using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM.BL
{
    class AddressRepository
    {
        public bool Save(Address address)
        {
            var success = true;
            if(address.HasChanges)
            {
                if(address.IsValid)
                {
                    if(address.IsNew)
                    {
                        //Add new to DB
                    }
                    else
                    {
                        //Update
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }

        public Address Retrive(int addressID)
        {
            //Add some code to retrive special library
            Address address = new(addressID)
            {
                Street = "Kwiecista",
                Building = 7,
                Apartment = 14,
                City = "Kartkowice",
                PostalCode = "21-037",
                Country = "Poland"
            };

            return address;
        }

        public List<Address> Retrive()
        {
            //Add some code

            Address address = new()
            {
                Street = "Kwiecista",
                Building = 7,
                Apartment = 14,
                City = "Kartkowice",
                PostalCode = "21-037",
                Country = "Poland"
            };

            Address address2 = new(1)
            {
                Street = "Kaflowa",
                Building = 17,
                Apartment = 8,
                City = "Korkowo",
                PostalCode = "22-100",
                Country = "Poland"
            };

            return new List<Address>() { address, address2 };
        }

        public Address RetriveByBorrower(int borrowerId)
        {
            //Add some code

            Address address = new()
            {
                Street = "Kwiecista",
                Building = 7,
                Apartment = 14,
                City = "Kartkowice",
                PostalCode = "21-037",
                Country = "Poland"
            };
            return address;
        }


        public Address RetriveByLibrary(int libraryId)
        {
            //Add some code

            Address address = new()
            {
                Street = "Kwiecista",
                Building = 7,
                Apartment = 14,
                City = "Kartkowice",
                PostalCode = "21-037",
                Country = "Poland"
            };
            return address;
        }
    }
}
