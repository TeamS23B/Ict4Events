using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    public class DataBaseConnection
    {
        private DataBaseConnector dbConnector;

        public DataBaseConnection()
        {
            dbConnector = new DataBaseConnector("SYSTEM", "aapje");
        }

        #region SELECT

        public double GetRentPrice(int eventId, int materialId)
        {
            var querry = String.Format(
                "SELECT Huurprijs " +
                "FROM materiaal_event " +
                "WHERE EventId = {0} " +
                "AND MateriaalId = {1};", 
                eventId, materialId);
            return dbConnector.QuerryScalar<double>(querry);
        }

        #endregion

    }
}
