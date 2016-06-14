using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
namespace Picnic
{
    public class BinaryTree
    {
        private TreeNode root;

        public BinaryTree()
        {
            root = null;
        }

        protected void RotateRight(TreeNode startNode)
        {
            TreeNode newStartNode = startNode.Left;
            startNode.Left = newStartNode.Right;
            newStartNode.Right = startNode;
        }

        protected void RotateLeft(TreeNode startNode)
        {
            TreeNode newStartNode = startNode.Right;
            startNode.Right = newStartNode.Left;
            newStartNode.Left = startNode;
        }
        public bool Delete(int target)
        {
            if (root == null)
            {
                return false;
            }

            TreeNode deletedNode = BreathFirstSearch(target);
            if (deletedNode == null)
                return false;
            else
            {
                // No children case
                if (deletedNode.Left == null && deletedNode.Right == null)
                    deletedNode = null;
                if (deletedNode.Left != null )
                {
                    TreeNode largest = FindLargest(deletedNode.Left);
                    deletedNode.Value = largest.Value;
                    largest = null;

                }
                else
                {
                    TreeNode smallest = FindSmallest(deletedNode.Right);
                    deletedNode.Value = smallest.Value;
                    smallest = null;
                }
                return true;
            }

        }

        private TreeNode FindLargest(TreeNode startNode)
        {
            if (startNode == null)
            {
                return null;
            }
            else
            {
                Queue<TreeNode> queue = new Queue<TreeNode>();
                queue.Enqueue(startNode);

                while (queue.Any())
                {
                    TreeNode treeNode = queue.Dequeue();
                    if (treeNode.Right == null)
                    {
                        return treeNode;
                    }
                    else
                    {
                        queue.Enqueue(treeNode.Right);
                    }
                }
                return null;
            }

        }
        private TreeNode FindSmallest(TreeNode startNode)
        {
            if (startNode == null)
            {
                return null;
            }
            else
            {
                Queue<TreeNode> queue = new Queue<TreeNode>();
                queue.Enqueue(startNode);
            
                while (queue.Any())
                {
                    TreeNode treeNode = queue.Dequeue();
                    if (treeNode.Left == null)
                    {
                        return treeNode;
                    }
                    else
                    {
                        queue.Enqueue(treeNode.Left);
                    }
                }
                return null;
            }

        }


        public int Height()
        {
           return  Height(root);
        }

        private int Height(TreeNode treeNode)
        {
 

            if (treeNode == null)
            {
                return 0;
            }
            else
            {
                return 1+System.Math.Max(Height(treeNode.Left), Height(treeNode.Right));
            }
 
        }
       

        public void Insert(int target)
        {
            
            if (root == null)
            {
                root = new TreeNode();
                root.Value = target;
        
            }
            else
            {
                Queue<TreeNode> q = new Queue<TreeNode>();
                q.Enqueue(root);
                while (q.Any())
                {
                    TreeNode node = q.Dequeue();
                    if (node.Value >= target)
                    {
                        if (node.Left == null)
                        {
                            TreeNode newNode = new TreeNode();
                            newNode.Value = target;
                            node.Left = newNode;                           
                        }
                        else {
                            q.Enqueue(node.Left);
                        }
                    }
                    else
                    {
                        if (node.Right == null)
                        {
                            TreeNode newNode = new TreeNode();
                            newNode.Value = target;
                            node.Right = newNode;
                        }
                        else {
                            q.Enqueue(node.Right);
                        }
                    }
               }
          
            }


        }

        public TreeNode DepthFirstSearch(int target)
        {
            return DepthFirstSearch(root, target);
        }

        private TreeNode DepthFirstSearch(TreeNode startNode, int targert)
        {
            if (startNode == null)
                return null;
            else if (startNode != null && startNode.Value == targert)
                return startNode;
            else
            {
                if (startNode.Left != null && startNode.Value > targert)
                    return DepthFirstSearch(startNode.Left, targert);
                else if (startNode.Right != null && startNode.Value < targert)
                    return DepthFirstSearch(startNode.Right, targert);
                else
                    return null;
            }
        }


        public TreeNode BreathFirstSearch(int target)
        {
            if (root ==null)
            {
                return null;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Any())
            {
                TreeNode treeNode = queue.Dequeue();
                if (treeNode.Value == target)
                    return treeNode;
                else
                {
                    if (treeNode.Left != null &&  treeNode.Value > target)
                        queue.Enqueue(treeNode.Left);
                    if (treeNode.Right != null && treeNode.Value < target)
                        queue.Enqueue(treeNode.Right);
                }
            }
            return null;
        }
    }
}
