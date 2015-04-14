using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Drawing;
using DatabaseConnection.Exceptions;
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

        /// <summary>
        /// Return the RFID of the given user.
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
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
        /// Return the identifier of the given post.
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public decimal GetPostId(string title)
        {
            var query = String.Format(
                "SELECT BerichtId " +
                "FROM Bericht " +
                "WHERE Titel = {0}; ",
                title);


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
        public MaterialRentPersonalInfo PersonMaterialRentInfo(String RFID)
        {
            String RFIDPerson = "";
            String TotalName = "";
            var query = String.Format("SELECT RFID, Voornaam, Tussenvoegsel, Achternaam FROM deelnemer WHERE RFID = '{0}'", RFID);
            OracleDataReader odr = dbConnector.QueryReader(query);
            while(odr.Read())
            {
                RFIDPerson = odr[0].ToString();
                TotalName = odr[1].ToString() +" "+ odr[2].ToString() +" "+ odr[3].ToString(); 
            }
            odr.Close();
            dbConnector.CloseConnection();
            MaterialRentPersonalInfo info = new MaterialRentPersonalInfo(RFIDPerson,TotalName);
            return info;
        }


        public List<MapLocation> GetMapLocations()
        {
            List<MapLocation> maplocations = new List<MapLocation>();
            try
            {
                var query = "SELECT * FROM plaats";
                OracleDataReader odr = dbConnector.QueryReader(query);
                while (odr.Read())
                {
                    //veel was niet nodig
                    int mapLocationId = Convert.ToInt32(odr["PlaatsId"]);
                    int locationId = Convert.ToInt32(odr["LocatieId"]);
                    int mapLocationNr = Convert.ToInt32(odr["PlaatsNr"]);
                    int xMap = Convert.ToInt32(odr["xPlattegrond"]);
                    int yMap = Convert.ToInt32(odr["yPlattegrond"]);
                    int width = Convert.ToInt32(odr["Breedte"]);
                    int height = Convert.ToInt32(odr["Hoogte"]);
                    string Cat = Convert.ToString(odr["Categorie"]);
                    maplocations.Add(new MapLocation(mapLocationNr, new Point(xMap, yMap), new Point(width, height), Cat));
                }
            }
            catch
            {

            }
            return maplocations;
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

        public List<Visitor> GetVisitor()
        {
            List<Visitor> visitors = new List<Visitor>();
            try
            {
                AdressInfo Adress = new AdressInfo("Unknown","Unknown",999,"Unknown");
                var query = "SELECT * FROM deelnemer";
                OracleDataReader odr = dbConnector.QueryReader(query);
                while (odr.Read())
                {
                    int Number = 999;
                    string RFID = Convert.ToString(odr["RFID"]);
                    string Name = Convert.ToString(odr["Voornaam"]);
                    string Prefix =Convert.ToString(odr["Tussenvoegsel"]);
                    string Surname = Convert.ToString(odr["Achternaam"]);
                    string UserName = Convert.ToString(odr["Gebruikersnaam"]);
                    string Leader = Convert.ToString(odr["IsLeider"]);
                    string Iban = Convert.ToString(odr["Iban"]);
                    string Email = Convert.ToString(odr["Emailadres"]);
                    string Street = Convert.ToString(odr["Straatnaam"]);
                    if (Convert.ToString(odr["Huisnummer"])!= "")
                    {
                        Number = Convert.ToInt32(odr["Huisnummer"]);
                    }
                    string Suffix = Convert.ToString(odr["Toevoeging"]);
                    string City = Convert.ToString(odr["Plaatsnaam"]);
                    string PostalCode = Convert.ToString(odr["Postcode"]);
                                        
                    if(Leader == "J")
                    {
                        Adress = new AdressInfo(Street, City, Number, PostalCode);
                        visitors.Add(new Visitor(UserName,Name,Prefix,Surname,Email,Iban,Adress,RFID));
                    }
                    if(Leader == "N")
                    {
                        visitors.Add(new Visitor(UserName,Name,Prefix,Surname,Email,RFID));
                    }                  
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
            return visitors;
        }
        public List<Material> MaterialsOfVisitor(string RFID)
        {
            List<Material> materials = new List<Material>();
            try
            {
                var query = String.Format("SELECT m.MATERIAALID, m.MATMODEL, m.MATTYPE, m.KOSTPRIJS, m.HUURPRIJS, m.STATUS FROM gehuurd_materiaal gm INNER JOIN materiaal m ON gm.MateriaalId = m.MateriaalId INNER JOIN huur h ON h.HuurId = gm.HuurId WHERE h.RFID = '{0}'", RFID);
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
            return materials;
        }
        /// <summary>
        /// Get post from parent post, 0 for top
        /// </summary>
        /// <param name="id">parent post, 0 for top</param>
        /// <returns>list of post from parent post</returns>
        public List<Post> GetPostsOf(int id)
        {
            List<Post> posts = new List<Post>();
            try
            {
                String query = "SELECT * " +
                               "FROM bericht " +
                               "WHERE zichtbaar='J'" +
                               "AND ReadtieOp="+(id>0?id.ToString():"NULL");
                OracleDataReader reader = dbConnector.QueryReader(query); //Checkt query + leest het uit

                while (reader.Read())
                {
                    int postId = Convert.ToInt32(reader["BerichtId"]);
                    string rfid = Convert.ToString(reader["Rfid"]);
                    int categoryId = Convert.ToInt32(reader["CategorieId"]);
                    string commentTitle = Convert.ToString(reader["Titel"]);
                    var pathToFile = reader["Bestand"];
                    string description = Convert.ToString(reader["Tekst"]);
                    DateTime placedOn = Convert.ToDateTime(reader["GeplaatsOm"]);
                    Mediafile mf = pathToFile == DBNull.Value ? null : new PictureFile("", (string)pathToFile);
                    posts.Add(new Post(commentTitle, null,mf,description, 0,0,placedOn,rfid, null,postId));
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
            return posts;
        }

        public List<Material> GetMaterialsInEvent()
        {
            List<Material> materials = new List<Material>();
            try
            {
                var query = "SELECT * FROM materiaal WHERE materiaalId IN (SELECT materiaalId FROM materiaal_event WHERE eventId = 1)";
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
            return materials;
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
            return materials;
        }

        // WORK IN PROGRESS
        public List<Post> GetCommentsOfPost(string title)
        {
            try
            {
                List<Post> comments = new List<Post>();
                decimal parentPostId = GetPostId(title);
                var query = String.Format(
                    "SELECT b.BESTAND,b.CATEGORIEID,b.GEPLAATSTOM,b.REACTIEOP,b.RFID,b.TEKST,b.TITEL,b.ZICHTBAAR, COUNT(case when likeofflag = 'L' then 1 end) as likes, COUNT(case when likeofflag = 'F' then 1 end) as flags " +
                    "FROM bericht b LEFT OUTER JOIN likeflag l ON b.berichtId = l.berichtId "+
                    "WHERE b.REACTIEOP = {0} "+
                    "GROUP BY b.BESTAND,b.CATEGORIEID,b.GEPLAATSTOM,b.REACTIEOP,b.RFID,b.TEKST,b.TITEL,b.ZICHTBAAR;",parentPostId);
                OracleDataReader reader = dbConnector.QueryReader(query); //Checkt query + leest het uit

                while (reader.Read())
                {
                    int categoryId = Convert.ToInt32(reader["b.CategorieId"]);
                    string commentTitle = Convert.ToString(reader["b.Titel"]);
                    string pathToFile = Convert.ToString(reader["b.Bestand"]);
                    string description = Convert.ToString(reader["b.Tekst"]);
                    int commentOf = Convert.ToInt32(reader["b.ReactieOp"]);
                    DateTime placedOn = Convert.ToDateTime(reader["b.GeplaatsOm"]);
                    string visible = Convert.ToString(reader["b.Zichtbaar"]);
                    int likes = Convert.ToInt32(reader["Likes"]);
                    int flags = Convert.ToInt32(reader["Flags"]);
                    string uploader = Convert.ToString(reader["Gebruikersnaam"]);

                    if (visible == "N")
                    {

                    }
                    else
                    {
                        //Post comment = new Post(commentTitle, null, description, null, null, placedOn, );
                    }
                }
            }
            catch
            {

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
                
                    string sqlCheckIfWorkerIsParticipant = "SELECT Gebruikersnaam,Wachtwoord FROM deelnemer WHERE Gebruikersnaam = '" + username + "' AND Wachtwoord = '" + password + "'";
                    reader = dbConnector.QueryReader(sqlCheckIfWorkerIsParticipant);
                    while (reader.Read())
                        {
                            if (!string.IsNullOrEmpty((string)reader[0])&&!string.IsNullOrEmpty((string)reader[1]))
                            {
                                function += "User";
                            }
                            
                        }
                    

                    reader.Close();
                    dbConnector.CloseConnection();

                
                 
                return function;
            }
            catch
            {
                return "error";
            }
        }

        public decimal GetHighestId(string idType)
        {
            var query = String.Format("SELECT MAX({0}Id) FROM {1}", idType, idType);
            return dbConnector.QueryScalar<decimal>(query);
        }

        /// <summary>
        /// Get a visitor by a specific username
        /// </summary>
        /// <param name="username">the username</param>
        /// <returns>A visitor reperesenting the user</returns>
        public Visitor GetVistitorFomUsername(String username)
        {
            var querry = String.Format("SELECT * " +
                                       "FROM deelnemer " +
                                       "WHERE gebruikersnaam = '{0}'",username);
            var reader = dbConnector.QueryReader(querry);
            if (!reader.HasRows)
            {
                throw new InvalidDataException("Unkowm username!");
            }
            reader.Read();
            Visitor visitor;
            if (reader["HoortBij"] != DBNull.Value)
            {
                var t = reader["Toevoeging"];
                AdressInfo address;
                if (t == DBNull.Value)
                {
                    address = new AdressInfo((string) reader["straatnaam"], (string) reader["plaatsnaam"],
                        (int) reader["Huisnummer"], (string) reader["Postcode"]);
                }
                else
                {
                    address = new AdressInfo((string)reader["straatnaam"], (string)reader["plaatsnaam"], (int)reader["Huisnummer"],(string)reader["toevoeging"], (string)reader["Postcode"]);
                }

                var tus = reader["tussenvoegsel"];

                visitor = new Visitor((string)reader["gebruikersnaam"], tus == DBNull.Value ? "" : (string)tus, (string)reader["voornaam"], (string)reader["achternaam"], (string)reader["emailadres"], (string)reader["iban"], address, (string)reader["rfid"]);
            }
            else
            {
                var tus = reader["tussenvoegsel"];
                visitor = new Visitor((string)reader["gebruikersnaam"], tus == DBNull.Value ? "" : (string)tus, (string)reader["voornaam"], (string)reader["achternaam"], (string)reader["emailadres"], (string)reader["rfid"]);
            }
            reader.Close();
            dbConnector.CloseConnection();
            return visitor;

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
        public int AddMaterial(string name, string type, Double price, Double rent, String state)
        {
            decimal maxId = GetHighestId("Materiaal") + 1;
            string pricestr = price.ToString().Replace(",",".");
            string rentstr = rent.ToString().Replace(",", ".");
            var nonquery = String.Format("INSERT INTO materiaal (MateriaalId, MatModel, MatType, Kostprijs, Huurprijs, Status) VALUES ({0}, '{1}', '{2}', {3}, {4}, '{5}')", maxId, name, type, pricestr, rentstr, state);
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
        /// Increase the amount of 'likes' on the given post by 1.
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public int LikePost(string username, string title)
        {
            decimal postId = GetPostId(title);
            string rfid = GetRFIDFromUser(username);
            string letter = "L";
            var nonquery = String.Format("INSERT INTO Likeflag (BerichtId, Rfid, LikeOfFlag) VALUES ({0}, {1}, {2})", postId, rfid, letter);
            return dbConnector.QueryNoResult(nonquery);

        }

        /// <summary>
        /// Increase the amount of 'flags' on the given post by 1.
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public int FlagPost(string username, string title)
        {
            decimal postId = GetPostId(title);
            string rfid = GetRFIDFromUser(username);
            string letter = "F";
            var nonquery = String.Format("INSERT INTO Likeflag (BerichtId, Rfid, LikeOfFlag) VALUES ({0}, {1}, {2})", postId, rfid, letter);
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
            var nonquery = String.Format("INSERT INTO event (eventId, locatieId, beheerderId, eventNaam, startmoment, eindmoment) VALUES ({0}, {1}, 1, '{2}', to_date('{3}','DD-MM-YYYY HH24:MI:SS'), to_date('{4}','DD-MM-YYYY HH24:MI:SS'))", maxId, locatieId, name, beginDateString, endDateString);
            return dbConnector.QueryNoResult(nonquery);
        }

        public int AddMaterialToEvent(Decimal materialId)
        {
            var nonquery = String.Format("INSERT INTO materiaal_event (eventId, materiaalId) VALUES (1, {0})", materialId);
            return dbConnector.QueryNoResult(nonquery);
        }

        /// <summary>
        /// Inserts a regular visitor into the database. Always add the group leader before adding regular visitors.
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="rfid"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="name"></param>
        /// <param name="prefix"></param>
        /// <param name="surname"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public int AddVisitor(int eventId, string rfid, string userName, string password, string name, string prefix, string surname, string email, string leaderRfid)
        {
            var nonquery = String.Format("INSERT INTO Deelnemer (Rfid, IsLeider, Voornaam, Tussenvoegsel, Achternaam, Emailadres, Wachtwoord, Gebruikersnaam, Eventid, HoortBij) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", rfid, "N", name, prefix, surname, email, password, userName, eventId, leaderRfid);
            return dbConnector.QueryNoResult(nonquery);
        }

        /// <summary>
        /// Inserts a group leader into the database. Always insert the group leader before adding regular visitors.
        /// </summary>
        /// <returns></returns>
        public int AddVisitorLeader(int eventId, string rfid, string userName, string password, string name, string prefix, string surname, string email, string iban, string street, int number, string suffix, string city, string postalCode)
        {
            
            var nonquery = String.Format("INSERT INTO Deelnemer (Rfid, IsLeider, Voornaam, Tussenvoegsel, Achternaam, Emailadres, Wachtwoord, Gebruikersnaam, Eventid, Iban, Straatnaam, Huisnummer, Toevoeging, Plaatsnaam, Postcode) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14})", rfid, "J", name, prefix, surname, email, password, userName, eventId, iban, street, number, suffix, city, postalCode);
            return dbConnector.QueryNoResult(nonquery);
        }

        /// <summary>
        /// Insert a reservation into the database.
        /// </summary>
        /// <param name="leiderRfid"></param>
        /// <param name="?"></param>
        /// <returns></returns>
        public int AddReservation(string leaderRfid, DateTime timeOfReservation)
        {
            decimal reservationId = GetHighestId("Reservering")+ 1;
            string timeOfReservationString = timeOfReservation.ToString("MM/dd/yyyy hh:mm:ss");

            var nonquery = String.Format("INSERT INTO Reservering (ReserveringId, LeiderId, Reserveermoment) VALUES ({0}, {1}, to_date('{2}','DD-MM-YYYY HH24:MI:SS'))", reservationId, leaderRfid, timeOfReservationString);
            return dbConnector.QueryNoResult(nonquery);
        }

        /// <summary>
        /// Insert a connection between an event, a location and a reservation into the database
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="locationId"></param>
        /// <param name="reservationId"></param>
        /// <returns></returns>
        public int AddLocationToReservation(int eventId, int locationId, int reservationId)
        {
            
            var nonquery = String.Format("INSERT INTO Reservering_Plaats (EventId, ReserveringId, PlaatsId) VALUES ({0}, {1}, {2})", eventId, reservationId, locationId);
            return dbConnector.QueryNoResult(nonquery);
        }

        /// <summary>
        /// Add a record to the database that tells you which RFID has rented something.
        /// To record which items were in fact rented, use the 'AddRentMaterial' method.
        /// </summary>
        /// <param name="rentDate"></param>
        /// <param name="returnDate"></param>
        /// <param name="renteeRfid"></param>
        /// <returns></returns>
        public int AddRent(DateTime rentDate, DateTime returnDate, string renteeRfid)
        {
            decimal rentId = GetHighestId("Huur") + 1;
            string rentDateString = rentDate.ToString("MM/dd/yyyy hh:mm:ss");
            string returnDateString = returnDate.ToString("MM/dd/yyyy hh:mm:ss");

            var nonquery = String.Format("INSERT INTO Huur (HuurId, BeginHuur, EindeHuur, Rfid) VALUES ({0}, {1}, {2}, {3})", rentId, rentDateString, returnDateString,renteeRfid);
            return dbConnector.QueryNoResult(nonquery);
        }

        /// <summary>
        /// Connect a 'rent' record to actual materials.
        /// When this method is executed, the materials will be connected to a rent date and return date.
        /// </summary>
        /// <param name="rentId"></param>
        /// <param name="materialId"></param>
        /// <returns></returns>
        public int AddRentMaterial(int rentId, int materialId)
        {
            var nonquery = String.Format("INSERT INTO Reservering_Materiaal (HuurId, MateriaalId) VALUES ({0}, {1})", rentId, materialId);
            return dbConnector.QueryNoResult(nonquery);
        }


        #endregion

        #region DELETE FROM

        public int RmvMaterialFromEvent(Decimal materialId)
        {
            var nonquery = String.Format("DELETE FROM materiaal_event WHERE eventId = 1 AND materiaalId = {0}", materialId);
            return dbConnector.QueryNoResult(nonquery);
        }

        public int RmvMaterial(Decimal materialId)
        {
            var nonquery = String.Format("DELETE FROM materiaal WHERE materiaalId = {0}", materialId);
            return dbConnector.QueryNoResult(nonquery);
        }

        #endregion

        #region UPDATE

        public int UpdFlagRules(Decimal flags, Decimal ratio, Decimal time, Char autoCleanUp)
        {
            var nonquery = String.Format("UPDATE flagRegels SET Flags = {0}, Verhouding = {1}, Tijd = {2}, Autoschoonmaak = '{3}'", flags, ratio, time, autoCleanUp);
            return dbConnector.QueryNoResult(nonquery);
        }

        public int UpdVisitorBlock(String RFID, Char yesno)
        {
            var nonquery = String.Format("UPDATE deelnemer SET IsGeblokkeerd = '{0}' WHERE RFID = '{1}'", yesno, RFID);
            return dbConnector.QueryNoResult(nonquery);
        }

        public int UpdPostVisibility(String RFID, Char yesno)
        {
            var nonquery = String.Format("UPDATE bericht SET Zichtbaar = '{0}' WHERE RFID = '{1}'", yesno, RFID);
            return dbConnector.QueryNoResult(nonquery);
        }

        #endregion

        #region FTP

        /// <summary>
        /// Upload a file to the remote server
        /// </summary>
        /// <param name="localFile">the local file to upload (fullPath)</param>
        /// <param name="remoteFile">the remote file, starting from the base, example upload/file1.txt</param>
        /// <returns></returns>
        public void FtpUpload(String localFile, String remoteFile)
        {
            using (var wc = new WebClient())
            {
                wc.Credentials=new NetworkCredential("Uploader","aapje");
                wc.UploadFile("ftp://192.168.20.112/"+remoteFile, localFile);
            }
        }

        #endregion
    }
}
/*

*/