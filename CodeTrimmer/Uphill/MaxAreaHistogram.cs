using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uphill
{
    public class MaxAreaHistogram
    {
        // Use stack to track bar on the left is lower or equal to current

        // Once see a bar is lower than the peek of the stack
        // calculate area : 
        // Height of bar = Histogram of top of stack
        // width = current index - peek of stack   
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

                if (s.Count == 0 ||  histogram[right]  >= histogram[s.Peek()])
                {
                    s.Push(right);
                    right++;
     
                }
                else
                {
                    while (s.Count>0 && histogram[s.Peek()] > histogram[right])
                    {
                        int top = s.Pop();
                    
                        if (s.Count == 0)
                        {
                            int area = histogram[top]*right;
                            if (area > maxArea)
                                maxArea = area;

                        }
                        else
                        {
                            int area = histogram[top] * ((right - s.Peek())  -1);
                            if (area > maxArea)
                                maxArea = area;
                        }
                    }
                }

            }

            while (s.Count > 0)
            {
                int top = s.Pop();
                if (s.Count == 0)
                {
                    int area = histogram[top]*right;
                    if (area > maxArea)
                        maxArea = area;

                }
                else
                {
                    int area = histogram[top] * ((right - s.Peek()) -1);
                    if (area > maxArea)
                        maxArea = area;
                }

            }
         

        
            return maxArea;

        }
    }
}
