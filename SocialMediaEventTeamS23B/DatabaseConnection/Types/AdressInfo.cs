using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConnection.Exceptions;

namespace DatabaseConnection.Types
{
    public class AdressInfo
    {
        public String Street { get; private set; }
        public String City { get; private set; }
        public int Number { get; private set; }
        public String Suffix { get; private set; }
        public String Postalcode { get; private set; }

        public AdressInfo(string street, string city, int number, string suffix, string postalcode)
        {
            if (string.IsNullOrEmpty(street) || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(postalcode))
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
            Postalcode = postalcode;
        }

        public AdressInfo(string street, string city, int number, string postalcode)
            : this(street, city, number,"", postalcode)
        {

        }

        public override string ToString()
        {
            return String.Format("{{Street={0},City={1},Number={2},Suffix={3},Country={4},Postalcode={5}", Street, City,
                Number, Suffix, Postalcode);
        }
    }
}
