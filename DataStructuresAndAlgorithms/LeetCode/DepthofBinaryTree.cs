using DataStructuresAndAlgorithms.LeetCode.InputTypes;
using System;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class DepthofBinaryTree
    {
        public int MaxDepth(TreeNode root)
        {
            
            if (root == null)
                return 0;
            return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
        }
        public int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            var right = MinDepth(root.right);
            var left = MinDepth(root.left);

            if (left != 0 && right == 0)
                return 1 + left;

            if (left == 0 && right != 0)
                return 1 + right;

            return 1 + Math.Max(left, right);
        }
    }
}
