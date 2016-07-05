using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Linq;
namespace Unleisure
{
    public class IpAddressRange
    {
        IDictionary<int, string> sortedIP = new Dictionary<int, string>();
        public IpAddressRange() { }

        public void AddIp(string ip)
        {
            if (!IsVaid(ip))
                throw new Exception("Not valid IP");
            string[] ip4parts = ip.Split('.');

            int ipInInteger = 0;
            for (int i = 0; i < ip4parts.Length; i++)
            {
                int eachPartInInteger = Convert.ToInt32(ip4parts[i]);
                if (eachPartInInteger > 255 || eachPartInInteger < 0)
                    throw new Exception("Not Valid IP");
                int shiftBits = ((ip4parts.Length - 1) - i) * 8;
                eachPartInInteger = eachPartInInteger << shiftBits;
                ipInInteger += eachPartInInteger;
            }
            sortedIP.Add(ipInInteger, ip);


        }

        public List<string> GetIpRange(int min , int max)
        {
            var ipRange = sortedIP.Where(x => x.Key >= min && x.Key <=max).Select(y=>y.Value);
            return ipRange.ToList<string>();

        }
        public bool IsVaid(string ip)
        {
            if (string.IsNullOrEmpty(ip))
                return false;
            string ipAddressP = @"\b(?:\d{1,3}\.){3}\d{1,3}\b";
            Regex regExp = new Regex(ipAddressP);
            return regExp.IsMatch(ip);

        }
    }
}
