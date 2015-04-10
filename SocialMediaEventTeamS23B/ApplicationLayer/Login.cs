using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationLayer.Exceptions;
using DatabaseConnection.Types;

namespace ApplicationLayer
{
    public class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Login(string Username, string Password)
        {
            if(Username =="" || Password =="")
            {
                throw new NullException("Voer correcte gebruikersnaam en wachtwoord in");
            }
            else
            {
                this.Username = Username;
                this.Password = Password;
            }
        }
    }
}
