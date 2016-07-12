using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uphill
{
    public class LongestPalindromic
    {
        Dictionary<Tuple<int, int>, int> longestPali = new Dictionary<Tuple<int, int>, int>();
        public LongestPalindromic() { }

        public int Calculate(List<char> arrayofChar)
        {
            if (arrayofChar.Count <= 1)
                return 0;

            longestPali = new Dictionary<Tuple<int, int>, int>();

            var result =Calculate(arrayofChar, 0, arrayofChar.Count - 1);
            printResult(arrayofChar,0,5);
            return result;
        }
        
        protected void printResult(List<char> arrayofChar, int i, int j)
        {

            //if (arrayofChar.Count > i || j < 0)
            //    return;
            //if (i == j)
            //    Console.WriteLine(arrayofChar[j]);
            //else {
            //    printResult(arrayofChar, i + 1, j - 1);
               
            //}

        }

        protected int Calculate(List<char> arrayofChar, int i, int j)
        {
            if (i >= j)
                return 0;

            var key = new Tuple<int, int>(i, j);
            if (longestPali.Keys.Contains(key))
                return longestPali[key];

            int a = Calculate(arrayofChar, i + 1, j);
            int b = Calculate(arrayofChar, i, j - 1);

            int max = Math.Max(a, b);

            if (Char.ToUpperInvariant(arrayofChar[i]) == Char.ToUpperInvariant(arrayofChar[j]))
            {
                max = max + 2;
            }
            longestPali.Add(new Tuple<int, int>(i, j), max);
            return max;

        }
    }
}
