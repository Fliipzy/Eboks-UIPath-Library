using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Eboks.UIPath.Lib.Models
{
    public class Line : IEquatable<Line>
    {
        public string EntryNo { get; set; }

        public string CustomerNo { get; set; }

        public DateTime PostingDate { get; set; }

        public string DocumentType { get; set; }

        public string DocumentNo { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime ClosedAtDate { get; set; }

        public int Sales { get; set; }

        public bool Open { get; set; }

        public Line()
        {
        }

        public Line(string entryNo, string customerNo, DateTime postingDate, string documentType, string documentNo, DateTime dueDate, DateTime closedAtDate, int sales, bool open)
        {
            EntryNo = entryNo;
            CustomerNo = customerNo;
            PostingDate = postingDate;
            DocumentType = documentType;
            DocumentNo = documentNo;
            DueDate = dueDate;
            ClosedAtDate = closedAtDate;
            Sales = sales;
            Open = open;
        }

        public bool Equals(Line other)
        {
            if (other == null )
            {
                return false;
            }

            return EntryNo == other.EntryNo && CustomerNo == other.CustomerNo;
        }

        public override string ToString()
        {
            return string.Format("[Line (EntryNo: {0}, CustomerNo: {1})]", EntryNo, CustomerNo);
        }
    }
}