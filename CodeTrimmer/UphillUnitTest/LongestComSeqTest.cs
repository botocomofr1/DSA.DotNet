using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uphill;

namespace UphillUnitTest
{
    [TestClass]
    public class LongestComSeqTest
    {
        [TestMethod]
        public void LongestComSeqSimpleTest()
        {
            var s = "ABAZDC";
            var t = "BACBAD";
            var longest = new LongCommonSequence();
            Console.WriteLine(longest.FindLongest(s, t));

        }
    }
}
