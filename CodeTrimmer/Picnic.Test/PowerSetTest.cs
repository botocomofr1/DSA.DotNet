using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Picnic.Test
{
    [TestClass]
    public class PowerSetTest
    {
        [TestMethod]
        public void PowerSetOfEltTest()
        {
            var powerSet = new PowerSetofElement();
            List<int> elts = new List<int>();
            elts.Add(1);
            elts.Add(2);
            elts.Add(3);
            powerSet.PrintThePowerSet(elts);

        }
    }
}
