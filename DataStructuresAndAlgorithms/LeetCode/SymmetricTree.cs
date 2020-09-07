using DataStructuresAndAlgorithms.LeetCode.InputTypes;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class SymmetricTree
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
                return true;

            return MirrorCheck(root.left, root.right);
        }
        private bool MirrorCheck(TreeNode t1,TreeNode t2)
        {
            if (t1 == null && t2 == null)
                return true;
            if (t1 == null || t2 == null)
                return false;

            return t1.val == t2.val && MirrorCheck(t1.left, t2.right) && MirrorCheck(t1.right, t2.left);
        }
    }
}