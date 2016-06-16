using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unleisure
{
    public class AVLTree
    {
        private TreeNode  root=null;
        public AVLTree() { }

        protected int Height(TreeNode startNode)
        {
            if (startNode == null)
                return 0;
            else
            {
                int lheight = Height(startNode.Left);
                int rheight = Height(startNode.Right);
                return lheight > rheight ? lheight : rheight;
            }

        }

        public void Insert(int target)
        {
            var newNode = new TreeNode();
            newNode.Value = target;
            if (root == null)
            {
            
                root = newNode;

            }
            else
            {
                Queue<TreeNode> queue = new Queue<TreeNode>();
                queue.Enqueue(root);
                while (queue.Count > 0)
                {
                    TreeNode tmp = queue.Dequeue();
                    if (tmp.Value < target && tmp.Right!=null)
                    {
                        queue.Enqueue(tmp.Right);

                    }else if (tmp.Value < target && tmp.Right == null)
                    {
                        tmp.Right = newNode;
                    }
                    else if (tmp.Value >= target && tmp.Left != null)
                    {
                        queue.Enqueue(tmp.Left);

                    }
                    else
                    {
                        tmp.Left = newNode;
                    }
                }
            } 
        }

        protected void Adjust(TreeNode startNode)
        {
            if (Height(startNode.Left) - Height(startNode.Right) > 1)
            {


            }else if (Height(startNode.Right) - Height(startNode.Left) > 1)
            {

            }else{
                Adjust(startNode.Left);
                Adjust(startNode.Right);

            }

        }

        protected void RightRotate(TreeNode startNode)
        {
            TreeNode newP = startNode.Left;
            startNode.Left = newP.Right;
            newP.Right = startNode;

        }

        protected void LeftRotate(TreeNode startNode)
        {
            TreeNode newP = startNode.Right;
            startNode.Right = newP.Left;
            newP.Right = startNode;

        }
    }
}
