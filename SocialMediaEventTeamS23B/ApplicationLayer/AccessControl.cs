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

                    Visitor a = dbc.GetVisitor(RFID);
                    Visitor q = null;
                    int count = 0;
                    foreach(Visitor visitor in AllPresent)
                    {
                        if(visitor.RFID == a.RFID)
                        {
                            q = visitor;
                            count++;
                        }
                    }
                    if (count > 0)
                    {
                        AllPresent.Remove(q);
                    }
                    else
                    {
                        AllPresent.Add(a);
                    }
                    
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
        public Visitor GetVisitorChecked(string RFID)
        {
            return dbc.GetVisitor(RFID);
        }
    }
}
