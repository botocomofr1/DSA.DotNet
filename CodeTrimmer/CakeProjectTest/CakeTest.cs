using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CakeProject;
namespace CakeProjectTest
{
    [TestClass]
    public class CakeTest
    {
        [TestMethod]
        public void AppleTradeTest()
        {
            var appleTrade = new BestAppleTrade();
            List<int> stockPricesYesterday = new List<int>() { 10, 7, 5, 8, 11, 9,9,9 ,1,2,3,4,5,6,7,8,8,8};
            Console.WriteLine(appleTrade.BestTrade(stockPricesYesterday));
        }
    }
}
