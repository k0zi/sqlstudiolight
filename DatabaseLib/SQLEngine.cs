using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Threading.Tasks;

namespace DatabaseLib
{
    public class SQLEngine
    {
        private Credentials myCredentials;

        public SQLEngine(Credentials c)
        {
            myCredentials = c;
        }
        public Recordset Run(string command)
        {
            SQLConnection s = new SQLConnection(myCredentials);
            try
            {
                s.MyConnection.Open();
                SqlCommand myCommand = new SqlCommand(command, s.MyConnection);
                using (SqlDataReader myReader = myCommand.ExecuteReader())
                {
                    Recordset rs = new Recordset();
                    bool first = true;
                    while (myReader.Read())
                    {
                        if (first)
                        {
                            for (int i = 0; i < myReader.FieldCount; i++)
                            {
                                rs.AddName(myReader.GetName(i), i);
                            }
                            first = false;
                        }
                        Record r = new Record();
                        for (int i = 0; i < myReader.FieldCount; i++)
                        {
                            r.Fields.Add(myReader[i]);
                        }
                        rs.Add(r);
                    }
                    myReader.Close();
                    return rs;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                s.MyConnection.Close();
            }
        }

        public int RunAffectedRows(string command)
        {
            SQLConnection s = new SQLConnection(myCredentials);
            try
            {
                s.MyConnection.Open();
                SqlCommand myCommand = new SqlCommand(command, s.MyConnection);
                return myCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                s.MyConnection.Close();
            }
        }

        public void SaveFlags()
        {
            Recordset rs = Run("exec sp_flags");
            foreach (Record r in rs.Records)
            {
                Byte[] b = (Byte[])r[0];
                string path = r[1].ToString() + ".bmp";
                FileStream f = File.Create(path);
                f.Write(b, 0, b.Length);
            }
        }
    }
}
