using System;
using System.Collections.Generic;
using Eboks.UIPath.Lib.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class EntryTest
    {
        [TestMethod]
        public void TestForeachIteration()
        {
            List<Entry> entries = new List<Entry>()
            {
                new Entry(),
                new Entry()
            };

            foreach (Entry entry in entries)
            {
                Assert.IsNotNull(entry);
            }
        }
    }
}
