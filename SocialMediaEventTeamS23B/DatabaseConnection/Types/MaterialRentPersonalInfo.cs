using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConnection.Exceptions;

namespace DatabaseConnection.Types
{
    public class MaterialRentPersonalInfo
    {
        public string RFID { get; set; }
        public string TotalName { get; set; }
        public MaterialRentPersonalInfo(string RFID, string TotalName)
        {
            this.RFID = RFID;
            this.TotalName = TotalName;
            if(string.IsNullOrEmpty(TotalName))
            {
                throw new InvalidDataException("Naam is leeg");
            }
            if(string.IsNullOrEmpty(RFID))
            {
                throw new InvalidDataException("RFID is leeg");
            }
        }
    }
}
