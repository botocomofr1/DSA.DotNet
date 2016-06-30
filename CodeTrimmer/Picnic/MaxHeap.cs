using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picnic
{
    public class MaxHeap
    {
        private List<int> heapValueList = new List<int>();

        public MaxHeap()
        {

            heapValueList.Insert(0, int.MaxValue);
        }

        public int Size()
        {
            return heapValueList.Count();
        }

        public int GetMax()
        {
            if (heapValueList.Count >= 1)
            {
                int value = heapValueList[1];

                int lastIndex = heapValueList.Count - 1;
                heapValueList[1] = heapValueList[lastIndex];
                heapValueList.RemoveAt(lastIndex);
                return value;
            }
            else
                throw new Exception("Empty Heap");
        }


        public void Insert(int value)
        {
            heapValueList.Add(value);
            Heapify();
        }

        // Start from bottom and move largest upward
        protected void Heapify()
        {
            int parentIndex = heapValueList.Count / 2;
            int currentIndex = heapValueList.Count - 1;
            while (parentIndex >= 1)
            {
                if (heapValueList[currentIndex] > heapValueList[parentIndex])
                {
                    int tmp = heapValueList[parentIndex];
                    heapValueList[parentIndex] = heapValueList[currentIndex];
                    heapValueList[currentIndex] = tmp;
                }
                currentIndex = parentIndex;
                parentIndex = currentIndex;
            }
        }

    }
}
