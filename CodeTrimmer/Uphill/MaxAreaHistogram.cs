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

            int right = 0;
           
            while (right < size)
            {

                if (s.Count == 0 || histogram[right] > histogram[s.Peek()])
                {
                    s.Push(right);
                    right++;
     
                }
                else
                {
                    int left = s.Pop();
                    int width = (s.Count == 0 ? right : ((right - left) - 1));
                    int area = histogram[left] * width;
                    Console.WriteLine(string.Format("(1)  Left: {0}  Right: {2} Width {4}  Height: {1} Area {3}", left, histogram[left], right,area,width));
                    if (area > maxArea)
                        maxArea = area;

                }

            }

            while(s.Count > 0)
            {
                int left = s.Pop();
                int width = (s.Count == 0 ? right : ((right - left) - 1));
                int area = histogram[left] * width;
                Console.WriteLine(string.Format("(2)  Left: {0}  Right: {2} Width {4}  Height: {1} Area {3}", left, histogram[left], right, area, width));
                if (area > maxArea)
                    maxArea = area;

            }
            return maxArea;

        }
    }
}
