using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uphill;
using System.Collections.Generic;
using System.Linq;
namespace UphillUnitTest
{
    [TestClass]
    public class WordSplitTest
    {
        [TestMethod]
        public void WordSplitSimpleTest()
        {
        

            HashSet<string> words = new HashSet<string>();
            words.Add("A");
            words.Add("AM");
            words.Add("ACE");
            words.Add("I");
            var wordSplit = new WordSplit();
            Console.WriteLine(wordSplit.IsSplitable("IAMACE".ToCharArray().ToList(), words));


        }
    }
}
