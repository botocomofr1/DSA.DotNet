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

            heapValueList.Insert(0, int.MinValue);
        }
        public int Size()
        {
            return heapValueList.Count();
        }

        public int Peak()
        {
            if (heapValueList.Count >= 1)
            {
                int value = heapValueList[1];
                return value;
            }
            else
                throw new Exception("Empty Heap");

        }

        public int GetMin()
        {
            if (heapValueList.Count >= 1)
            {
                int value = heapValueList[1];
                int last = heapValueList.Count - 1;
                heapValueList[1] = heapValueList[last];
                heapValueList.RemoveAt(last);
                Heapify();
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
        // Start from bottom and move the smallest upward
        protected void Heapify()
        {

            int childIndex = heapValueList.Count-1;
            
            int parentIndex = Convert.ToInt32(Math.Floor(Convert.ToDouble(childIndex / 2))); 
            while (parentIndex >= 1)
            {
                if (heapValueList[childIndex] < heapValueList[parentIndex])
                {
                    int tmp = heapValueList[parentIndex];
                    heapValueList[parentIndex] = heapValueList[childIndex];
                    heapValueList[childIndex] = tmp;
                    childIndex = parentIndex;
                    parentIndex = Convert.ToInt32(Math.Floor(Convert.ToDouble(childIndex / 2)));
                }
                else
                {
                    childIndex = childIndex - 1;
                    parentIndex = Convert.ToInt32(Math.Floor(Convert.ToDouble(childIndex / 2)));
                }
                
            }

        }

    }
}
