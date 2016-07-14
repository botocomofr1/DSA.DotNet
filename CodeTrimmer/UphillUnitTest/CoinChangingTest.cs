using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UphillUnitTest
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class CoinChangingTest
    {
   



        [TestMethod]
        public void CoinChangingSimpleTest()
        {
            List<int> possibleCoins = new List<int>() { 1, 5, 12, 25 };
            var coinChanging = new CoinChanging();
            //Console.WriteLine(string.Format("Cents {0} Min Coins {1}",
            //       12, coinChanging.MinNumberOfCoins(12, possibleCoins)));
            for (int cents = 0; cents <= 12; cents++)
            {
                Console.WriteLine(string.Format("Cents {0} Min Coins {1}",
                    cents, coinChanging.MinNumberOfCoins(cents, possibleCoins)));

            }

        }
    }
}
