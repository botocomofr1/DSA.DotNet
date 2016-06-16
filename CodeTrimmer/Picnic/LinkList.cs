using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picnic
{
    public class MyLinkList
    {
        private LinkNode root = null;
        public MyLinkList() { }

        public void Add(LinkNode node)
        {
            if (root == null)
                root = node;
            else
            {
                LinkNode tmp = root;
                while (tmp.Next != null)
                    tmp = tmp.Next;
                tmp.Next = node;
            }

        }
        public LinkNode Remove(LinkNode node)
        {
            if (node == null)
                return null;
            else
            {
                LinkNode current = root;
                while (current != null && current.Value != node.Value)
                {
                    current = current.Next;
                }
                if (current == null)
                    return null;
                else {
                    var deleted = current.Next;
                    var nextNext = current.Next.Next;
                    current.Next = nextNext;
                    deleted.Next = null;
                    return deleted;
                }
            }

        }

        public void Reverse()
        {

            LinkNode newNode = null;
            LinkNode current = root;
            while (current != null)
            {
                LinkNode temp = current;
                temp.Next = newNode;
                newNode = temp;
                current = current.Next;
            }

        }
    }
}
