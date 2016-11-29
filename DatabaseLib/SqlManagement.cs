using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Linq;
using System.Text;

namespace DatabaseLib
{
    public class SqlManagement
    {
        public SqlManagement()
        {
            DataTable dt = SqlDataSourceEnumerator.Instance.GetDataSources();
        }
        
    }
}
