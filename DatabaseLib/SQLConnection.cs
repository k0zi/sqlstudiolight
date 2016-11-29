using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DatabaseLib
{
    public class Credentials
    {
        private string server;
        private string database;
        private string username;
        private string password;

        public Credentials(string s, string d, string u, string p)
        {
            this.server = s;
            this.database = d;
            this.username = u;
            this.password = p;
        }

        public string ConnectionString
        {
            get
            {
                string s = "user id="+username+";" +
                                       "password="+password+";server="+server+";" +
                                       "Trusted_Connection=no;" +
                                       "database="+database+"; " +
                                       "connection timeout=3000";
                return s;
            }
        }
    }
    public class SQLConnection
    {
        private SqlConnection myConnection;
        private Credentials myCredentials;

        public SQLConnection(Credentials c)
        {
            myCredentials = c;
            myConnection = new SqlConnection(c.ConnectionString);
        }
        public SqlConnection MyConnection
        {
            get { return myConnection; }
        }
    }
}
