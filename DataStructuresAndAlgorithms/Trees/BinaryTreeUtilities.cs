using DataStructuresAndAlgorithms.LeetCode.InputTypes;
using System;

namespace DataStructuresAndAlgorithms.Trees
{
    public class BinaryTreeUtilities
    {
        private Random random = new Random();
        public TreeNode binaryTreeGenerator(int n, int key)
        {
            if (n <= 0)
                return null;

            var root = new TreeNode(random.Next(0, 15));

            int leftN = random.Next(0, n);

            root.left = binaryTreeGenerator(leftN, key);
            root.right = binaryTreeGenerator(n - leftN - 1, key);

            return root;
        }
    }
}
