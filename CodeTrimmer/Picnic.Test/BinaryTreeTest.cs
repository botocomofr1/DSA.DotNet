using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            Assert.AreEqual<int>(4, btree.Height());

        }
    }
}
