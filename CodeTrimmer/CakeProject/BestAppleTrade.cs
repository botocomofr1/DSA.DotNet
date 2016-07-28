using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeProject
{
    public class BestAppleTrade
    {
        Dictionary< Tuple<int,int>,int> _appleTradeMap = new Dictionary<Tuple<int, int>, int>();
        public BestAppleTrade()
        {
        }

        public int BestTrade(List<int> prices)
        {
            int price = 0;
            if (prices.Count <= 1)
                return price;
            else
            {
                _appleTradeMap = new Dictionary<Tuple<int, int>, int>();
                price = BestTrade(prices, 0, prices.Count - 1);
            
            }
            return price;
        }

        protected int BestTrade(List<int> prices, int i, int j)
        {
            if (!(i < j))
                return 0;
            var key = new Tuple<int, int>(i,j);

            if (_appleTradeMap.ContainsKey(key))
                return _appleTradeMap[key];
            int max = prices[j] - prices[i];
            _appleTradeMap[key] = max;
            for (int buyTime = 0; buyTime < j-1; buyTime++)
            {
                for (int sellTime = j; sellTime>buyTime; sellTime--)
                {
                    int tmp = BestTrade(prices, buyTime, sellTime);
                    max = Math.Max(tmp, max);
                }
                  
            }
             
            return max;
        }
    }
}
