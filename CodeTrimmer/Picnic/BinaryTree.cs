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

        public bool Delete(int target)
        {
            bool deleted = false;
            if (root == null)
            {
                return false;
            }
     
            if (root.Value == target)
            {
                if (root.Right != null)
                {

                    TreeNode smallest = FindSmallest(root.Right);

                }
                deleted = true;

            }
            return deleted;
        }
        private TreeNode FindSmallest(TreeNode startNode)
        {
            if (startNode == null)
                return null;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(startNode);
            TreeNode p = startNode.Left;
            while (q.Any())
            {
                TreeNode treeNode = q.Dequeue();
                { 
                    if (treeNode.Left != null && treeNode.Left.Left !=null)
                        q.Enqueue(treeNode.Left);
                    else if (treeNode.Left != null && treeNode.Left ==null)
                    {

                        return treeNode.Left;
                    }
           
                }
            }
            return null;

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
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Any())
            {
                TreeNode treeNode = q.Dequeue();
                if (treeNode.Value == target)
                    return treeNode;
                else
                {
                    if (treeNode.Left != null &&  treeNode.Value > target)
                        q.Enqueue(treeNode.Left);
                    if (treeNode.Right != null && treeNode.Value < target)
                        q.Enqueue(treeNode.Right);
                }
            }
            return null;
        }
    }
}
