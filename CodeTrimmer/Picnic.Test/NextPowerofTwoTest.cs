using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Picnic.Test
{
    [TestClass]
    public class NextPowerofTwoTest
    {
        [TestMethod]
        public void ComputeNextPowerofTwoTest()
        {
            var nextPowerofTwo = new NextPowerofTwo();
            
            Console.WriteLine(nextPowerofTwo.Compute(7));
            Console.WriteLine(nextPowerofTwo.Compute(8));
            Console.WriteLine(nextPowerofTwo.Compute(5));
        }
    }
}
