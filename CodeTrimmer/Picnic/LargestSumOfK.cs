using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picnic
{
    public class LargestSumOfK
    {
        public LargestSumOfK() { }

        public int Find (List<int> listOfElt, int kthLargest)
        {
            int sum = 0;
            if (kthLargest > listOfElt.Count)
                return sum;

            MinHeap minHeap = new MinHeap();
            for(int i = 0; i < kthLargest; i++)
            {
                sum = listOfElt[i] + sum;
                minHeap.Insert(listOfElt[i]);
            }
            for(int i = 2; i < listOfElt.Count; i++)
            {
                if (sum-minHeap.Peak() + listOfElt[i] > sum)
                {
                    sum = sum - minHeap.GetMin() + listOfElt[i];
                    minHeap.Insert(listOfElt[i]);

                }

            }
            return sum;
        }
    }
}
