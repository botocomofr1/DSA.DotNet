using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Picnic.Test
{
    [TestClass]
    public class KLargestSumTest
    {
        [TestMethod]
        public void TenLargestSumTest()
        {
            List<int> listOfElt = new List<int>() { 100,10,100,100,
                9, 3,4,5,1,2,4,100,100,100,100,100,3,5,100,6,2,1,100 };
            LargestSumOfK largestSum = new LargestSumOfK();

            int sum = largestSum.Find(listOfElt, 9);
            Console.WriteLine(sum);
        }

        [TestMethod]
        public void SimpleMinHeapTest()
        {
            List<int> listOfElt = new List<int>() { 100,10,100,100,
                9, 3,4,5,1,2,4,100,100,100,100,100,3,5,100,6,2,1,100};//,10,84,10,6,10,22,10,9 };
            MinHeap minHeap = new MinHeap();
            foreach(var i in listOfElt)
            {
                minHeap.Insert(i);
               
                
            }
            
          
            for(int i = 0; i < listOfElt.Count; i++)
            {
             Console.WriteLine(string.Format("I is {0} min is {1}", i, minHeap.GetMin()));
            }
        }

        [TestMethod]
        public void SimpleMaxHeapTest()
        {
            List<int> listOfElt = new List<int>() { 100,10,100,100,
                9, 3,4,5,1,2,4,100,100,100,100,100,3,5,100,6,2,1,100};//,10,84,10,6,10,22,10,9 };
            MaxHeap maxHeap = new MaxHeap();
            foreach (var i in listOfElt)
            {
                maxHeap.Insert(i);


            }


            for (int i = 0; i < listOfElt.Count; i++)
            {
                Console.WriteLine(string.Format("I is {0} min is {1}", i, maxHeap.GetMax()));
            }
        }

    }
}
