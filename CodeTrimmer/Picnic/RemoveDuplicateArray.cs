using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picnic
{
    public class RemoveDuplicateArray
    {
        public RemoveDuplicateArray() { }

        public int Remove(ref int[] array)
        {
            List<int> result = new List<int>();
            int i = 0;
            int j = 1;
            if (array.Length > 1)
            {
                for (; j < array.Length; j++)
                {
                    if (array[i] != array[j])
                    {
                        array[i + 1] = array[j];
                        i++;

                    }
                }

            }
       
            return i;
        }
    }
}
