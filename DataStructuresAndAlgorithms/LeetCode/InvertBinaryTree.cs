using DataStructuresAndAlgorithms.LeetCode.InputTypes;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class InvertBinaryTree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return root;

            var left = InvertTree(root.left);
            var right = InvertTree(root.right);

            root.left = right;
            root.right = left;

            return root;
        }
    }
}
