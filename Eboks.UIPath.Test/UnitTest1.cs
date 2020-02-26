using System;
using System.Collections.Generic;
using System.Linq;
using Eboks.UIPath.Lib.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Eboks.UIPath.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<Entry> entriesCum = new List<Entry>()
            {
                new Entry() { EntryDate = DateTime.Now, Description = null, Amount = 0},
                new Entry()
            };
            
            entriesCum = entriesCum.Distinct().ToList();
        }
    }
}
