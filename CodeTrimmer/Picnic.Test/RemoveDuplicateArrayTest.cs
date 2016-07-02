using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
namespace Picnic.Test
{
    [TestClass]
    public class RemoveDuplicateArrayTest
    {
        [TestMethod]
        public void RemoveDupIntTest()
        {
            var removeDupInt = new RemoveDuplicateArray();
         
            int[] array = new int[] { 1, 1, 1 };
            int i = removeDupInt.Remove(ref array);
            Console.WriteLine(string.Join(",",array.Take(i+1)));
            array = new int[] { 1, 1, 1,2 };
            i = removeDupInt.Remove(ref array);
            Console.WriteLine(string.Join(",", array.Take(i + 1)));
            array = new int[] { 1, 1, 1, 2,2,19 };
            i = removeDupInt.Remove(ref array);
            Console.WriteLine(string.Join(",", array.Take(i + 1)));
        }
    }
}
