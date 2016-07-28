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
            List<int> stockPricesYesterday = new List<int>() { 10, 7, 5, 8, 11, 9 };
            Console.WriteLine(appleTrade.BestTrade(stockPricesYesterday));
        }
    }
}
