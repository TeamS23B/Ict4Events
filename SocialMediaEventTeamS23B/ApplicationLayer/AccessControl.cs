using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationLayer.Exceptions;
using DatabaseConnection;
using DatabaseConnection.Types;

namespace ApplicationLayer
{
    public class AccessControl
    {
        public List<Visitor> AllPresent { get; private set; }
        private DataBaseConnection dbc;

        public AccessControl(DataBaseConnection dbc)
        {
            this.dbc = dbc;
        }

        /// <summary>
        /// Checks if de visitor has payed
        /// </summary>
        /// <param name="RFID">The RFID of the visitor</param>
        /// <returns>True if the user has payed, false if the user hasn't</returns>
        public bool CheckPayment(string RFID)
        {
            switch (dbc.GetPayInfo(RFID))
            {
                case 'J':
                    return true;
                case 'N':
                    return false;
                default:
                    throw new DatabaseConnection.Exceptions.InvalidDataException("Error: Payment Unknown");
            }
        }
    }
}
