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
        private DatabaseConnection.DataBaseConnection dbConnection;

        public Reservations(DatabaseConnection.DataBaseConnection dbConnection)
        {
            this.dbConnection = dbConnection;
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

        public List<MapLocation> GetMapLocations()
        {
            return dbConnection.GetMapLocations();
        }

    }
}
