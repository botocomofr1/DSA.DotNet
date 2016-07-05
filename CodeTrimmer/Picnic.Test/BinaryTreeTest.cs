using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common;

namespace Picnic.Test
{
    /// <summary>
    /// Summary description for BinaryTreeTest
    /// </summary>
    [TestClass]
    public class BinaryTreeTest
    {


        [TestMethod]
        public void TreeHeightTest()
        {
            // 10, 20, 5, 19,21
            BinaryTree btree = new BinaryTree();
            btree.Insert(10);
            btree.Insert(20);
            btree.Insert(5);
            btree.Insert(19);
            btree.Insert(21);
            btree.Insert(22);
            
            Console.WriteLine(btree.Height());
        }


        [TestMethod]
        public void SerializeTreeTest()
        {
            BinaryTree btree = new BinaryTree();
            btree.Insert(10);
            btree.Insert(5);
            btree.Insert(20);
            btree.Insert(8);
            btree.Insert(4);
            btree.Insert(15);
            btree.Insert(30);
            Console.WriteLine(string.Join(",", btree.SerializeTree()));

            BinaryTree btree1 = new BinaryTree();
            btree1.DeserializeTree(btree.SerializeTree());
            Console.WriteLine(string.Join(",", btree1.SerializeTree()));
        }
    }
}