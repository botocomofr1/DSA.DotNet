using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uphill;
using System.Collections.Generic;

namespace UphillUnitTest
{
    [TestClass]
    public class LongestPalindromicTest
    {
        [TestMethod]
        public void LongestPalSimpleTest()
        {
            var longestP = new LongestPalindromic();
            List<char> arrayofChar = new List<char>() { 'a', 'g', 'b', 'd', 'b', 'a' };
            Console.WriteLine(longestP.Calculate(arrayofChar));


        }
    }
}
