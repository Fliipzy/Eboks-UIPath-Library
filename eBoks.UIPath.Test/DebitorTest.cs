using System;
using System.Collections.Generic;
using Eboks.UIPath.Lib.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eBoks.UIPath.Test
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
    }
}
