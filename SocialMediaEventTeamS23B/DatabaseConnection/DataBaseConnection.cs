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
            var query = String.Format(
                "SELECT Huurprijs " +
                "FROM materiaal_event " +
                "WHERE EventId = {0} " +
                "AND MateriaalId = {1};",
                eventId, materialId);
            return dbConnector.QueryScalar<double>(query);
        }

        public char GetPayInfo(String RFID)
        {
            var query = String.Format("SELECT isBetaald FROM reservering WHERE LeiderId = (SELECT LeiderId FROM deelnemer WHERE RFID = {0});", RFID);
            return dbConnector.QueryScalar<char>(query);
        }

        public int GetHighestId(string idType)
        {
            if (idType == "Materiaal")
            {
                var query = String.Format("SELECT MAX(MateriaalId) FROM Materiaal;");
                return dbConnector.QueryScalar<int>(query);
            }
            else
            {
                return 0;
            }
        }

        #endregion
        #region INSERT INTO

        public int AddMaterial(string name, string type, double price, String state)
        {
            int maxId = GetHighestId("Materiaal");
            var nonquery = String.Format("INSERT INTO materiaal (MateriaalId, MatModel, MatType, Kostprijs, Status) VALUES ({0}, {1}, {2}, {3}, {4});", maxId, name, type, price, state);
            return dbConnector.QueryNoResult(nonquery);
        }
        #endregion
    }
}
/*

*/