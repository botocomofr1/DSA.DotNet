using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uphill
{
    public class MaximunAreaofHistogram
    {
        public MaximunAreaofHistogram()
        {
        }

        public int MaxArea(List<int> histogram)
        {
            if (histogram.Count == 0)
                return 0;

            Stack<int> stack = new Stack<int>();
            int i = 0;
            int maxArea = Int32.MinValue;

            while (i < histogram.Count)
            {
                if (stack.Count == 0 || histogram[i] >= histogram[stack.Peek()])
                {
                    stack.Push(i);
                    i++;

                }
                else
                {
                    while (stack.Count > 0 && histogram[i]<histogram[stack.Peek()])
                    {
                        int top = stack.Pop();
                        int area = int.MinValue;
                        if (stack.Count == 0)
                        {
                            area = histogram[top] * i;
                        }
                        else
                        {
                            area = histogram[top] * ((i - stack.Peek()) - 1);
                        }
                        if (area > maxArea)
                            maxArea = area;
                    }

                }


            }

            while (stack.Count >0)
            {
                int top = stack.Pop();
                int area = int.MinValue;
                if (stack.Count == 0)
                {
                    area = histogram[top] * i;
                }
                else
                {
                    area = histogram[top] * ((i - stack.Peek()) - 1);
                }
                if (area > maxArea)
                    maxArea = area;
            }


            return maxArea;

        }
    }
}
