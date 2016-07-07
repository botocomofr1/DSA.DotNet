using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uphill
{
    public class EditDistance
    {
        private int CopyOperation = 0;
        private int InsertOperation = 1;
        private int SubOperation = 1;
        private int DeleteOperation = 1;
        private Dictionary<Tuple<int, int>, int> editDict 
            = new Dictionary<Tuple<int, int>, int>();
        public EditDistance() { }

        
        public int CalculateDistance(string s, string t)
        {
            if (s.Length ==0 && t.Length==0)
                return 0;
            editDict = new Dictionary<Tuple<int, int>, int>();
            editDict.Add(new Tuple<int, int>(0, 0), 0);
            
            return EditDist(s.ToCharArray(),
                t.ToCharArray(),s.Length, t.Length);
        }

        private int EditDist(char[] s, char[] t, int m, int n)
        {

            if (m == 0 && n == 0)
                return 0;
            var key = new Tuple<int, int>(m, n);

            if (editDict.Keys.Contains(key))
                return editDict[key];
            int a = Int32.MaxValue;
            int b = Int32.MaxValue;
            int c = Int32.MaxValue;
            if (m > 0)
            {
                a = EditDist(s, t, m - 1, n) + DeleteOperation;
            }
            if (n > 0)
            {
                b = EditDist(s, t, m, n - 1) + InsertOperation;
            }
            if (m>0 && n>0)
            {

                if (char.ToUpperInvariant(s[m-1 ]) == char.ToUpperInvariant((t[n-1 ])))
                    c = EditDist(s, t, m - 1, n - 1) + CopyOperation;
                else
                    c = EditDist(s, t, m - 1, n - 1) + SubOperation;
            }
            int min = Math.Min(Math.Min(a, b), c);
            editDict.Add(new Tuple<int, int>(m, n), min);
            return min;

        }

    }
}
