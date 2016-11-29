using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseTest
{
    public class Record
    {
        private List<object> fields = new List<object>();

        public List<object> Fields
        {
            get { return fields; }
        }
    }

    public class Recordset
    {
        private List<Record> records = new List<Record>();

        public List<Record> Records
        {
            get { return records; }
        }
    }
}
