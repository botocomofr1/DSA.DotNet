using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unleisure
{
    public class Hanoi
    {
        public Hanoi() { }

        public void Move( Stack<int> source, Stack<int> dest)
        {
            int disks = source.Count();
            Stack<int> help = new Stack<int>();
            Move(disks, source, dest, help);

        }

        protected void Move(int remainingDisk, Stack<int> source, Stack<int> dest, Stack<int> help)
        {
            if (remainingDisk> 0)
            {
                remainingDisk = remainingDisk - 1;
                Move(remainingDisk, source, help, dest);
                RealMove(source, dest);
                Move(remainingDisk, help, dest, source);
            }


        }

        private static void RealMove(Stack<int> source, Stack<int> dest)
        {
            if (source.Count()>0 && dest.Count > 0)
            {
               if (dest.Peek() < source.Peek())
                {
                    throw new Exception("Not valid Move");
                }
                
            }
            if (source.Count() >0)
                dest.Push(source.Pop());

        }
    }
}
