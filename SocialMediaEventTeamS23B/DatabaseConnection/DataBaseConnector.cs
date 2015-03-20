using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace DatabaseConnection
{
    internal class DataBaseConnector
    {
        private const string CONNECTIONSTRING = "SERVER=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={0})(PORT={1}))(CONNECT_DATA=(SERVICE_NAME={2})));uid={3};pwd={4};";

        private readonly OracleConnection connection;

        /// <summary>
        /// Creates a database connection and connects to it
        /// </summary>
        /// <param name="username">The username with whicht you want to log in</param>
        /// <param name="password">The password corresponding to the username</param>
        /// <param name="ipAdress">The ipadress of the server</param>
        /// <param name="hostname">The name you are know as by the server</param>
        /// <param name="port">the port to whicht to connect</param>
        public DataBaseConnector(string username, string password,string ipAdress,string hostname, string port="1521")
        {
            connection =
                new OracleConnection(String.Format(CONNECTIONSTRING, ipAdress, port, hostname, username, password));
            connection.Open();
        }

        /// <summary>
        /// Run a querry with no result
        /// </summary>
        /// <param name="querry">The querry which to run</param>
        /// <returns>Amount of rows affected</returns>
        public int QuerryNoResult(String querry)
        {
            //open connection and run command in non querry mode
            connection.Open();
            var command = new OracleCommand(querry, connection);
            return command.ExecuteNonQuery();
        }

        /// <summary>
        /// Run a scalar request(one response)
        /// </summary>
        /// <typeparam name="T">The type to cast te respons to</typeparam>
        /// <param name="querry">The querry to run</param>
        /// <returns>The value from the response as type T</returns>
        public T QuerryScalar<T>(String querry)
        {
            //open connection an execute in scalar mode
            connection.Open();
            var comand = new OracleCommand(querry, connection);
            //cast result to <T>
            return (T)comand.ExecuteScalar();
        }

        /// <summary>
        /// Runs a querry and get a reader to read all data
        /// </summary>
        /// <param name="querry">The querry to run</param>
        /// <returns>The reader object wich you can get all data from</returns>
        public OracleDataReader QuerryReader(String querry)
        {
            //open connection and and execute a command in reader mode
            connection.Open();
            var command = new OracleCommand(querry, connection);
            return command.ExecuteReader();
        }

    }
}
