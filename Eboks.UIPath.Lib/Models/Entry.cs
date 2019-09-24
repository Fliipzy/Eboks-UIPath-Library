using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eboks.UIPath.Lib.Models
{
    class Entry
    {
        public string EntryDate { get; set; }
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

        public Entry()
        {

        }
    }
}
