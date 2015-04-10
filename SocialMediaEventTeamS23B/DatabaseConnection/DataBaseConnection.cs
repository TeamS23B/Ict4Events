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
                "AND MateriaalId = {1}",
                eventId, materialId);
            return dbConnector.QueryScalar<decimal>(query);
        }

        
        public string GetRFIDFromUser(string username)
        {
            var query = String.Format("SELECT Rfid FROM Deelnemer WHERE Gebruikersnaam = {0};", username);
            return dbConnector.QueryScalar<string>(query);
        }

        /// <summary>
        /// Returns the amount of likes submitted to the given post.
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public decimal GetLikesFromPost(string title)
        {
            var query = String.Format("SELECT COUNT(LikeOfFlag) AS TotalLikes FROM LIKEFLAG WHERE LikeOfFlag = 'L' AND BerichtId = (SELECT BerichtId FROM Bericht WHERE Titel = '{0}');", title);
            return dbConnector.QueryScalar<decimal>(query);
        
        }

        /// <summary>
        /// Returns the amount of flags submitted to the given post.
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public decimal GetFlagsFromPost(string title)
        {
            var query = String.Format("SELECT COUNT(LikeOfFlag) AS TotalFlags FROM LIKEFLAG WHERE LikeOfFlag = 'F' AND BerichtId = (SELECT BerichtId FROM Bericht WHERE Titel = '{0}');", title);
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
            var query = String.Format("SELECT isBetaald FROM reservering WHERE LeiderId = (SELECT LeiderId FROM deelnemer WHERE RFID = {0})", RFID);
            return dbConnector.QueryScalar<char>(query);
        }

        public List<Location> GetLocations()
        {
            List<Location> locations = new List<Location>();
            try
            {
                var query = "SELECT * FROM locatie";
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
            List<Material> materials = new List<Material>();
            try
            {
                var query = "SELECT * FROM materiaal WHERE materiaalId IN (SELECT materiaalId FROM materiaal_event WHERE eventId = 1";
                OracleDataReader odr = dbConnector.QueryReader(query);
                while (odr.Read())
                {
                    int MaterialId = Convert.ToInt32(odr["MateriaalId"]);
                    String Name = Convert.ToString(odr["MatModel"]);
                    String Type = Convert.ToString(odr["MatType"]);
                    double Price = Convert.ToDouble(odr["Kostprijs"]);
                    double Rent = Convert.ToDouble(odr["Huurprijs"]);
                    String State = Convert.ToString(odr["Status"]);
                    materials.Add(new Material(MaterialId, Name, Type, Price, Rent, State));
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
            return null;
        }

        public List<Material> GetAllMaterials()
        {
            List<Material> materials = new List<Material>();
            try
            {
                var query = "SELECT * FROM materiaal";
                OracleDataReader odr = dbConnector.QueryReader(query);
                while (odr.Read())
                {
                    int MaterialId = Convert.ToInt32(odr["MateriaalId"]);
                    String Name = Convert.ToString(odr["MatModel"]);
                    String Type = Convert.ToString(odr["MatType"]);
                    double Price = Convert.ToDouble(odr["Kostprijs"]);
                    double Rent = Convert.ToDouble(odr["Huurprijs"]);
                    String State = Convert.ToString(odr["Status"]);
                    materials.Add(new Material(MaterialId, Name, Type, Price, Rent, State));
                }
            }
            catch(Exception e)
            {
                string message = e.Message;
            }
            finally
            {
                dbConnector.CloseConnection();
            }
            return null;
        }
        
        /// <summary>
        /// Returns a list of post objects belonging to the current user.
        /// ------ WORK IN PROGRESS --------
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        //public List<Post> GetPostsFromUser(string username)
        //{
        //    List<Post> posts = new List<Post>();
        //    try
        //    {
        //        string sqlPost = "SELECT * FROM Bericht WHERE Gebruikersnaam = '" + username + "'";
        //        OracleDataReader reader = dbConnector.QueryReader(sqlPost);

        //        while (reader.Read())
        //        {
                    
        //            Mediafile mediafile;//nullable
                    
        //            string description;
        //            decimal likes;
        //            decimal flags;
        //            DateTime postedOn;
        //            string uploader;
        //            Category category;
        //        }
        //    }
        //    catch
        //    {

        //    }
        //}

        public string Login(string username, string password)
        {
            string function = "";
            try
            {
                //Kijken of het personeel is 
                string sqlWerknemer = "SELECT Functie FROM personeel WHERE Gebruikersnaam = '" + username + "' AND Wachtwoord= '" + password + "'";
                OracleDataReader reader = dbConnector.QueryReader(sqlWerknemer); //Checkt query + leest het uit               

                while (reader.Read())
                {
                    function = (string)reader[0];
                }
                reader.Close();
                dbConnector.CloseConnection();
                if(function != null)
                {
                    string sqlCheckIfWorkerIsParticipant = "SELECT Gebruikersnaam,Wachtwoord FROM deelnemer WHERE Gebruikersnaam = '" + username + "' AND Wachtwoord = '" + password + "'";
                    reader = dbConnector.QueryReader(sqlCheckIfWorkerIsParticipant);
                    while (reader.Read())
                    {
                        if (username == reader[0].ToString() && password == reader[1].ToString())
                        {
                            function = function + "User";
                        }
                        else
                        {
                            function = function;
                        }
                    }
                }

                reader.Close();
                dbConnector.CloseConnection();

                if (dbConnector.QueryReader(sqlWerknemer) == null)
                {
                    string sqlDeelnemer = "SELECT Gebruikersnaam,Wachtwoord FROM deelnemer WHERE Gebruikersnaam = '" + username + "' AND Wachtwoord = '" + password + "'";
                    reader = dbConnector.QueryReader(sqlDeelnemer);
                    while (reader.Read())
                    {
                        if (username == reader[0].ToString() && password == reader[1].ToString())
                        {
                            function = "User";
                        }
                        else
                        {
                            function = "NonUser";
                        }
                    }
                    reader.Close();
                    dbConnector.CloseConnection();
                }
                return function;
            }
            catch
            {
                return function = "error";
            }
        }

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
        public int AddMaterial(string name, string type, Decimal price, Decimal rent, String state)
        {
            decimal maxId = GetHighestId("Materiaal") + 1;
            var nonquery = String.Format("INSERT INTO materiaal (MateriaalId, MatModel, MatType, Kostprijs, Huurprijs, Status) VALUES ({0}, {1}, {2}, {3}, {4}, {5})", maxId, name, type, price, rent, state);
            return dbConnector.QueryNoResult(nonquery);
        }

        // AddPost bevat (nog) geen link naar een bestand.
        public int AddPost(string rfid, int category, string title, string text, int commentOn, DateTime timeOfPost)
        {
            decimal maxId = GetHighestId("Bericht") + 1;
            string postDate = timeOfPost.ToString("MM/dd/yyyy hh:mm:ss");
            var nonquery = String.Format("INSERT INTO bericht (BerichtId, RFID, CategorieId, Titel, Tekst, ReactieOp, GeplaatsOm) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", maxId, rfid, category, title, text, commentOn, timeOfPost);
            return dbConnector.QueryNoResult(nonquery);
        }

        /// <summary>
        /// Insert a category with a given name into the database. 
        /// This category will become a subcategory of the given parent category.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="parentCategory"></param>
        /// <returns></returns>
        public int AddCategory(string name, string parentCategory)
        {
            decimal maxId = GetHighestId("Categorie") + 1;
            decimal parentId = GetCategoryId(parentCategory);
            if (parentId != null)
            {
                var nonquery = String.Format("INSERT INTO bericht (CategorieId, Naam, HoortBij) VALUES ({0}, {1}, {2}, {3});", maxId, name, parentId);
                return dbConnector.QueryNoResult(nonquery);
            }
            throw new NullReferenceException("Hoofdcategorie niet gevonden.");
            
        }

        /// <summary>
        /// Insert a category with a given name into the database.
        /// This category will be a 'first-generation' category; it has no parent category.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int AddCategory(string name)
        {
            decimal maxId = GetHighestId("Categorie") + 1;
            var nonquery = String.Format("INSERT INTO bericht (CategorieId, Naam, HoortBij) VALUES ({0}, {1}, {2}, {3});", maxId, name, null);
            return dbConnector.QueryNoResult(nonquery);
        }


        public int AddEvent(Decimal locatieId, String name, DateTime startDate, DateTime endDate)
        {
            decimal maxId = GetHighestId("Event") + 1;
            string beginDateString = startDate.ToString("MM/dd/yyyy hh:mm:ss");
            string endDateString = endDate.ToString("MM/dd/yyyy hh:mm:ss");
            var nonquery = String.Format("INSERT INTO event (eventId, locatieId, beheerderId, eventNaam, startmoment, eindmoment) VALUES ({0}, {1}, {2}, {3}, {4})", maxId, locatieId, name, beginDateString, endDateString);
            return dbConnector.QueryNoResult(nonquery);
        }

        public int AddMaterialToEvent(Decimal materialId)
        {
            var nonquery = String.Format("INSERT INTO materiaal_event (eventId, materiaalId) VALUES 1, {0}", materialId);
            return dbConnector.QueryNoResult(nonquery);
        }
        #endregion

        #region DELETE FROM

        public int RmvMaterialFromEvent(Decimal materialId)
        {
            var nonquery = String.Format("DELETE FROM materiaal_event WHERE eventId = 1 AND materiaalId = {0}", materialId);
            return dbConnector.QueryNoResult(nonquery);
        }

        #endregion

        #region UPDATE

        public int UpdFlagRules(Decimal flags, Decimal ratio, Decimal time, Char autoCleanUp)
        {
            var nonquery = String.Format("UPDATE flagRules SET Flags = {0}, Verhouding = {1}, Tijd = {2}, Autoschoonmaak '{3}'", flags, ratio, time, autoCleanUp);
            return dbConnector.QueryNoResult(nonquery);
        }

        #endregion

        #region UPDATE

        

        /// <summary>
        /// Increase the amount of 'likes' on the given post by 1.
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public int LikePost(string rfid, string title)
        {
            decimal postId = Get
            var nonquery = String.Format("INSERT INTO Likeflag (BerichtId, Rfid, LikeOfFlag) VALUES ({0}, {1}, {2})", maxId, locatieId, name, beginDateString, endDateString);
            return dbConnector.QueryNoResult(nonquery);
            
        }

        /// <summary>
        /// Increase the amount of 'flags' on the given post by 1.
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public int FlagPost(string title)
        {
            return 0;
        }
        #endregion

        #region UPDATE

        

       

        #endregion
    }
}
/*

*/