using DataStructuresAndAlgorithms.LeetCode.InputTypes;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class CheckCompletenessofaBinaryTree
    {
        public bool IsCompleteTree(TreeNode root)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var flag = false;
            while (queue.Count != 0)
            {
                var current = queue.Dequeue();

                if (current == null && !flag)
                    flag = true;

                if (current != null)
                {
                    if (flag) return false;
                    queue.Enqueue(current.left);
                    queue.Enqueue(current.right);
                }
            }
            return true;
        }
    }
}
