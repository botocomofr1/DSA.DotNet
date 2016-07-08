using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UphillUnitTest
{
    public class CoinChanging
    {
        private Dictionary<int, int> minCentsCoinNumber = new Dictionary<int, int>();
        private List<int> possibleCoins = new List<int>();
        public CoinChanging() { }

        public int MinNumberOfCoins(int cents, List<int> possibleCoins)
        {
            if (cents == 0)
                return 0;
            minCentsCoinNumber = new Dictionary<int, int>();
            minCentsCoinNumber.Add(0, 0);
            this.possibleCoins = possibleCoins;
            return Calculate(cents);
        }

        protected int Calculate(int cents)
        {
          
            if (minCentsCoinNumber.Keys.Contains(cents))
                return minCentsCoinNumber[cents];

            int minCoins = Int32.MaxValue;
            foreach(var coinValue in possibleCoins)
            {
                if (cents >= coinValue)
                {
                    int tmp = Calculate(cents - coinValue) + 1;
                    minCoins = Math.Min(minCoins, tmp);
                }

            }
            minCentsCoinNumber[cents] = minCoins;
            return minCoins;

        }
    }
}
