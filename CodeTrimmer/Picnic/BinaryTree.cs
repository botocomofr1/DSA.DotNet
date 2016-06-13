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
                            TreeNode n = new TreeNode();
                            n.Value = target;
                            node.Left = n;
                            
                        }
                        else {
                            q.Enqueue(node.Left);
                        }
                    }
                    else
                    {

                        if (node.Right == null)
                        {
                            TreeNode n = new TreeNode();
                            n.Value = target;
                            node.Right = n;

                        }
                        else {
                            q.Enqueue(node.Right);
                        }
                    }
               }
          
            }


        }

        public bool DepFirstSearch(int target)
        {
            return DepthFirstSearch(root, target);
        }

        private bool DepthFirstSearch(TreeNode startNode, int targert)
        {
            if (startNode == null)
                return false;
            else if (startNode != null && startNode.Value == targert)
                return true;
            else
            {
                if (startNode.Left != null && startNode.Value > targert)
                    return DepthFirstSearch(startNode.Left, targert);
                else if (startNode.Right != null && startNode.Value < targert)
                    return DepthFirstSearch(startNode.Right, targert);
                else
                    return false;
            }
        }


        public bool BreathFirstSearch(int target)
        {
            if (root ==null)
            {
                return false;
            }
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Any())
            {
                TreeNode treeNode = q.Dequeue();
                if (treeNode.Value == target)
                    return true;
                else
                {
                    if (treeNode.Left != null &&  treeNode.Value > target)
                        q.Enqueue(treeNode.Left);
                    if (treeNode.Right != null && treeNode.Value < target)
                        q.Enqueue(treeNode.Right);
                }
            }
            return false;
        }
    }
}
