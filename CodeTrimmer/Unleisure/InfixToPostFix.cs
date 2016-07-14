using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unleisure
{
    public class InfixToPostFix
    {
        public InfixToPostFix() { }

        public List<string>  ConvertToPostFix(List<string> inFix)
        {
            Stack<string> stack = new Stack<string>();
            List<string> posFix = new List<string>();
            foreach (var item in inFix)
            {
                var trimmedSpaceItem = item.Trim();
                Stack<string> stackTmp = new Stack<string>();
                if (trimmedSpaceItem.Equals(")"))
                {
                    List<string> tempList = new List<string>();
                    while (!stack.Peek().Equals("("))
                    {
                        tempList.Add(stack.Pop());

                    }
                    if (stack.Peek().Equals("("))
                    {
                        stack.Pop();
                    }
                    foreach (var tempItem in tempList)
                    {
                        int value = Int32.MinValue;
                        if (!Int32.TryParse(tempItem, out value))
                        {
                            stackTmp.Push(tempItem);
                        }

                    }
                    foreach (var tempItem in tempList)
                    {
                        int value = Int32.MinValue;
                        if (Int32.TryParse(tempItem, out value))
                        {
                            stackTmp.Push(tempItem);
                        }

                    }
                    while (stackTmp.Count > 0)
                    {
                        posFix.Add(stackTmp.Pop());
                    }

                }
                else
                {
                    stack.Push(trimmedSpaceItem);
                }
            }
            while (stack.Count > 0)
            {
                posFix.Add(stack.Pop());
            }

            return posFix;

        }
        public int Calculate(List<string> postFix)
        {

            Stack<string> stack = new Stack<string>();

            foreach (var item in postFix)
            {
                var trimmedSpaceItem = item.Trim();
                int value = Int32.MinValue;
                if (Int32.TryParse(trimmedSpaceItem, out value))
                {
                    stack.Push(trimmedSpaceItem);

                }
                else
                {
                    if (trimmedSpaceItem.Equals("+"))
                    {
                        var item1 = stack.Pop();
                        var item2 = stack.Pop();
                        var tempResult = Convert.ToInt32(item2) + Convert.ToInt32(item1);
                        stack.Push(Convert.ToString(tempResult));
                    }
                    else if (trimmedSpaceItem.Equals("-"))
                    {
                        var item1 = stack.Pop();
                        var item2 = stack.Pop();
                        var tempResult = Convert.ToInt32(item2) - Convert.ToInt32(item1);
                        stack.Push(Convert.ToString(tempResult));
                    }
                    else if (trimmedSpaceItem.Equals("*"))
                    {
                        var item1 = stack.Pop();
                        var item2 = stack.Pop();
                        var tempResult = Convert.ToInt32(item2) * Convert.ToInt32(item1);
                        stack.Push(Convert.ToString(tempResult));
                    }
                    else if (trimmedSpaceItem.Equals("/"))
                    {
                        var item1 = stack.Pop();
                        var item2 = stack.Pop();
                        var tempResult = Convert.ToInt32(item2) / Convert.ToInt32(item1);
                        stack.Push(Convert.ToString(tempResult));
                    }
                }

            }


            if (stack.Count > 1)
                throw new Exception("Something wrong");
            else if (stack.Count == 0)
                return 0;
            else
                return Convert.ToInt32(stack.Pop());


        }
    }
}

