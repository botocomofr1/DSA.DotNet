using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uphill;
using System.Collections.Generic;

namespace UphillUnitTest
{
    [TestClass]
    public class KnasackTest
    {
        [TestMethod]
        public void KnasakSimpleTest()
        {
            List<KnasackItem> items = new List<KnasackItem>();
            items.Add(new KnasackItem { Value = 10, Weight = 5 });
            items.Add(new KnasackItem { Value = 40, Weight = 4 });
            items.Add(new KnasackItem { Value = 30, Weight = 6 });
            items.Add(new KnasackItem { Value = 50, Weight = 3 });
            KnasackBestValue knasackSolver = new KnasackBestValue();
            Console.WriteLine(knasackSolver.BestDeal(10, items));

        }
    }
}
