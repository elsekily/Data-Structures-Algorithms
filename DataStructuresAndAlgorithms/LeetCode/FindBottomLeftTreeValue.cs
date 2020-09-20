using DataStructuresAndAlgorithms.LeetCode.InputTypes;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class FindBottomLeftTreeValue
    {
        public int FindBottomLeftValue(TreeNode root)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var current = new TreeNode();
            while (queue.Count != 0)
            {
                current = queue.Dequeue();
                if (current.right != null)
                    queue.Enqueue(current.right);
                if (current.left != null)
                    queue.Enqueue(current.left);
            }
            return current.val;
        }
    }
}