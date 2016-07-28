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
         
            if (prices.Count <= 1)
                return _globalMax;
            else
            {
                _appleTradeMap = new Dictionary<Tuple<int, int>, int>();
                int price = BestTrade(prices, 0, prices.Count - 1);
            
            }
            return _globalMax;
        }

        protected int BestTrade(List<int> prices, int i, int j)
        {
            if (i<0 || !(i < j))
                return 0;
          
            Tuple<int,int> key = new Tuple<int, int>(i,j);
            if (_appleTradeMap.ContainsKey(key))
                return _appleTradeMap[key];

            int max = 0;
          
            int diff = prices[j] - prices[j-1];
            if (diff > 0)
            {
                int tmp = BestTrade(prices, j-2 , j-1) + diff;
                max = Math.Max(max, tmp);
               
            }
            else
            {
            
                int tmp = BestTrade(prices, j - 2, j - 1);
              
            }
            _globalMax = Math.Max(max, _globalMax);
            _appleTradeMap[key] = max;

            return max;
        }
    }
}
