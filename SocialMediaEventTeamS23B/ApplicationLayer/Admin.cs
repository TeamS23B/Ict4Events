using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConnection.Types;

namespace ApplicationLayer
{
    public class Admin
    {
        DatabaseConnection.DataBaseConnection dbc = new DatabaseConnection.DataBaseConnection();
        public List<Material> materials { get; private set; }

        public List<Event> events { get; private set; }
        public Admin()
        {
            materials = new List<Material>();
            events = new List<Event>();
        }

        public void AddMaterial(String name, String type, double price, double rent, String state)
        {
            materials.Add(new Material((int)dbc.GetHighestId("Materiaal") + 1, name, type, price, rent, state));
            dbc.AddMaterial(name, type, price, rent, state);
        }
        public void EditMaterial(Material material)
        {
            //should
        }
        public void AddEvent(Location location, String name, DateTime startDate, DateTime endDate)
        {
            events.Add(new Event((int)dbc.GetHighestId("Event") + 1, location, name, startDate, endDate));
            dbc.AddEvent((decimal)location.LocatieId, name, startDate, endDate);
        }
        
        public List<Location> GetLocations()
        {
            return dbc.GetLocations();
        }
        public List<Material> GetMaterialsInEvent()
        {
            return dbc.GetMaterialsInEvent();
        }

        public List<Material> GetAllMaterials()
        {
            return dbc.GetAllMaterials();
        }

        public void RemoveMaterial(Material material)
        {
            dbc.RmvMaterial(material.MaterialId);
        }
        
        public void AddMaterialToEvent (Material Material )
        {
            dbc.AddMaterialToEvent(Material.MaterialId);
        }

        public void RemoveMaterialFromEvent (Material Material )
        {
            dbc.RmvMaterialFromEvent(Material.MaterialId);
        }

        public void EditFlaggingControl(int flags, int ratio, int time, bool autoCleanUp)
        {
            if(autoCleanUp)
            {
                dbc.UpdFlagRules(flags, ratio, time, 'J');
            }
            else if (!autoCleanUp)
            {
                dbc.UpdFlagRules(flags, ratio, time, 'N');
            }           
        }
        public List<Visitor> GetVisitors()
        {
            return dbc.GetVisitor();
        }

        public List<Post> GetPosts()
        {
            return null;// dbc.GetPostsOf(2);
        }
        public void EditVisitor(Visitor visitor, int Change)
        {

            if (Change == 1)
            {
                dbc.UpdVisitorBlock(visitor.RFID, 'J');
            }
            else if(Change == 2)
            {
                dbc.UpdVisitorBlock(visitor.RFID, 'N');
            }
            else if (Change == 3)
            {
                dbc.UpdPostVisibility(visitor.RFID, 'N');
            }
            else if (Change == 4)
            {
                dbc.UpdPostVisibility(visitor.RFID, 'J');
            }
        }
        public List<Material> VisitorMaterial(Visitor visitor)
        {
            return dbc.MaterialsOfVisitor(visitor.RFID);
        }
    }
}
