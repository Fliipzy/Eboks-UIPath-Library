using System;
using System.Collections.Generic;
using Eboks.UIPath.Lib.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Eboks.UIPath.Test
{
    [TestClass]
    public class DebitorTest
    {
        [TestMethod]
        public void TestEnumerability()
        {
            Debitor d = new Debitor();
            d.Lines.Add(new Line() { EntryNo = "496737", CustomerNo = "eBoks" });
            d.Lines.Add(new Line() { EntryNo = "378572", CustomerNo = "Google" });
            d.Lines.Add(new Line() { EntryNo = "138593", CustomerNo = "Amazon" });
            d.Lines.Add(new Line() { EntryNo = "048337", CustomerNo = "ECorp" });

            foreach (Line line in d)
            {
                Console.WriteLine(line.ToString());
            }
        }

        [TestMethod]
        public void CareFace()
        {
            Debitor d = new Debitor();
            d.Lines.Add(new Line() { Open = true, Sales = 10000, VatCode = "KONCERN" });
            d.Lines.Add(new Line() { Open = true, Sales = 10000, VatCode = "INDLAND" });

            Console.WriteLine(d.OpenLineSalesTotal);
        }

        [TestMethod]
        public void Wqr()
        {
            List<int> ints = new List<int>() { 10, 11, 12, 13, 14, 15, 16};

            if (ints.Count % 2 == 0)
            {
                int p = ints[((ints.Count / 2)-1)];
                Console.WriteLine(p);
            }
            
            else
            {
                int p = ints[(ints.Count / 2)];
                Console.WriteLine(p);
            }
            
           
        }

    }
}
