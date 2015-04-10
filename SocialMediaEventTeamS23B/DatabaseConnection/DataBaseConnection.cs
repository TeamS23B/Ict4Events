using System;
using System.Collections.Generic;
using System.Linq;
using DatabaseConnection.Types;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

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

        public List<Location> GetLocations()
        {
            List<Location> locations = new List<Location>();
            try
            {

                var query = "SELECT * FROM locatie;";
                OracleDataReader odr = dbConnector.QueryReader(query);
                while (odr.Read())
                {
                    int locatieId = Convert.ToInt32(odr["LocatieId"]);
                    string street = Convert.ToString(odr["Straatnaam"]);
                    int number = Convert.ToInt32(odr["Huisnummer"]);
                    string adition = Convert.ToString(odr["Toevoeging"]);
                    string town = Convert.ToString(odr["Plaatsnaam"]);
                    string zipcode = Convert.ToString(odr["Postcode"]);
                    string map = Convert.ToString(odr["Plattegrond"]);
                    locations.Add(new Location(locatieId, street, number, adition, town, zipcode, map));
                }
            }
            catch (Exception e)
            {
                string message = e.Message;
            }
            finally
            {
                dbConnector.CloseConnection();
            }

            return locations;
        }
        public List<Material> GetMaterialsInEvent()
        {
            return null;
        }
        //public List<Material> 

        public decimal GetHighestId(string idType)
        {
            var query = String.Format("SELECT MAX({0}Id) FROM {1}", idType, idType);
            return dbConnector.QueryScalar<decimal>(query);
            }

        public string Login(string username, string password)
        {
            string functie = "";
            try
            {
                //Kijken of het personeel is 
                string sqlWerknemer = "SELECT Functie FROM personeel WHERE Gebruikersnaam = " + username + " AND Wachtwoord=" + password + "";
                OracleDataReader reader = dbConnector.QueryReader(sqlWerknemer); //Checkt query + leest het uit               

                while (reader.Read())
                {
                    functie = (string)reader[0];
                }

                if (dbConnector.QueryReader(sqlWerknemer) == null)
                {
                    string sqlDeelnemer = "SELECT Gebruikersnaam,Wachtwoord FROM deelnemer WHERE Gebruikersnaam = " + username + " AND Wachtwoord =" + password + "";
                    reader = dbConnector.QueryReader(sqlDeelnemer);
                    while (reader.Read())
                    {
                        if (username == reader[0].ToString() && password == reader[1].ToString())
                        {
                            functie = "User";
                        }
                        else
                        {
                            functie = "NonUser";
                        }
                    }

                }
                return functie;
            }
            catch
            {
                return functie = "error";
            }
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