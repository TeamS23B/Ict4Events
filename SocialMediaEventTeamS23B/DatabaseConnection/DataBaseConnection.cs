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
            dbConnector = new DataBaseConnector("SYSTEM","aapje");
        }

        public double GetRentPrice(int eventId, int materialId)
        {
            var querry = String.Format(
                "SELECT Huurprijs FROM materiaal_event WHERE eventId = {0} AND materiaalId = {1}", eventId, materialId);
            return dbConnector.QuerryScalar<double>(querry);
        }
    }
}
