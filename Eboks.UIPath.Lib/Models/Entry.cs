using Eboks.UIPath.Lib.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Eboks.UIPath.Lib.Models
{
    public class Entry : IEquatable<Entry>
    {
        public DateTime EntryDate { get; set; }

        public string AttachmentType { get; set; }

        public string AttachmentNumber { get; set; }

        public string GeneralLedgerNumber { get; set; }

        public string Description { get; set; }

        public string CompanyEntryGroup { get; set; }

        public string ProductEntryGroup { get; set; }

        public double Amount { get; set; }

        public string DepartmentCode { get; set; }

        public string CountryCode { get; set; }

        public string ActivitiesCode { get; set; }

        public double VatAmount { get; set; }

        public Boolean Forecast { get; set; } = false;

        public Entry() 
        {
        }

        public bool Equals(Entry other)
        {
            if (other == null || GetType() != other.GetType())
            {
                return false;
            }
            return EntryDate.Equals(other.EntryDate) && 
                    Amount.Equals(other.Amount) && 
                    AttachmentNumber.Equals(other.AttachmentNumber) &&
                    Description.Equals(other.Description);
        }

        public override int GetHashCode()
        {
            return (EntryDate.ToString() + Amount.ToString() + AttachmentNumber + Description).GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("[Entry (LedgerNumber: {0}, EntryDate: {1})]", GeneralLedgerNumber, EntryDate);
        }
    }
}
