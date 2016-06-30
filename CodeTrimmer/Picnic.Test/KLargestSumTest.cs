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
            List<int> listOfElt = new List<int>() { 100,1,100,100,
                1, 3,4,5,1,2,4,100,100,100,100,100,3,5,100,6,2,1,100 };
            LargestSumOfK largestSum = new LargestSumOfK();

            int sum = largestSum.Find(listOfElt, 9);
            Console.WriteLine(sum);
        }
    }
}
