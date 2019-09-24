using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eboks.UIPath.Lib.Models
{
    class Account
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public string AccountType { get; set; }
        public string EntryType { get; set; }
        public string CompanyEntryGroup { get; set; }
        public string ProductEntryGroup { get; set; }
        public double NetChange { get; set; }
        public double Balance { get; set; }
        public List<Entry> Entries { get; }

        public Account(){}

        public override string ToString()
        {
            return $"{Name}, {Number}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Account c = (Account)obj;
            return Name.Equals(c.Name) && Number.Equals(c.Number);
        }

    }
}
