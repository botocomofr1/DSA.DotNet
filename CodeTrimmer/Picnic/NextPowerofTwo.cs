using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picnic
{
    public class NextPowerofTwo
    {
        public NextPowerofTwo() { }

        public int Compute(int i)
        {
            if (i <= 0)
                return 0;

            if ((i & i - 1) == 0)
                return i * 2;

            int result = 1;
            int temp = i;
            while (temp > 0)
            {
                temp = temp >> 1;
                result = result << 1;
            }
            return result;

        }
    }
}
