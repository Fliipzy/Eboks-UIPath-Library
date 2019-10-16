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
            d.Lines.Add(new Line() { Open = false, DueDate = new DateTime(2000, 1, 1), ClosedAtDate = new DateTime(2000, 2, 1) });
            d.Lines.Add(new Line() { Open = false, DueDate = new DateTime(2000, 1, 1), ClosedAtDate = new DateTime(2000, 1, 11) });
            d.Lines.Add(new Line() { Open = false, DueDate = new DateTime(2000, 1, 1), ClosedAtDate = new DateTime(2000, 1, 21) });

            Console.WriteLine(d.GetMedian());
        }

        [TestMethod]
        public void Wqr()
        {
            List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6};

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
