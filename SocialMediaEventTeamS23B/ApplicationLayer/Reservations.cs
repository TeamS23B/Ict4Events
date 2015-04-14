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

        /// <summary>
        /// Constructor
        /// </summary>
        public Reservations()
        {
            
        }

        /// <summary>
        /// make a visitor leader in the database
        /// </summary>
        /// <param name="v"></param>
        public void AddVisitorLeader(Visitor v)
        {
            dbc.AddVisitorLeader(1, v.RFID, v.Username, "21-B5-1C-8B-41-A0-D1-4B-9B-69-DB-07-E4-B6-E8-CB-4F-1E-CC-68", v.Name, v.Prefix, v.Surname, v.Email, v.IBAN, v.Adress.Street, v.Adress.Number, v.Adress.Suffix, v.Adress.City, v.Adress.Postalcode);
        }


        /// <summary>
        /// make a visitor in the database
        /// </summary>
        /// <param name="v"></param>
        /// <param name="leaderId"></param>
        public void AddVisitor(Visitor v, string leaderId)
        {
            dbc.AddVisitor(1, v.RFID, v.Username, "21-B5-1C-8B-41-A0-D1-4B-9B-69-DB-07-E4-B6-E8-CB-4F-1E-CC-68", v.Name, v.Prefix, v.Surname, v.Email, leaderId);
        }


        /// <summary>
        /// add a reservation to the person
        /// </summary>
        /// <param name="members"></param>
        /// <param name="leader"></param>
        /// <param name="locations"></param>
        /// <returns></returns>
        public bool AddReservation(List<Visitor> members, Visitor leader, List<MapLocation> locations)
        {
            if (members == null || leader == null || locations == null)
            {
                throw new NullException("members, leader or locations is null");
            }
            return AddReservation(new Reservation(members,leader,locations));
        }

        /// <summary>
        /// add a reservation
        /// </summary>
        /// <param name="reservation"></param>
        /// <returns></returns>
        public bool AddReservation(Reservation reservation)
        {
            if (reservation == null) throw new NullException("Reservation can not be null!");
            //return dbConnection.AddReservation(reservation);
            return true;
        }

        /// <summary>
        /// add materials in a reservation
        /// </summary>
        /// <param name="reservation"></param>
        /// <param name="material"></param>
        /// <returns></returns>
        public bool AddMaterial(Reservation reservation, Material material)
        {
            if(reservation==null||material==null)
                throw new NullException("Reservation or Material is null!");
            //return dbConnection.AddMaterialToReservation(reservation,material);
            return true;
        }

        /// <summary>
        /// remove material from a reservation
        /// </summary>
        /// <param name="reservation"></param>
        /// <param name="material"></param>
        /// <returns></returns>
        public bool RemoveMaterial(Reservation reservation, Material material)
        {
            if (reservation == null || material == null)
                throw new NullException("Reservation or Material is null!");
            //return dbConnection.RemoveMaterialFromReservation(reservation,material);
            return true;
        }

        /// <summary>
        /// get reserved materials
        /// </summary>
        /// <returns></returns>
        public List<Material> GetReservedEventMatrial()
        {
            return dbc.GetReservedMaterial();
        }
        
        /// <summary>
        /// get materials in event
        /// </summary>
        /// <returns></returns>
        public List<Material> GetEventMatrial()
        {
            return dbc.GetMaterialsInEvent();
        }

        /// <summary>
        /// get the not reserved map locations
        /// </summary>
        /// <returns></returns>
        public List<MapLocation> GetNOTReserverdMapLocations()
        {
            return dbc.GetNOTReserverdMapLocations();
        }

        /// <summary>
        /// get all map locations
        /// </summary>
        /// <returns></returns>
        public List<MapLocation> GetMapLocations()
        {
            return dbc.GetMapLocations();
        }

        /// <summary>
        /// add material to reservation
        /// </summary>
        /// <param name="MateriaalId"></param>
        public void RentWithMaterialId(int MateriaalId)
        {
            if(MateriaalId != null)
            {
                dbc.AddMaterialToReserved(MateriaalId);
            }
        }

        /// <summary>
        /// add a location to a reservation
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="LeiderId"></param>
        public void RentWithXandYPosition(int x, int y, string LeiderId)

        {
            if(x !=null && y!=null && !String.IsNullOrEmpty(LeiderId))
            {
                dbc.AddLocationToReservation(x, y, LeiderId);
            }
        }

    }
}
