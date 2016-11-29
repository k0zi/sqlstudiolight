using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DatabaseTest
{
    public class SQLConnection
    {
        private static SqlConnection myConnection = new SqlConnection("user id=sa;" +
                                       @"password=sasa;server=\\K0ZI-THINK\SQLEXPRESS;" +
                                       "Trusted_Connection=no;" +
                                       "database=TestDB; " +
                                       "connection timeout=30");
        public static SqlConnection MyConnection
        {
            get { return myConnection; }
        }
    }
}
