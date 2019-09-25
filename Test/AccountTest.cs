using System;
using Eboks.UIPath.Lib.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void TestLedgersNullException()
        {
            Account account = new Account();
            account.Entries.Add(new Entry());
        }
    }
}
