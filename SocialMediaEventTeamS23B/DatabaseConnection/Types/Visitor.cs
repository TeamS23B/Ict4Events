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
        public String Prefix { get; private set; } // tussenvoegsel
        public String Surname { get; private set; }
        public AdressInfo Adress { get; private set; }
        public string RFID { get; private set; }
        public string IBAN { get; private set; }
        public string Email { get; private set; }

        // "User"
        public String Username { get; private set; }

        // Leader
        public Visitor(string username, string name, string prefix, string surname, string email, string iban, AdressInfo adress, string rfid):this( username,name,prefix,surname,email,iban,adress,rfid,true)
        {
            
        }

        // Visitor
        public Visitor(string username, string name, string prefix, string surname, string email, string rfid):this(username,name,prefix,surname,email,null,null,rfid,false)
        {
            
        }

        private Visitor(string username,string prefix, string name, string surname, string email, string iban, AdressInfo adress, string rfid,bool isLeader)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(username))
            {
                throw new InvalidDataException("(User)(Sur)name is empty or null");
            }
            if (isLeader && (adress == null ))
            {
                throw new InvalidDataException("Missing leader info");
            }
            Name = name;
            Surname = surname;
            Adress = adress;
            RFID = rfid;
            Email = email;
            IBAN = iban;
            Prefix = prefix;
            Username = username;

        }

        public override string ToString()
        {
            return string.Format("{{Name={0},Surname={1},Adress={2},RFID={3}}}",Name,Surname,Adress,RFID);
        }
    }
}
