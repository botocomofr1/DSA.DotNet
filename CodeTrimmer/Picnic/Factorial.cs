using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picnic
{
    public class Fibonacci 
    {
        private Dictionary<int, int> mem = new Dictionary<int, int>();
        public Fibonacci ()
        {
            mem.Add(0, 0);
            mem.Add(1, 1);

        }

        // If n is 1 return 1
        // else Fab(n) + Fab(n-1)

        public int Calculate(int n)
        {
            if (mem.Keys.Contains(n))
                return mem[n];
            else
            {
                int fab = Calculate(n - 1) + Calculate(n - 2);
                mem.Add(n, fab);
                return fab;
            }
        }
    }
}
