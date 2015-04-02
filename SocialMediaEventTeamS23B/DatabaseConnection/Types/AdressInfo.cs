using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConnection.Exeptions;

namespace DatabaseConnection.Types
{
    class AdressInfo
    {
        public String Street { get; private set; }
        public String City { get; private set; }
        public int Number { get; private set; }
        public String Suffix { get; private set; }
        public String Country { get; private set; }
        public String Postalcode { get; private set; }

        public AdressInfo(string street, string city, int number, string suffix, string country, string postalcode)
        {
            if (string.IsNullOrEmpty(street) || string.IsNullOrEmpty(city)|| string.IsNullOrEmpty(country) || string.IsNullOrEmpty())
            {
                throw new InvalidDataException("Street, city, country or postalcode is empty");
            }
            if (number <= 0)
            {
                throw new InvalidDataException("number is equal to or smaller then 0");
            }
            Street = street;
            City = city;
            Number = number;
            Suffix = suffix;
            Country = country;
            Postalcode = postalcode;
        }

        public AdressInfo(string street, string city, int number, string country, string postalcode)
            : this(street, city, number,"", country, postalcode)
        {

        }

        public override string ToString()
        {
            return String.Format("{{Street={0},City={1},Number={2},Suffix={3},Country={4},Postalcode={5}", Street, City,
                Number, Suffix, Country, Postalcode);
        }
    }
}
