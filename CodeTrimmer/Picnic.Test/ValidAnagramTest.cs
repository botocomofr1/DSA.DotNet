using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Picnic.Test
{
    [TestClass]
    public class SanityTest
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
    }
}
