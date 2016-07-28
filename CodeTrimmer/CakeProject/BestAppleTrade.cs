using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CakeProject
{
    public class BestAppleTrade
    {
        Dictionary< Tuple<int,int>,int> _appleTradeMap = new Dictionary<Tuple<int, int>, int>();
        private int _globalMax = 0;
        public BestAppleTrade()
        {
        }

        public int BestTrade(List<int> prices)
        {
            int price;
            if (prices.Count <= 1)
                return _globalMax;
            else
            {
                _appleTradeMap = new Dictionary<Tuple<int, int>, int>();
                price = BestTrade(prices, 0, prices.Count - 1);
            
            }
            return price;
        }

        protected int BestTrade(List<int> prices, int i, int j)
        {
            int max = 0;
            for (int k = 0; k < prices.Count-1; k++)
            {
                var current = new Tuple<int, int>(k, k + 1);
                int diff = prices[k + 1] - prices[k];
                if (diff >= 0)
                {
                    var previous = new Tuple<int,int>(k-1,k);
                    if (_appleTradeMap.ContainsKey(previous))
                    {
                        int tmp = diff + _appleTradeMap[previous];
                        max = Math.Max(tmp, max);
                        _appleTradeMap[current] = tmp;

                    }
                    else
                    {
                        max = Math.Max(diff, max);
                        _appleTradeMap[current] = diff;

                    }

                   

                }



            }
            return max;
        }
    }
}
