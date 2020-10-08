using System;
using System.Collections.Generic;
using System.Linq;

namespace Tripoint.Test.StockBalance.Utilities
{
    public static class RetrieveKeyCaseInsensitive
    {
       public static string RetrieveKey(string key, Dictionary<string, int> dict)
        {
            var comparer = StringComparison.OrdinalIgnoreCase;
            var retrievedKey = dict.FirstOrDefault(x => String.Equals(x.Key, key, comparer)).Key;
            return retrievedKey;
        }        
    }
}
