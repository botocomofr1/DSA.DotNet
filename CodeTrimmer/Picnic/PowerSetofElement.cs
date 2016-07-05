using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picnic
{
    public class PowerSetofElement
    {
        public PowerSetofElement() { }

        public void PrintThePowerSet(List<int> elt)
        {
            int len = elt.Count;
            if (len <= 0)
                Console.WriteLine("Empty");
            var combinations = Convert.ToInt32(Math.Pow(2, len));

            for(int i = 1; i <= combinations; i++)
            {
                List<int> thisCombination = new List<int>();
                int eltPos = 1;
                for(int count = 0;count< elt.Count; count++)
                {
                    if ((eltPos & i) > 0)
                    {
                        thisCombination.Add(elt[count]);
                    }
                    eltPos = eltPos << 1;
                }
                Console.WriteLine(string.Join(",", thisCombination));

            }


        }
    }
}
