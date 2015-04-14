using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationLayer.Exceptions;
using DatabaseConnection.Types;

namespace ApplicationLayer
{
    public class Reservations
    {
        private DatabaseConnection.DataBaseConnection dbc = new DatabaseConnection.DataBaseConnection();

        public Reservations()
        {
            
        }
        public void AddVisitorLeader(Visitor v)
        {
            dbc.AddVisitorLeader(1, v.RFID, v.Username, "21-B5-1C-8B-41-A0-D1-4B-9B-69-DB-07-E4-B6-E8-CB-4F-1E-CC-68", v.Name, v.Prefix, v.Surname, v.Email, v.IBAN, v.Adress.Street, v.Adress.Number, v.Adress.Suffix, v.Adress.City, v.Adress.Postalcode);
        }

        public void AddVisitor(Visitor v, string leaderId)
        {
            dbc.AddVisitor(1, v.RFID, v.Username, "21-B5-1C-8B-41-A0-D1-4B-9B-69-DB-07-E4-B6-E8-CB-4F-1E-CC-68", v.Name, v.Prefix, v.Surname, v.Email, leaderId);
        }

        public bool AddReservation(List<Visitor> members, Visitor leader, List<MapLocation> locations)
        {
            if (members == null || leader == null || locations == null)
            {
                throw new NullException("members, leader or locations is null");
            }
            return AddReservation(new Reservation(members,leader,locations));
        }

        public bool AddReservation(Reservation reservation)
        {
            if (reservation == null) throw new NullException("Reservation can not be null!");
            //return dbConnection.AddReservation(reservation);
            return true;
        }

        public bool AddMaterial(Reservation reservation, Material material)
        {
            if(reservation==null||material==null)
                throw new NullException("Reservation or Material is null!");
            //return dbConnection.AddMaterialToReservation(reservation,material);
            return true;
        }

        public bool RemoveMaterial(Reservation reservation, Material material)
        {
            if (reservation == null || material == null)
                throw new NullException("Reservation or Material is null!");
            //return dbConnection.RemoveMaterialFromReservation(reservation,material);
            return true;
        }
        public List<Material> GetReservedEventMatrial()
        {
            return dbc.GetReservedMaterial();
        }
        
        public List<Material> GetEventMatrial()
        {
            return dbc.GetMaterialsInEvent();
        }
        public List<MapLocation> GetNOTReserverdMapLocations()
        {
            return dbc.GetNOTReserverdMapLocations();
        }
        public List<MapLocation> GetMapLocations()
        {
            return dbc.GetMapLocations();
        }

        public void RentWithMaterialId(int MateriaalId)
        {
            if(MateriaalId != null)
            {
                dbc.AddMaterialToReserved(MateriaalId);
            }
        }

        public void RentWithXandYPosition(int x, int y, string LeiderId)

        {
            if(x !=null && y!=null && !String.IsNullOrEmpty(LeiderId))
            {
                dbc.AddLocationToReservation(x, y, LeiderId);
            }
        }

    }
}
