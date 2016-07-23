using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uphill;
namespace UphillUnitTest
{
    [TestClass]
    public class MaxHistArea1Test
    {
        [TestMethod]
        public void MaxAreaSimpleTest()
        {
            var maxArea = new MaximunAreaofHistogram();
            Console.WriteLine(maxArea.MaxArea(new List<int>() { 6, 2, 5, 4, 5, 1, 6 }));
        }
    }
}
