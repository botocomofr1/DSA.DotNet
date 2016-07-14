using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unleisure;

namespace UnlesisureUnitTest
{
    [TestClass]
    public class IpRanageTest
    {
        [TestMethod]
        public void SimpleIPRangeTest()
        {
            var ipRange = new IpAddressRange();
            Console.WriteLine(ipRange.IsVaid("255.255.225.222"));
            Console.WriteLine(ipRange.IsVaid("1.1.1.1"));
            ipRange.AddIp("0.0.0.1");
            ipRange.AddIp("0.0.1.0");
            ipRange.AddIp("0.1.0.0");
            ipRange.AddIp("1.0.0.0");
            Console.WriteLine(string.Join(",",
            ipRange.GetIpRange(1, Convert.ToInt32(Math.Pow(2, 24)) + 1)));

 

        }
    }
}
