﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UphillUnitTest
{
    public class CoinChanging
    {
        private Dictionary<int, int> minCentsCoinNumber = new Dictionary<int, int>();

        private Dictionary<Tuple<int, int>, int> lastUsedCoin = new Dictionary<Tuple<int, int>, int>();
        private List<int> possibleCoins = new List<int>();
        public CoinChanging()
        {
            minCentsCoinNumber = new Dictionary<int, int>();
            minCentsCoinNumber.Add(0, 0);

            lastUsedCoin = new Dictionary<Tuple<int, int>, int>();
            lastUsedCoin.Add(new Tuple<int, int>(0, 0), 0);
        }

        public int MinNumberOfCoins(int cents, List<int> possibleCoins)
        {
            if (cents == 0)
                return 0;
    

            this.possibleCoins = possibleCoins;
            int result = Calculate(cents);
            //foreach (var key in minCentsCoinNumber1.Keys)
            //{
            //    Console.WriteLine(string.Format("{0} Cents, [{1} Coin]  : {2}", key.Item1, key.Item2, minCentsCoinNumber1[key]));
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
                var key = new Tuple<int, int>(cents, coinValue);
                if (lastUsedCoin.ContainsKey(key))
                {

                    int tmp = lastUsedCoin[key];
                    minCoins = Calculate(cents - coinValue) + tmp;
                    lastUsedCoin[key] = minCoins;
                    

                }
                else if (cents >= coinValue)
                {
                    int tmp = Calculate(cents - coinValue) + 1;
                    minCoins = Math.Min(minCoins, tmp);
                    lastUsedCoin[key] = minCoins;

                }
                else
                {
                    lastUsedCoin[key] = 0;
                }
                
            }

            minCentsCoinNumber[cents] = minCoins;
            return minCoins;

        }
    }
}
