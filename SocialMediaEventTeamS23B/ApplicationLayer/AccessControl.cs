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
            AllPresent = new List<Visitor>();
        }

        /// <summary>
        /// Checks if de visitor has paid
        /// </summary>
        /// <param name="RFID">The RFID of the visitor</param>
        /// <returns>True if the user has payed, false if the user hasn't</returns>
        public bool CheckPayment(string RFID)
        {
            
            switch (dbc.GetPayInfo(RFID))
            {
                case 'J':
                    AllPresent.Add(dbc.GetVisitor(RFID));
                    return true;
                case 'N':
                    return false;
                default:
                    throw new DatabaseConnection.Exceptions.InvalidDataException("Error: Payment Unknown");
            }
        }
        public List<Visitor> VisitorsAtTheEvent()
        {
            return AllPresent;
        }

    }
}
