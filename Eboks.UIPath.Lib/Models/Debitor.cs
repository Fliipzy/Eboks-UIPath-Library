using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eboks.UIPath.Lib.Models
{
    public class Debitor : IEquatable<Debitor>, IEnumerable<Line>
    {
        private const double AVERAGE_PAYBACK_DAYS = 2;

        public string No_ { get; set; }

        public string Name { get; set; }

        public double OpenLineSalesTotal { get { return Lines.FindAll(x => x.Open).Sum(x => x.VatCode == "INDLAND" ? x.Sales * 1.25 : x.Sales); } }

        public List<Line> Lines { get; set; } = new List<Line>();

        public Debitor() {}

        public Debitor(string no_, string name)
        {
            No_ = no_;
            Name = name;       
        }

        public double GetMedian()
        {
            List<double> payBackPeriod = new List<double>();

            //Foreach line in lines where line is not open
            foreach (Line l in Lines.Where(l => !l.Open && l.DocumentType == "2"))
            {
                double paymentDays = TimeSpan.FromTicks(l.ClosedAtDate.Ticks).TotalDays - TimeSpan.FromTicks(l.DueDate.Ticks).TotalDays;
                payBackPeriod.Add(paymentDays);
            }

            //If empty
            if (!payBackPeriod.Any())
            {
                return AVERAGE_PAYBACK_DAYS;
            }
            
            payBackPeriod.Sort();

            if (payBackPeriod.Count % 2 == 0)
            {
                
                return payBackPeriod[((payBackPeriod.Count / 2)-1)]; 
            }
            else
            {
                return payBackPeriod[(payBackPeriod.Count / 2)];
            }
        }

        public IEnumerator<Line> GetEnumerator()
        {
            for (int i = 0; i < Lines.Count; i++)
            {
                yield return Lines[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            return string.Format("[Debitor (No_: {0}, Name: {1})]", No_, Name);
        }

        public bool Equals(Debitor other)
        {
            if (other == null)
            {
                return false;
            }
            return No_ == other.No_ && Name == other.Name;
        }
    }
}
