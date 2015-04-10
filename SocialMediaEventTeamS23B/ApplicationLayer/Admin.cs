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
        DatabaseConnection.DataBaseConnection dbc = new DatabaseConnection.DataBaseConnection();
        public List<Material> materials { get; private set; }

        public List<Event> events { get; private set; }
        public Admin()
        {
            materials = new List<Material>();
            events = new List<Event>();
        }

        public void AddMaterial(String name, String type, double price, String state)
        {
            dbc.AddMaterial(name, type, (Decimal)price, state);
            materials.Add(new Material(dbc.GetHighestId("Materiaal"), name, type, price, state));
        }
        public void EditMaterial(Material material)
        {
            //should
        }
        public void AddEvent(int eventId, Location location, DateTime startDate, DateTime endDate)
        {
            dbc.AddEvent(location.Number, startDate, endDate);
        }
        
        public Location GetLocation()
        {
            //return;
        }
        public Material GetMaterial()
        {
            //return;
        }
        
        public void AddMaterialToEvent (Material){}

        public void RemoveMaterialFromEvent (Material){}

        public void EditFlaggingControl()
        {
            //
        }
    }
}
