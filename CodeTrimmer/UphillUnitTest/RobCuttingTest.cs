using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Uphill;

namespace UphillUnitTest
{
    [TestClass]
    public class RobCuttingTest
    {
        [TestMethod]
        public void RobCuttingSimpleTest()
        {
            List<int> lenghtPrice = new List<int>()
            { 0,2,3,6,7,10,12};
            var robCut = new RobCutting();
            for(int l = 0; l < lenghtPrice.Count; l++)
            {
                Console.WriteLine(
                    string.Format("Length:{0}  Higest Price{1}",
                        l, robCut.CalHighestPrice(l, lenghtPrice)));

            }
      

        }
    }
}
