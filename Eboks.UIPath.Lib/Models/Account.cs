using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eboks.UIPath.Lib.Models
{
    public class Account : IEquatable<Account>
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

        public bool Equals(Account other)
        {
            if (other == null || GetType() != other.GetType())
            {
                return false;
            }
            return Name.Equals(other.Name) && Number.Equals(other.Number);
        }
    }
}
