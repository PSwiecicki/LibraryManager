namespace LM.BL
{
    public class Address
    {
        public Address()
        {
            
        }

        public Address(int id)
        {
            AddressID = id;
        }

        public int AddressID { get; private set; }
        public string Street { get; set; }
        public int Building { get; set; }
        public int Apartment { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public bool Validate()
        {
            bool isValid = true;

            //Add some code

            return isValid;
        }
    }
}