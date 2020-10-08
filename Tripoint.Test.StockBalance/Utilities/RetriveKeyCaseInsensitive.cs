using System;
using System.Collections.Generic;
using System.Linq;

namespace Tripoint.Test.StockBalance.Utilities
{
    public static class RetriveKeyCaseInsensitive
    {
       public static string RetriveKey(string key, Dictionary<string, int> dict)
        {
            var comparer = StringComparison.OrdinalIgnoreCase;
            var retrivedKey = dict.FirstOrDefault(x => String.Equals(x.Key, key, comparer)).Key;
            return retrivedKey;
        }        
    }
}
