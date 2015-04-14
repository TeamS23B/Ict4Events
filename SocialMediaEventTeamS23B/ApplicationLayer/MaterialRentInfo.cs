using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationLayer.Exceptions;
using DatabaseConnection;
using DatabaseConnection.Exceptions;
using DatabaseConnection.Types;

namespace ApplicationLayer
{    
    public class MaterialRentInfo
    {
        public string Details { get; set; }
        public int MyProperty { get; set; }
        private DataBaseConnection dbConnection;

        /// <summary>
        /// Constructor to make a connection for material rent
        /// </summary>
        /// <param name="dbConnection"></param>
        public MaterialRentInfo(DataBaseConnection dbConnection)
        {
            this.dbConnection = dbConnection;
            if (dbConnection == null)
            {
                throw new NullException("dbConnection is empty!");
            }
        }

        /// <summary>
        /// Returns all the materials from the database which are in event
        /// </summary>
        /// <returns></returns>
        public List<Material> GetMaterialsInEvent()
        {
            return dbConnection.GetMaterialsInEvent();
        }

        /// <summary>
        /// Get the info of a person what has the given RFID.
        /// </summary>
        /// <param name="RFID"></param>
        /// <returns></returns>
        public MaterialRentPersonalInfo GetPersonalInfo(string RFID)
        {
           return dbConnection.PersonMaterialRentInfo(RFID);
        }
        /// <summary>
        /// Rents the Product with the materiaalId, while it checks the RFID of the person
        /// </summary>
        /// <param name="rfid"></param>
        /// <param name="startdate"></param>
        /// <param name="enddate"></param>
        /// <param name="materiaalId"></param>
        public void MakeRent(string rfid, DateTime startdate, DateTime enddate, int materiaalId)
        {
            dbConnection.AddRent(startdate, enddate, rfid);
            int highestId = (int)dbConnection.GetHighestId("Huur");
            dbConnection.AddRentMaterial(highestId, materiaalId);
        }
    }

}
