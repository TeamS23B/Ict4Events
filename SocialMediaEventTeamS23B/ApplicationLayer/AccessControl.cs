using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationLayer.Exceptions;
using DatabaseConnection.Types;

namespace ApplicationLayer
{
    public class AccessControl
    {
        public List<Visitor> AllPresent { get; private set; }

        public AccessControl()
        {
            
        }

        /// <summary>
        /// Checks if de visitor has payed
        /// </summary>
        /// <param name="RFID">The RFID of the visitor</param>
        /// <returns>True if the user has payed, false if the user hasn't</returns>
        public bool CheckPayment(int RFID)
        {
            return true; //retun db.checkPayment(RFID);
        }


    }
}
