using Eboks.UIPath.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eboks.UIPath.Lib.Utilities
{
    public static class AccountHelper
    {
        public static double GetEntriesAmountSum(this Account account)
        {
            return account.Entries.Sum(e => e.Amount);
        }

        public static List<Entry> GetEntriesBetween(this Account account, DateTime from, DateTime to)
        {
            return account.Entries.FindAll(e => e.EntryDate.Ticks >= from.Ticks && e.EntryDate.Ticks <= to.Ticks);
        }
    }
}
