﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uphill;
namespace UphillUnitTest
{
    /// <summary>
    /// Summary description for MaxHistAreaTest
    /// </summary>
    [TestClass]
    public class MaxHistAreaTest
    {
     

        [TestMethod]
        public void MaxHistAreaSimpleTest()
        {
            var maxHistArea = new MaxAreaHistogram();
            List<int> hist = new List<int>() { 6,2,5,4,5,1,6};
            Console.WriteLine(maxHistArea.MaxArea(hist));
            Console.WriteLine(maxHistArea.MaxArea(new List<int>() { 6,2,50}));
            Console.WriteLine(maxHistArea.MaxArea(new List<int>() { 1, 2, 3 }));
            Console.WriteLine(maxHistArea.MaxArea(new List<int>() { 3, 2, 1 }));
            Console.WriteLine(maxHistArea.MaxArea(new List<int>() { 3 }));
        }
    }
}