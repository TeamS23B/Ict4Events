﻿using System;
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

        public void AddMaterial(String name, String type, double price, double rent, String state)
        {
            materials.Add(new Material((int)dbc.GetHighestId("Materiaal") + 1, name, type, price, rent, state));
            dbc.AddMaterial(name, type, (Decimal)price, (Decimal)rent, state);
        }
        public void EditMaterial(Material material)
        {
            //should
        }
        public void AddEvent(int eventId, Location location, String name, DateTime startDate, DateTime endDate)
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
            //return;
            return null;
        }

        public List<Material> GetAllMaterials()
        {
            return dbc.GetAllMaterials();
        }
        
        public void AddMaterialToEvent (Material Material )
        {

        }

        public void RemoveMaterialFromEvent (Material Material )
        {

        }

        public void EditFlaggingControl()
        {
            //
        }
    }
}
