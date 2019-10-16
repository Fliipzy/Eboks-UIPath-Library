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
        public string No_ { get; set; }

        public string Name { get; set; }

        public double OpenLineSalesTotal { get { return Lines.FindAll(x => x.Open).Sum(x => x.Sales); } }

        public List<Line> Lines { get; set; } = new List<Line>();

        public Debitor() {}

        public Debitor(string no_, string name)
        {
            No_ = no_;
            Name = name;       
        }

        public double GetMedian()
        {
            //double result = 0;
            List<double> payBackPeriod = new List<double>();
            foreach (Line l in Lines)
            {
                if (!l.Open)
                {
                    double paymentDays = TimeSpan.FromTicks(l.ClosedAtDate.Ticks).TotalDays - TimeSpan.FromTicks(l.DueDate.Ticks).TotalDays;
                    payBackPeriod.Add(paymentDays);
                }
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
            //return result;
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
