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

        public void AddMaterial(int materialId, string name, double price, String state)
        {
            //db.addmaterial
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
