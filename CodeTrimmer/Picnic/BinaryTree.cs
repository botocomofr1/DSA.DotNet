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
            newStartNode.Parent = startNode.Parent;

            startNode.Left = newStartNode.Right;
            startNode.Left.Parent = startNode;

            newStartNode.Right = startNode;
            startNode.Parent = newStartNode;
        }

        protected void RotateLeft(TreeNode startNode)
        {
            TreeNode newStartNode = startNode.Right;
            newStartNode.Parent = startNode.Parent;

            startNode.Right = newStartNode.Left;
            startNode.Right.Parent = startNode;

            newStartNode.Left = startNode;
            startNode.Parent = newStartNode;
        }

        public bool IsValidBST()
        {
            if (root == null)
                return true;
            else
            {
                return IsValidBST(root);

            }
        }

        public Queue<string> SerializeTree()
        {
            Queue<string> serializeTree = new Queue<string>();
            SerializeTree(root, serializeTree);
            return serializeTree;
        }
   
        public void DeserializeTree(Queue<string> serializeTree)
        {
            root = DeserializeTreeHelp(serializeTree);
        }

        protected TreeNode DeserializeTreeHelp(Queue<string> q)
        {
            string v = null;
            if (q.Count > 0)
                v = q.Dequeue();

            if (v!=null && v != "#")
            {
                TreeNode newNode = new TreeNode();
                newNode.Value = Convert.ToInt32(v);
                newNode.Left = DeserializeTreeHelp(q);
                newNode.Right = DeserializeTreeHelp(q);
                return newNode;

            }
            else
            {
                return null;
            }
        }
        protected void SerializeTree(TreeNode treeNode, Queue<string> serializeTree)
        {
            if (treeNode == null)
            {
                serializeTree.Enqueue("#");
            }
            else {
                serializeTree.Enqueue(Convert.ToString(treeNode.Value));
                SerializeTree(treeNode.Left, serializeTree);
                SerializeTree(treeNode.Right, serializeTree);
            }

        }
        protected bool IsValidBST(TreeNode treeNode)
        {
            if (treeNode == null)
                return true;
            else
            {
                if (treeNode.Left != null && treeNode.Right != null)
                {
                    if (!(treeNode.Value >= treeNode.Left.Value &&
                        treeNode.Value <= treeNode.Right.Value))
                        return false;

                }else if (treeNode.Left != null && treeNode.Right == null)
                {
                    if (!(treeNode.Value >= treeNode.Left.Value))
                        return false;
                }
                else 
                {
                    if (!(treeNode.Value <= treeNode.Right.Value))
                        return false;
                    
                }
                return IsValidBST(treeNode.Right) && IsValidBST(treeNode.Left);

            }

        }

        public bool IsBalanceBST()
        {
            if (root == null)
                return true;
            int leftHeight = Height(root.Left);
            int rightHeight = Height(root.Right);
            if (leftHeight != rightHeight)
                return false;
            else
                return IsBalanceBST(root.Left) && IsBalanceBST(root.Right);
            
        }

        protected bool IsBalanceBST(TreeNode tnode)
        {
            if (tnode == null)
                return true;
            else
            {
                if (Height(tnode.Left) != Height(tnode.Right))
                    return false;
                else
                    return IsBalanceBST(root.Right) && IsBalanceBST(root.Right);
            }
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
                    largest.Parent = null;
                    largest = null;

                }
                else
                {
                    TreeNode smallest = FindSmallest(deletedNode.Right);
                    deletedNode.Value = smallest.Value;
                    smallest.Parent = null;
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
                TreeNode newNode = new TreeNode();
                newNode.Value = target;
                Queue<TreeNode> q = new Queue<TreeNode>();
                q.Enqueue(root);
                while (q.Any())
                {
                    TreeNode currentNode = q.Dequeue();
                    if (currentNode.Value >= target)
                    {
                        if (currentNode.Left == null)
                        {
                            currentNode.Left = newNode;
                            newNode.Parent = currentNode;                        
                        }
                        else {
                            q.Enqueue(currentNode.Left);
                        }
                    }
                    else
                    {
                        if (currentNode.Right == null)
                        {
                        
                       
                            currentNode.Right = newNode;
                            newNode.Parent = currentNode;
                        }
                        else {
                            q.Enqueue(currentNode.Right);
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
