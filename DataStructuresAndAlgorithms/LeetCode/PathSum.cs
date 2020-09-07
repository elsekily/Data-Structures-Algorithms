using DataStructuresAndAlgorithms.LeetCode.InputTypes;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class PathSum
    {
        private int HasSum(TreeNode root)
        {
            if (root == null)
                return 0;

            return root.val + HasSum(root.right);
        }
        public bool HasPathSum(TreeNode root, int sum)
        {
            return Sum(root, sum, 0);
        }
        private bool Sum(TreeNode root, int sum, int currentSum)
        {
            if (root == null) 
                return false;

            currentSum += root.val;
            if (root.right == null && root.left == null && currentSum == sum)
                return true;

            return Sum(root.right, sum, currentSum) || Sum(root.left, sum, currentSum);
        }
    }
}