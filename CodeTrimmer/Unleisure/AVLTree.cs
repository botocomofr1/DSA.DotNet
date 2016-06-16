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
                    TreeNode gp = queue.Dequeue();
                    TreeNode rightParent = gp.Right;
                    TreeNode leftParent = gp.Left;
                    if (rightParent==null && leftParent == null)
                    {
                        if (gp.Value< target)
                        {
                            gp.Right = newNode;
                        }
                        else
                        {
                            gp.Left = newNode;
                        }
                    }
                    else if (rightParent == null)
                    {

                        if (gp.Value < target)
                        {
                            gp.Right = newNode;
                          
                        }
                        else
                        {
                            queue.Enqueue(gp.Left);
                        }

                    }else if (leftParent == null)
                    {

                        if (gp.Value < target)
                        {
                            queue.Enqueue(gp.Right);
                        }
                        else
                        {
                            gp.Left = newNode;
                          
                        }
                    }
                    else
                    {
                        // Go to right and then right
                        if (target > gp.Value && target > rightParent.Value )
                        {
                            if (rightParent.Right == null)
                            {
                                rightParent.Right = newNode;
                                LeftRotate(gp);
                            }
                            else
                            {

                                queue.Enqueue(rightParent);
                            }
                        }
                        // Go left and then left
                        else if (target <= gp.Value && target <= leftParent.Value && leftParent.Left == null)
                        {
                            if (leftParent.Left == null) { 
                                leftParent.Left = newNode;
                                RightRotate(gp);
                            }else
                            {

                                queue.Enqueue(rightParent);
                            }
                        }
                        // Go Right and then left
                        else if (target > gp.Value && target <= rightParent.Value )
                        {
                            if (rightParent.Left == null)
                            {
                                rightParent.Left = newNode;
                                RightRotate(rightParent);
                                LeftRotate(gp);
                            }
                            else
                            {
                                queue.Enqueue(rightParent);

                            }
                        }
                        // Go to left and then right
                        else if (target <= gp.Value && target > leftParent.Value)
                        {
                            if (leftParent.Right == null)
                            {
                                rightParent.Left = newNode;
                                LeftRotate(rightParent);
                                RightRotate(gp);
                            }
                            else
                            {
                                queue.Enqueue(leftParent);
                            }
                        }


                    }


                }
            } 
        }

        protected void Adjust(TreeNode startNode)
        {
            if (startNode == null)
                return;

            if (Height(startNode.Left) - Height(startNode.Right) > 1)
            {
                RightRotate(startNode);

            }else if (Height(startNode.Right) - Height(startNode.Left) > 1)
            {
                LeftRotate(startNode);
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
