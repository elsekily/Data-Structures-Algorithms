using DataStructuresAndAlgorithms.LeetCode.InputTypes;
using System.Collections.Generic;

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
        public void FlattenWithStack(TreeNode root)
        {
            if (root == null)
                return;

            var stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count != 0)
            {
                var current = stack.Pop();

                if (current.right != null)
                    stack.Push(current.right);

                if (current.left != null)
                    stack.Push(current.left);

                if (stack.Count != 0)
                    current.right = stack.Peek();

                current.left = null;
            }
        }
    }
}