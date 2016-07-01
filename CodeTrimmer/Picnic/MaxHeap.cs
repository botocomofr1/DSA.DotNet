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
                HeapifyDownward();
                return value;
            }
            else
                throw new Exception("Empty Heap");
        }


        public void Insert(int value)
        {
            heapValueList.Add(value);
            HeapifyUpward();
        }

        // Start from bottom and move largest upward
        protected void HeapifyUpward()
        {

            int childIndex = heapValueList.Count - 1;

            int parentIndex = childIndex / 2;
            while (parentIndex >= 1 && heapValueList[parentIndex] < heapValueList[childIndex])
            {
                int tmp = heapValueList[parentIndex];
                heapValueList[parentIndex] = heapValueList[childIndex];
                heapValueList[childIndex] = tmp;
                childIndex = parentIndex;
                parentIndex = childIndex / 2;

            }
        }


        protected void HeapifyDownward()
        {

            int parentIndex = 1;
            int leftChild = parentIndex * 2;
            int rightChild = leftChild + 1;
            bool stop = false;
            while (!stop)
            {

                int selectedIndex = 0;
                if (rightChild >= heapValueList.Count)
                {
                    if (leftChild >= heapValueList.Count)
                    {
                        stop = true;
                    }
                    else
                    {
                        selectedIndex = leftChild;
                    }

                }
                else
                {
                    if (heapValueList[leftChild] > heapValueList[rightChild])
                    {
                        selectedIndex = leftChild;
                    }
                    else
                    {
                        selectedIndex = rightChild;
                    }

                }
                if (!stop && heapValueList[selectedIndex] > heapValueList[parentIndex])
                {
                    int tmp = heapValueList[parentIndex];
                    heapValueList[parentIndex] = heapValueList[selectedIndex];
                    heapValueList[selectedIndex] = tmp;
                    parentIndex = selectedIndex;
                    leftChild = parentIndex * 2;
                    rightChild = leftChild + 1;
                }
                else
                {
                    stop = true;
                }



            }

        }

    }


}
