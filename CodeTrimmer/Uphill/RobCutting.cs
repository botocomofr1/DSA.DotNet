using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uphill
{
 
    public class RobCutting
    {
        private List<int> robLengthPrice = new List<int>();
        private Dictionary<int, int> robLengthPriceDict = new Dictionary<int, int>();
        public RobCutting() { }

        public int CalHighestPrice(int roblenght, List<int> robLengthPrice)
        {
            if (roblenght <= 0)
                return 0;
            this.robLengthPrice = robLengthPrice;
            robLengthPriceDict = new Dictionary<int, int>();
            robLengthPriceDict.Add(0, 0);
            return Calculate(roblenght);
        }

        protected int Calculate(int robLength)
        {
            if (robLengthPriceDict.Keys.Contains(robLength))
                return robLengthPriceDict[robLength];
            int maxPrice = 0;
            for(int len=1;len<= robLength&& len < robLengthPrice.Count;len++)
            {
                if (len <= robLength)
                {
                    int thisPrice = Calculate(robLength-len) + robLengthPrice[len];
                    maxPrice = Math.Max(thisPrice, maxPrice);
                }

            }
            robLengthPriceDict[robLength] = maxPrice;

            return maxPrice;
        }
        
    }
}
