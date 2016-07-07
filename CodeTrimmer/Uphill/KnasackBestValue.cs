using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uphill
{
    public class KnasackItem
    {
        public int Value { get; set; }
        public int Weight { get; set; }

    }
    public class KnasackBestValue
    {
        private Dictionary<Tuple<int,int>, int> itemIndexValueMap = new Dictionary<Tuple<int, int>, int>();
        public KnasackBestValue() { }

        public int BestDeal(int weightLeftTobeFilled , List<KnasackItem> items)
        {
            if (weightLeftTobeFilled <=0)
                return 0;
            itemIndexValueMap = new Dictionary<Tuple<int, int>, int>();
            itemIndexValueMap.Add(new Tuple<int, int>(0,0), 0);
            return BestDeal(items.Count,weightLeftTobeFilled, items);
        }

        protected int BestDeal(int n,int weightLeftTobeFilled, List<KnasackItem> items)
        {
            if (n <1)
                return 0;
            var key = new Tuple<int, int>(n, weightLeftTobeFilled);
            if (itemIndexValueMap.Keys.Contains(key))
                return itemIndexValueMap[key];

            if (items[n - 1].Weight > weightLeftTobeFilled )
                return BestDeal(n-1,weightLeftTobeFilled,  items);

            int a = items[n-1].Value + BestDeal(n-1, weightLeftTobeFilled - items[n-n].Weight, items);

            int b = BestDeal(n - 1, weightLeftTobeFilled, items );
            itemIndexValueMap[key] = Math.Max(a, b);
            return Math.Max(a, b);



        }
    }
}
