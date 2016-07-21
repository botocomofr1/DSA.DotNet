using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uphill
{
    public class MaxAreaHistogram
    {
        private Stack<int> s = new Stack<int>();
        public MaxAreaHistogram() { }

        public int MaxArea(List<int> histogram)
        {
            int maxArea = Int32.MinValue;
            Stack<int> s = new Stack<int>();

            int size = histogram.Count;

            int i = 1;
            int index = 0;
            while (index < size)
            {

                if (s.Count == 0 || histogram[index] > histogram[s.Peek()])
                {
                    s.Push(index);
                    index++;
                    i++;
                }
                else
                {
                    int top = s.Pop();
                    int area = histogram[top] * (s.Count == 0 ? i :( (i - top) - 1));
                    Console.WriteLine(string.Format("(1)  Top: {0} H: {1} i: {2} Area {3}", top, histogram[top], i,area));
                    if (area > maxArea)
                        maxArea = area;

                }

            }

            while(s.Count > 0)
            {
                int top = s.Pop();
                int area = histogram[top] * (s.Count == 0 ? i : ((i - top) - 1));
                Console.WriteLine(string.Format("(2)  Top: {0} H: {1} i: {2} Area {3}", top, histogram[top], i, area));
                if (area > maxArea)
                    maxArea = area;

            }
            return maxArea;

        }
    }
}
