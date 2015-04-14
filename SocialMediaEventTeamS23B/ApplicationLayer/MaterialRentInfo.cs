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
        public MaterialRentInfo(DataBaseConnection dbConnection)
        {
            this.dbConnection = dbConnection;
            if (dbConnection == null)
            {
                throw new NullException("dbConnection is empty!");
            }
        }
        public List<Material> GetMaterialsInEvent()
        {
            return dbConnection.GetMaterialsInEvent();
        }
        public MaterialRentPersonalInfo GetPersonalInfo(string RFID)
        {
           return dbConnection.PersonMaterialRentInfo(RFID);
        }
    }

}
