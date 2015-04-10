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

        /// <summary>
        /// Returns the cost of renting the given material at the given event.
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="materialId"></param>
        /// <returns></returns>
        public decimal GetRentPrice(int eventId, int materialId)
        {
            var query = String.Format(
                "SELECT Huurprijs " +
                "FROM materiaal_event " +
                "WHERE EventId = {0} " +
                "AND MateriaalId = {1};",
                eventId, materialId);
            return dbConnector.QueryScalar<decimal>(query);
        }

        /// <summary>
        /// Returns the identifier that belongs to the given category name.
        /// </summary>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        public decimal GetCategoryId(string categoryName)
        {
            var query = String.Format(
                "SELECT CategorieId " +
                "FROM Categorie " +
                "WHERE Naam = {0}; ",
                categoryName);
            return dbConnector.QueryScalar<decimal>(query);
        }

        
        /// <summary>
        /// Returns either 'J' if the given RFID has status 'paid', or 'N' if this is not the case.
        /// </summary>
        /// <param name="RFID"></param>
        /// <returns></returns>
        public char GetPayInfo(String RFID)
        {
            var query = String.Format("SELECT isBetaald FROM reservering WHERE LeiderId = (SELECT LeiderId FROM deelnemer WHERE RFID = {0});", RFID);
            return dbConnector.QueryScalar<char>(query);
        }

        /// <summary>
        /// Returns the highest registered identifier for the given table.
        /// </summary>
        /// <param name="idType"></param>
        /// <returns></returns>
        public decimal GetHighestId(string idType)
        {
            var query = String.Format("SELECT MAX({0}Id) FROM {1}", idType, idType);
            return dbConnector.QueryScalar<decimal>(query);
        }

        #endregion
        #region INSERT INTO

        /// <summary>
        /// Insert a material with the given information into the database.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="price"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public int AddMaterial(string name, string type, Decimal price, String state)
        {
            decimal maxId = GetHighestId("Materiaal") + 1;
            var nonquery = String.Format("INSERT INTO materiaal (MateriaalId, MatModel, MatType, Kostprijs, Status) VALUES ({0}, {1}, {2}, {3}, {4});", maxId, name, type, price, state);
            return dbConnector.QueryNoResult(nonquery);
        }

        // AddPost bevat (nog) geen link naar een bestand.
        public int AddPost(string rfid, int category, string title, string text, int commentOn, DateTime timeOfPost)
        {
            decimal maxId = GetHighestId("Bericht") + 1;
            string postDate = timeOfPost.ToString("MM/dd/yyyy hh:mm:ss");
            var nonquery = String.Format("INSERT INTO bericht (BerichtId, RFID, CategorieId, Titel, Tekst, ReactieOp, GeplaatsOm) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7});", maxId, rfid, category, title, text, commentOn, timeOfPost);
            return dbConnector.QueryNoResult(nonquery);
        }

        // Nog niet af.
        public int AddCategory(string name, string parentCategory)
        {
            decimal maxId = GetHighestId("Categorie") + 1;
            var nonquery = String.Format("INSERT INTO bericht (CategorieId, Naam, HoortBij) VALUES ({0}, {1}, {2}, {3});", maxId, name, parentCategory);
            return dbConnector.QueryNoResult(nonquery);
        }

        public int AddEvent(Decimal locatieId, String name, DateTime startDate, DateTime endDate)
        {
            decimal maxId = GetHighestId("Event") + 1;
            string beginDateString = startDate.ToString("MM/dd/yyyy hh:mm:ss");
            string endDateString = endDate.ToString("MM/dd/yyyy hh:mm:ss");
            var nonquery = String.Format("INSERT INTO event (eventId, locatieId, beheerderId, eventNaam, startmoment, eindmoment) VALUES ({0}, {1}, 1, {2}, {3}, {4});", maxId, locatieId, name, beginDateString, endDateString);
            return dbConnector.QueryNoResult(nonquery);
        }
        #endregion
    }
}
/*

*/