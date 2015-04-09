using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConnection.Types;

namespace ApplicationLayer
{
    class Admin
    {
        public List<Material> materials { get; private set; }

        public List<Event> events { get; private set; }
        public Admin()
        {

        }

        public void AddMaterial(string name, string type, double price, String state)
        {
            DatabaseConnection.DataBaseConnection dbc = new DatabaseConnection.DataBaseConnection();
            dbc.AddMaterial(name, type, price, state);
            //TODO: later nog controles toevoegen
        }
        public void EditMaterial(Material material)
        {
            //db.editmaterial
        }
        public void AddEvent(int eventId, Location location, DateTime startDate, DateTime endDate)
        {
            //db.addevent
        }
        
        public void GetLocation()
        {

        }
        public void GetMaterial()
        {

        }
        
        public void EditFlaggingControl()
        {

        }
    }
}
