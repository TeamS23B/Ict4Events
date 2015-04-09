using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationLayer.Exceptions;
using DatabaseConnection.Types;

namespace ApplicationLayer
{
    public class AccessControl
    {
        public List<Visitor> AllPresent { get; private set; }

        private bool isLoggedIn = false;
        private String username = "";

        public AccessControl()
        {
            
        }

        /// <summary>
        /// Checks the login information of the bouncer
        /// </summary>
        /// <param name="username">The username of the bouncer</param>
        /// <param name="password">The password of the bouncer</param>
        public void CheckLogin(String username, String password)
        {
            this.username = username;
            //isLoggedIn = db.Login(username,password);
        }

        /// <summary>
        /// Checks if de visitor has payed
        /// </summary>
        /// <param name="RFID">The RFID of the visitor</param>
        /// <returns>True if the user has payed, false if the user hasn't</returns>
        public bool CheckPayment(int RFID)
        {
            if (!isLoggedIn)
            {
                throw new NotLoggedInException("Can't check payment because the user is not logged in!");
            }
            return true; //retun db.checkPayment(RFID);
        }


    }
}
