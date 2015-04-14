using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ApplicationLayer.Exceptions;
using DatabaseConnection;
using DatabaseConnection.Exceptions;
using DatabaseConnection.Types;

namespace ApplicationLayer
{
    public class Login
    {
        /// <summary>
        /// Hashes the input to bytes
        /// usage (Encoding.[UTF8].GetBytes(input))
        /// </summary>
        /// <param name="input">What to hash</param>
        /// <returns>hashed bytes, size=20</returns>
        public static byte[] HashedBytes(byte[] input)
        {
            HashAlgorithm alg = new SHA1Managed();
            return alg.ComputeHash(input);
        }

        public string Username { get; private set; }
        public bool IsLoggedIn { get { return !string.IsNullOrEmpty(Username); } }

        private DataBaseConnection dbConnection;

        public Login(DataBaseConnection dbConnection)
        {
            this.dbConnection = dbConnection;
            if(dbConnection==null)
            {
                throw new NullException("dbConnection is empty!");
            }
        }

        public string LoginToApplication(string username, string password)
        {
            var result = dbConnection.Login(username, password);
            if (string.IsNullOrEmpty(result) || result == "error")
            {
                throw new InvalidDataException("Username or Password is incorrect!");
            }
            Username = username;
            return result;
            }

        public void LogoutFromApplication()
        {
            if (!string.IsNullOrEmpty(Username)) Username = "";
        }

        public Visitor GetVisitor()
        {
            if (!IsLoggedIn)
            {
                throw new NotLoggedInException("The user isn't logged in!");
            }
            return dbConnection.GetVistitorFomUsername(Username);
        }
    }
}
