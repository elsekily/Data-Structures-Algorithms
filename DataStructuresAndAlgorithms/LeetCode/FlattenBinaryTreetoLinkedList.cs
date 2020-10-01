using DataStructuresAndAlgorithms.LeetCode.InputTypes;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class FlattenBinaryTreetoLinkedList
    {
        public void Flatten(TreeNode root)
        {
            if (root == null)
                return;

            Flatten(root.left);
            Flatten(root.right);

            if (root.left != null)
            {
                var temp = root.right;
                root.right = root.left;
                root.left = null;
                var current = root.right;
                while (current.right != null)
                    current = current.right;
                current.right = temp;
            }
        }
    }
}