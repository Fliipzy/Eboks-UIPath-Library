using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eboks.UIPath.Lib.Models;

namespace Eboks.UIPath.Lib.Utilities
{
    public static class EntryHelper
    {
        /// <summary>
        /// Retrieves a list of all entries that falls in-between the two given dates.
        /// </summary>
        /// <param name="from">The start date.</param>
        /// <param name="too">The end date.</param>
        /// <param name="entryList">The original list of entries.</param>
        public static List<Entry> EntriesBetween(DateTime from, DateTime too, List<Entry> entryList)
        {
            return entryList.FindAll(e => e.EntryDate.Ticks >= from.Ticks && e.EntryDate.Ticks <= too.Ticks);
        }
    }
}
