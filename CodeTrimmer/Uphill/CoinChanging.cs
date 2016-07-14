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

        private Dictionary<int ,int> lastUsedCoin = new Dictionary<int, int>();
        private List<int> possibleCoins = new List<int>();
        public CoinChanging()
        {
            minCentsCoinNumber = new Dictionary<int, int>();
            minCentsCoinNumber.Add(0, 0);

            lastUsedCoin = new Dictionary<int, int>();
            lastUsedCoin.Add( 0, 0);
        }

        public int MinNumberOfCoins(int cents, List<int> possibleCoins)
        {
            if (cents == 0)
                return 0;
    

            this.possibleCoins = possibleCoins;
            int result = Calculate(cents);
   
            //foreach(var key in lastUsedCoin.Keys)
            //{
            //    Console.WriteLine(string.Format("Cent {0} Coin {1}", key, lastUsedCoin[key]));
            //}
            return result;
        }

        protected int Calculate(int cents)
        {

            if (minCentsCoinNumber.ContainsKey(cents))
                return minCentsCoinNumber[cents];

            int minCoins = Int32.MaxValue;
            foreach (var coinValue in possibleCoins)
            {

                if (cents >= coinValue)
                {
                    int tmp = Calculate(cents - coinValue) + 1;
                   
                    if (tmp < minCoins)
                        lastUsedCoin[cents] = coinValue;
                    minCoins = Math.Min(minCoins, tmp);
                    
                    
                }


            }

            minCentsCoinNumber[cents] = minCoins;
            return minCoins;

        }
    }
}
