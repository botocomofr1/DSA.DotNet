using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picnic
{
    public class MinHeap
    {
        private List<int> heapValueList = new List<int>();

        public MinHeap()
        {

            heapValueList.Insert(0, int.MaxValue);
        }

        public int GetMin()
        {
            if (heapValueList.Count >= 1)
            {
                int value = heapValueList[1];

                Delete(value);
                Heapify();
                return value;
            }
            else
                throw new Exception("Empty Heap");
        }

        public void Delete(int value)
        {
            if (heapValueList.Count >= 1)
            {
                int index = heapValueList.IndexOf(value);
                int last = heapValueList.Count - 1;
                heapValueList[index] = heapValueList[last];
                heapValueList.Remove(last);
                Heapify();
            }
            else
            {
                throw new Exception("Empty Heap");
            }
        }

        public void Insert(int value)
        {
            heapValueList.Add(value);
            Heapify();
        }
        // Start from bottom and move the smallest upward
        protected void Heapify()
        {
            int parentIndex = heapValueList.Count / 2;
            int childIndex = heapValueList.Count - 1;
            while (parentIndex >= 1)
            {
                if (heapValueList[childIndex] < heapValueList[parentIndex])
                {
                    int tmp = heapValueList[parentIndex];
                    heapValueList[parentIndex] = heapValueList[childIndex];
                    heapValueList[childIndex] = tmp;
                }
                childIndex = parentIndex;
                parentIndex = childIndex;
            }

        }

    }
}
