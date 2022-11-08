using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections1
{
    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int PostalCode { get; set; }

        public Address(string city, string street, int houseNumber, int postalCode)
        {
            City = city;
            Street = street;
            HouseNumber = houseNumber;
            PostalCode = postalCode;
        }
        public override string ToString()
        {
            return City + ", " + Street+ ", "+ HouseNumber+ ", " + PostalCode;
        }
    }
}
