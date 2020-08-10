using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class MaximumProductofSplittedBinaryTree
    {
        public int MaxProduct(TreeNode root)
        {
            if (root == null)
                return 0;

            var treeSum = PreOrderTreeSum(root);

            var maxProduct = new long[1];
            PreOrderTraversal(root, treeSum, maxProduct);

            return (int)maxProduct[0];
        }
        private void PreOrderTraversal(TreeNode node, int treeSum, long[] maxProduct)
        {
            if (node == null)
                return;

            var nodeSum = PreOrderTreeSum(node);
            maxProduct[0] = Math.Max(maxProduct[0], (treeSum - nodeSum) * nodeSum);
            PreOrderTraversal(node.left, treeSum, maxProduct);
            PreOrderTraversal(node.right, treeSum, maxProduct);
        }
        private int PreOrderTreeSum(TreeNode node)
        {
            if (node == null)
                return 0;
            return node.val + PreOrderTreeSum(node.left) + PreOrderTreeSum(node.right);
        }

    }
}
/*
 var root1 = new TreeNode(1,
                new TreeNode(2
                , new TreeNode(4), new TreeNode(5)), new TreeNode(3, new TreeNode(6)));

            var root2 = new TreeNode(1, null,
                new TreeNode(2, new TreeNode(3)
                , new TreeNode(4, new TreeNode(5), new TreeNode(6))));
            var x = new MaximumProductofSplittedBinaryTree();
            System.Console.WriteLine(x.MaxProduct(root1));
            System.Console.WriteLine(x.MaxProduct(root2));
*/