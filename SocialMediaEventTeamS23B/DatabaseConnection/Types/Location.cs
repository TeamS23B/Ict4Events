using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection.Types
{
    public class Location
    {
        public String Street { get; private set; }
        public int Number { get; private set; }
        public String Adition { get; private set; }
        public String Town { get; private set; }
        public String Zipcode { get; private set; }
        public String Map { get; private set; }

        public Location(string street, int number, string adition, string town, string zipcode, string map)
        {
            Street = street;
            Number = number;
            Adition = adition;
            Town = town;
            Zipcode = zipcode;
            Map = map;
        }

        public override string ToString()
        {
            return string.Format("{{Street={0},Number={1},Adition={2},Town={3},Zipcode={4},Map={5}}}",Street,Number,Adition,Town,Zipcode,Map);
        }
    }
}
