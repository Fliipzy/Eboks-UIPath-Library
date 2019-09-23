using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eboks.UIPath.Lib.Models
{
    class Company
    {
        private string name;
        private string number;

        public string Name { get => name; set => name = value; }
        public string Number { get => number; set => number = value; }

        public Company(){}

        public override string ToString()
        {
            return $"{name}, {number}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Company c = (Company)obj;
            return name.Equals(c.name) && number.Equals(c.number);
        }

    }
}
