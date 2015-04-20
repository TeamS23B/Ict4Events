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
        private Visitor VisitorCheck;

        public AccessControl(DataBaseConnection dbc)
        {
            this.dbc = dbc;
            AllPresent = new List<Visitor>();
            VisitorCheck = new Visitor(null, null, null, null, null, null, false);
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
                    
                    foreach(Visitor visitor in AllPresent)
                    {
                        if(RFID == visitor.RFID)
                        {
                            VisitorCheck = visitor;
                        }
                        else
                        {
                            AllPresent.Add(dbc.GetVisitor(RFID));
                        }
                    }
                    try
                    { 
                        AllPresent.Remove(VisitorCheck); 
                    }
                    catch
                    {
                        
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
