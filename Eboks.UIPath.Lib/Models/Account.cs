using Eboks.UIPath.Lib.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eboks.UIPath.Lib.Models
{
    public class Account : IEquatable<Account>, IEnumerable<Entry>
    {
        public string Number { get; set; }

        public string Name { get; set; }

        public string AccountType { get; set; }

        public string EntryType { get; set; }

        public string CompanyEntryGroup { get; set; }

        public string ProductEntryGroup { get; set; }

        public double NetChange { get; set; }

        public List<Entry> Entries { get; set; } = new List<Entry>();
        
        /// <summary>
        /// Returns the sum of all non-forecast entries.
        /// </summary>
        public double Balance 
        {
            get { return Entries.FindAll(e => !e.Forecast).Sum(e => e.Amount); }
        }

        /// <summary>
        /// Returns the sum of all forecast entries.
        /// </summary>
        public double ForecastBalance
        {
            get { return Entries.FindAll(e => e.Forecast).Sum(e => e.Amount); }
        }

        public Account()
        {
        }

        /// <summary>
        /// Overwritten method, used for debugging purposes.
        /// </summary>
        /// <returns>The name and number property concatenated in a string.</returns>
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

        public IEnumerator<Entry> GetEnumerator()
        {
            for (int i = 0; i < Entries.Count; i++)
            {
                yield return Entries[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
