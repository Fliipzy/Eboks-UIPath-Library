using Eboks.UIPath.Lib.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eboks.UIPath.Lib.Utilities;

namespace eBoks.UIPath.Test
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void TestUtilityMethods()
        {
            Account account = new Account();
            account.Entries.Add( new Entry() { EntryDate = new DateTime(1993, 1, 11), Amount = 50 } );
            account.Entries.Add(new Entry() { EntryDate = new DateTime(1994, 4, 22), Amount = 10 });
            account.Entries.Add( new Entry() { EntryDate = new DateTime(1994, 5, 6), Amount = 25 });
            account.Entries.Add(new Entry() { EntryDate = new DateTime(1994, 12, 8), Amount = 15 });
            account.Entries.Add(new Entry() { EntryDate = new DateTime(2000, 7, 13), Amount = 0 });

            double sum = account.GetEntriesAmountSum();

            Assert.AreEqual(100, sum);

            var entryList = account.GetEntriesBetween(new DateTime(1994, 4, 1), new DateTime(2001, 1, 1));

            Assert.AreEqual(4, entryList.Count);

            foreach (var item in entryList)
            {
                Console.WriteLine(item.EntryDate.ToString("yyyy/MM/dd"));
            }
        }
    }
}
