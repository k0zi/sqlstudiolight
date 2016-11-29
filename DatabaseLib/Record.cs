using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseLib
{
    public class Record
    {
        private List<object> fields = new List<object>();

        public object this[int i]
        {
            get
            {
                return fields[i];
            }
        }

        public List<object> Fields
        {
            get
            {
                return fields;
            }
        }
    }

    public class Recordset
    {
        List<Record> records = new List<Record>();
        Dictionary<string, int> names = new Dictionary<string, int>();
        Dictionary<int, string> indexNames = new Dictionary<int, string>();

        public void Add(Record r)
        {
            records.Add(r);
        }

        public void AddName(string name, int position)
        {
            if(!names.ContainsKey(name))
            {
                names.Add(name, position);
            }
            if(!indexNames.ContainsKey(position))
            {
                indexNames.Add(position, name);
            }
        }
        public object this[string s, int i]
        {
            get
            {
                return records[i].Fields[names[s]];
            }
        }
        public string GetName(int i)
        {
            if(indexNames.ContainsKey(i))
            {
                return indexNames[i];
            }
            return "Field" + i;
        }
        public List<Record> Records
        {
            get
            {
                return records;
            }
        }
    }
}
