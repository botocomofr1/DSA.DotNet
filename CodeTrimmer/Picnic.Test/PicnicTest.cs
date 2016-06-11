
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace Picnic.Test
{
    [TestClass]
    public class PicnicTest
    {
        [TestMethod]
        public void ValidAnagramTest()
        {
            var source = "anagram";
            var target = "nagaram";
            var validAnagram = new ValidAnagram();
            var result = validAnagram.IsAnagram(source, target);
            Assert.IsTrue(result,
                string.Format("Failed to perform pos test source: {0} target {1}", source, target));


            source = "rat";
            target = "car";
            validAnagram = new ValidAnagram();
            result = validAnagram.IsAnagram(source, target);
            Assert.IsFalse(result,
                string.Format("Failed to perform neg test source: {0} target {1}", source, target));

        }

        [TestMethod]
        public void FibonacciTest()
        { 
            var fab = new Fibonacci ();
            Assert.AreEqual(0, fab.Calculate(0), "Failed to calcluate Fab 0");
            Assert.AreEqual(1, fab.Calculate(1), "Failed to calcluate Fab 1");
            Assert.AreEqual(55, fab.Calculate(10), "Failed to calcluate Fab 10");
            Assert.AreEqual(6765, fab.Calculate(20), "Failed to calcluate Fab 20");
        }
    }
}
