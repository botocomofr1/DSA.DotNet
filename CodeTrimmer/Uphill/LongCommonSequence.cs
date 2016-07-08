using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uphill
{
    public class LongCommonSequence
    {
        public LongCommonSequence() { }

        private Dictionary<Tuple<int, int>, int> longestCommon = new Dictionary<Tuple<int, int>, int>();
        public int FindLongest(string s, string t)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
                return 0;
            longestCommon = new Dictionary<Tuple<int, int>, int>();
            longestCommon.Add(new Tuple<int, int>(0, 0), 0);
            int longest = FindLongest(s.ToCharArray(), s.Length, t.ToCharArray(), t.Length);

            return longest;
        }

        public int FindLongest(char[] s, int m, char[] t, int n)
        {
            if (m < 1 || n < 1)
                return 0;
            var key = new Tuple<int, int>(m, n);
            if (longestCommon.Keys.Contains(key))
                return longestCommon[key];
            int max = 0;
            if (Char.ToUpperInvariant(s[m-1]) == Char.ToUpperInvariant(t[n-1]))
            {
                max = FindLongest(s, m - 1, t, n - 1) + 1;
            }
            else
            {
                int a = FindLongest(s, m - 1, t, n);
                int b = FindLongest(s, m, t, n - 1);
                max = Math.Max(a, b);
            }
            longestCommon[key] = max;
            return max;

        }
    }
}
