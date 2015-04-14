using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConnection.Types;

namespace ApplicationLayer
{
    public class Admin
    {
        DatabaseConnection.DataBaseConnection dbc = new DatabaseConnection.DataBaseConnection();
        public List<Material> materials { get; private set; }

        public List<Event> events { get; private set; }
        /// <summary>
        /// Creates a new instance of the Admin class
        /// </summary>
        public Admin()
        {
            materials = new List<Material>();
            events = new List<Event>();
        }

        /// <summary>
        /// Adds a materials to the database
        /// </summary>
        /// <param name="name">The name of the material</param>
        /// <param name="type">The type of the material</param>
        /// <param name="price">The price of the matrial</param>
        /// <param name="rent">The rent of the material</param>
        /// <param name="state">The state of the material</param>
        public void AddMaterial(String name, String type, double price, double rent, String state)
        {
            materials.Add(new Material((int)dbc.GetHighestId("Materiaal") + 1, name, type, price, rent, state));
            dbc.AddMaterial(name, type, price, rent, state);
        }
        /// <summary>
        /// Edits a material NYI
        /// </summary>
        /// <param name="material">Edited material</param>
        public void EditMaterial(Material material)
        {
            //should
        }
        /// <summary>
        /// Adds a event to the database
        /// </summary>
        /// <param name="location">The location of the event</param>
        /// <param name="name">The name of the event</param>
        /// <param name="startDate">The start date of the event</param>
        /// <param name="endDate">The end date of the event</param>
        public void AddEvent(Location location, String name, DateTime startDate, DateTime endDate)
        {
            events.Add(new Event((int)dbc.GetHighestId("Event") + 1, location, name, startDate, endDate));
            dbc.AddEvent((decimal)location.LocatieId, name, startDate, endDate);
        }
        
        /// <summary>
        /// Get a list of all the available locations
        /// </summary>
        /// <returns>All the locations</returns>
        public List<Location> GetLocations()
        {
            return dbc.GetLocations();
        }
        /// <summary>
        /// Gets a list of all the materials in the event
        /// </summary>
        /// <returns>All the materials</returns>
        public List<Material> GetMaterialsInEvent()
        {
            return dbc.GetMaterialsInEvent();
        }

        /// <summary>
        /// Get all the materials
        /// </summary>
        /// <returns>All the materials</returns>
        public List<Material> GetAllMaterials()
        {
            return dbc.GetAllMaterials();
        }

        /// <summary>
        /// Remove a material from the database
        /// </summary>
        /// <param name="material">The material to remove</param>
        public void RemoveMaterial(Material material)
        {
            dbc.RmvMaterial(material.MaterialId);
        }
        
        /// <summary>
        /// Add a material to a event
        /// </summary>
        /// <param name="Material">The material to add</param>
        public void AddMaterialToEvent (Material Material )
        {
            dbc.AddMaterialToEvent(Material.MaterialId);
        }

        /// <summary>
        /// Remove a material from a event
        /// </summary>
        /// <param name="Material">The material to remove</param>
        public void RemoveMaterialFromEvent (Material Material )
        {
            dbc.RmvMaterialFromEvent(Material.MaterialId);
        }

        /// <summary>
        /// Edit the flagging controll
        /// </summary>
        /// <param name="flags">The amount of flags to check</param>
        /// <param name="ratio">The flag like ratio to check</param>
        /// <param name="time">The time the post exists</param>
        /// <param name="autoCleanUp">If the auto cleanup is enabled</param>
        public void EditFlaggingControl(int flags, int ratio, int time, bool autoCleanUp)
        {
            if(autoCleanUp)
            {
                dbc.UpdFlagRules(flags, ratio, time, 'J');
            }
            else if (!autoCleanUp)
            {
                dbc.UpdFlagRules(flags, ratio, time, 'N');
            }           
        }

        /// <summary>
        /// Get a list of all the visitors
        /// </summary>
        /// <returns></returns>
        public List<Visitor> GetVisitors()
        {
            return dbc.GetVisitor();
        }

        /// <summary>
        /// Get a list of all the posts of a user
        /// </summary>
        /// <param name="userName">The user of which to get the posts</param>
        /// <returns>All the posts of a user</returns>
        public List<Post> GetPosts(string userName)
        {
            return dbc.GetPostsFromUser(userName);
        }
        /// <summary>
        /// Edit if a visitor is blocked
        /// </summary>
        /// <param name="visitor">The visitor to edit</param>
        /// <param name="Change">The change to be made, 1 for blocked, 2 for unblocked</param>
        public void EditVisitor(Visitor visitor, int Change)
        {

            if (Change == 1)
            {
                dbc.UpdVisitorBlock(visitor.RFID, 'J');
            }
            else if(Change == 2)
            {
                dbc.UpdVisitorBlock(visitor.RFID, 'N');
            }
            
        }

        /// <summary>
        /// Hide a post
        /// </summary>
        /// <param name="visitor">The poster</param>
        /// <param name="title">The title of the post</param>
        /// <param name="Change">What to change, 3=blocked, 4=unblocked</param>
        public void EditPost(Visitor visitor, string title, int Change)
        {


            if (Change == 3)
            {
                dbc.UpdPostVisibility(visitor.RFID, title, 'N');
            }
            else if (Change == 4)
            {
                dbc.UpdPostVisibility(visitor.RFID, title, 'J');
            }
        }
        /// <summary>
        /// Get all the materials of a visitor
        /// </summary>
        /// <param name="visitor">The visitor</param>
        /// <returns>All his or hers materials</returns>
        public List<Material> VisitorMaterial(Visitor visitor)
        {
            return dbc.MaterialsOfVisitor(visitor.RFID);
        }
    }
}
