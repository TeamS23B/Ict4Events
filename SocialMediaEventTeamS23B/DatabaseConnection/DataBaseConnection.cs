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

        public decimal GetHighestId(string idType)
        {
            var query = String.Format("SELECT MAX({0}Id) FROM {1}", idType, idType);
            return dbConnector.QueryScalar<decimal>(query);
            }

        #endregion
        #region INSERT INTO

        public int AddMaterial(string name, string type, Decimal price, String state)
        {
            decimal maxId = GetHighestId("Materiaal") + 1;
            var nonquery = String.Format("INSERT INTO materiaal (MateriaalId, MatModel, MatType, Kostprijs, Status) VALUES ({0}, {1}, {2}, {3}, {4});", maxId, name, type, price, state);
            return dbConnector.QueryNoResult(nonquery);
        }

        public int AddPost(int postId, string rfid, int category, string title, string text, int commentOn, DateTime timeOfPost)
        {
            return dbConnector.QueryNoResult(nonquery);
        }

        public int AddEvent()
        #endregion
    }
}
/*

*/