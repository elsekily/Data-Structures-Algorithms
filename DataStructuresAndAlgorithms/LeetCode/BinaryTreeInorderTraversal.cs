using DataStructuresAndAlgorithms.LeetCode.InputTypes;
using System.Collections.Generic;
using System.Threading;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class BinaryTreeInorderTraversal
    {
        private List<int> list;
        public IList<int> InorderTraversal(TreeNode root)
        {
            list = new List<int>();
            var stack = new Stack<TreeNode>();
            var current = root;
            while (current != null || stack.Count != 0) 
            {
                if (current != null)
                {
                    stack.Push(current);
                    current = current.left;
                    continue;
                }
                current = stack.Pop();
                list.Add(current.val);
                current = current.right;
            }
            return list;
        }
        public IList<int> InorderTraversalRec(TreeNode root)
        {
            list = new List<int>();
            InorderRecursion(root);
            return list;
        }
        private void InorderRecursion(TreeNode root)
        {
            if (root == null)
                return;

            InorderRecursion(root.left);
            list.Add(root.val);
            InorderRecursion(root.right);
        }
    }
}