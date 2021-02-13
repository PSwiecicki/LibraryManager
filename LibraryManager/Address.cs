using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
    public class Address
    {
        private string _postCode;

        public int? AddressID { get; set; }
        public String Street { get; set; }
        public short Building { get; set; }
        public short Apartment { get; set; }
        public String PostCode {
            get{
                return _postCode;
            }
            set {
                string v = value;
                if(v.Length == 6)
                {
                    for(int i = 0; i < 6; i++)
                    {
                        if (!((char.IsNumber(v[i]) && i != 2) || (i == 2 && v[i] == '-')))
                            break;
                        else if(i == 5)
                        _postCode = v;
                    }
                }
            } 
        }
        public string City { get; set; }

        
        public bool Validate()
        {
            bool isCorrect = true;

            if (string.IsNullOrWhiteSpace(Street))
                isCorrect = false;
            if (string.IsNullOrWhiteSpace(PostCode))
                isCorrect = false;
            if (string.IsNullOrWhiteSpace(City))
                isCorrect = false;
            if (Building <= 0)
                isCorrect = false;
            if (AddressID < 0 || AddressID == null)
                isCorrect = false;

            return isCorrect;
        }

    }
}
