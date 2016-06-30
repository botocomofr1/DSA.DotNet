using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picnic
{
    public class MedianHeap
    {
        private MaxHeap maxHeap = new MaxHeap();
        private MinHeap minHeap = new MinHeap();

        public MedianHeap() { }

        public void Insert(int target)
        {
            if (maxHeap.Size() == 1 && minHeap.Size() == 1)
            {
                minHeap.Insert(target);
            }else if (minHeap.Size() > maxHeap.Size() )
            {
                if (minHeap.GetMin() > target)
                {
                    maxHeap.Insert(target);
                }
                else
                {
                    int value = minHeap.GetMin();
                 
                    maxHeap.Insert(value);
                    minHeap.Insert(target);
                }

            }else if (minHeap.Size() < maxHeap.Size())
            {
                if (maxHeap.GetMax() < target)
                {
                    minHeap.Insert(target);
                }
                else
                {
                    int value = maxHeap.GetMax();
                    minHeap.Insert(value);
                    maxHeap.Insert(target);
                }
            }
            else
            {
                if (maxHeap.GetMax() < target)
                {
                    minHeap.Insert(target);
                }
                else
                {
                    int value = maxHeap.GetMax();

                    minHeap.Insert(value);
                    maxHeap.Insert(target);
                }

            }

            
        }
        
        public int GetMedian()
        {
            if (maxHeap.Size() == 1 && minHeap.Size() == 1)
                throw new Exception("No data");
            else if (maxHeap.Size() == minHeap.Size())
            {
                int a = (maxHeap.GetMax() - minHeap.GetMin()) / 2;
                return a;
            }
            else if (maxHeap.Size() > 1 && minHeap.Size() == 1)
            {
                return maxHeap.GetMax();
            }
            else if (minHeap.Size() > 1 && maxHeap.Size() == 1)
            {
                return minHeap.GetMin();
            }
            else if (minHeap.Size() - maxHeap.Size() == 1)
            {
                return maxHeap.GetMax();
            }
            else if (maxHeap.Size() - minHeap.Size() == 1)
            {
                return minHeap.GetMin();
            }
            else
            {
                throw new Exception("Corrupted Median");
            }

        }
    }
}
