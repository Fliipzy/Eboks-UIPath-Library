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
        public int No_ { get; set; }

        public string Name { get; set; }

        public List<Line> Lines { get; set; } = new List<Line>();

        public Debitor() {}

        public Debitor(int no_, string name)
        {
            No_ = no_;
            Name = name;
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
