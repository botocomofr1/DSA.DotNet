using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uphill;

namespace UphillUnitTest
{
    [TestClass]
    public class EditDistanceTest
    {
        [TestMethod]
        public void SimpleTest()
        {
            var editDist = new EditDistance();



            Console.WriteLine("1,"+ editDist.CalculateDistance(string.Empty, string.Empty));
            Console.WriteLine("2," + editDist.CalculateDistance("knitten", string.Empty));
            Console.WriteLine("3," + editDist.CalculateDistance(string.Empty, "knitting"));
            Console.WriteLine("4," + editDist.CalculateDistance("knitten", "knitting"));
            Console.WriteLine("5," + editDist.CalculateDistance("yahoo", "google"));
            Console.WriteLine("6," + editDist.CalculateDistance("coti", "cat"));
            Console.WriteLine("7," + editDist.CalculateDistance("alpha", "beta"));
            Console.WriteLine("8," + editDist.CalculateDistance("beta", "pedal"));
            Console.WriteLine("9," + editDist.CalculateDistance("cat", "cut"));
            Console.WriteLine("10," + editDist.CalculateDistance("sunday", "saturday"));
            Console.WriteLine("11," + editDist.CalculateDistance("geek", "gesek"));
        }
    }
}
