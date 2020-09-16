using DataStructuresAndAlgorithms.LeetCode.InputTypes;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class BinaryTreePruning
    {
        public TreeNode PruneTree(TreeNode root)
        {
            return HasOne(root) ? null : root;
        }
        private bool HasOne(TreeNode root)
        {
            if (root == null) return false;

            if (HasOne(root.left)) root.left = null;

            if (HasOne(root.right)) root.right = null;

            if (root.val == 0 && root.left == null && root.right == null)
                return true;

            return false;
        }
    }
}
