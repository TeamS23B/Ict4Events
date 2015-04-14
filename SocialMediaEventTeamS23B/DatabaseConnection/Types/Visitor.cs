using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConnection.Exceptions;

namespace DatabaseConnection.Types
{
    public class Visitor
    {
        public String Name { get; private set; }
        public String Surname { get; private set; }
        public AdressInfo Adress { get; private set; }
        public string RFID { get; private set; }


        //"User"
        public String Username { get; private set; }


        public Visitor(string username, string name, string surname, AdressInfo adress, string rfid):this( username, name,surname,adress,rfid,true)
        {
            
        }

        public Visitor(string username, string name, string surname, string rfid):this(username,name,surname,null,rfid,false)
        {
            
        }

        private Visitor(string username, string name, string surname, AdressInfo adress, string rfid,bool isLeader)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(username))
            {
                throw new InvalidDataException("(User)(Sur)name is emtpy or null");
            }
            if (isLeader && (adress == null ))
            {
                throw new InvalidDataException("Missing leader info");
            }
            Name = name;
            Surname = surname;
            Adress = adress;
            RFID = rfid;
        }

        public override string ToString()
        {
            return string.Format("{{Name={0},Surname={1},Adress={2},RFID={3}}}",Name,Surname,Adress,RFID);
        }
    }
}
