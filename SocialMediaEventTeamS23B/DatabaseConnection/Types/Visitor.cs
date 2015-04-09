using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConnection.Exeptions;

namespace DatabaseConnection.Types
{
    public class Visitor
    {
        public String Name { get; private set; }
        public String Surname { get; private set; }
        public AdressInfo Adress { get; private set; }
        public int Age { get; private set; }
        public int RFID { get; private set; }
        public String Phonenumber { get; private set; }


        //"User"
        public String Username { get; private set; }//todo what? how?
        public int Authorisation { get; private set; }//todo what? how?
        //todo login?


        public Visitor(string name, string surname, AdressInfo adress, int age, int rfid, string phonenumber):this(name,surname,adress,age,rfid,phonenumber,true)
        {
            
        }

        public Visitor(string name, string surname, int rfid):this(name,surname,null,0,rfid,null,false)
        {
            
        }

        private Visitor(string name, string surname, AdressInfo adress, int age, int rfid, string phonenumber,bool isLeader)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname))
            {
                throw new InvalidDataException("(Sur)name is emtpy or null");
            }
            if (isLeader && (adress == null || age <= 0 || string.IsNullOrEmpty(phonenumber)))
            {
                throw new InvalidDataException("Missing leader info");
            }
            Name = name;
            Surname = surname;
            Adress = adress;
            Age = age;
            RFID = rfid;
            Phonenumber = phonenumber;
        }

        public override string ToString()
        {
            return string.Format("{{Name={0},Surname={1},Adress={2},Age={3},RFID={4},Phonenumber={5}}}",Name,Surname,Adress,Age,RFID,Phonenumber);
        }
    }
}
