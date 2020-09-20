using DataStructuresAndAlgorithms.LeetCode.InputTypes;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class BinaryTreeLevelOrderTraversal
    {
        public IList<int> LevelOrder(TreeNode root)
        {
            var output = new List<int>();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                var current = queue.Dequeue();
                if (current.left != null)
                    queue.Enqueue(current.left);
                if (current.right != null)
                    queue.Enqueue(current.right);

                output.Add(current.val);

            }
            return output;
        }
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            var output = new List<IList<int>>();
            LevelOrderRecursion(root, 1, output);
            Reverse(output);
            return output;
        }
        private void LevelOrderRecursion(TreeNode root, int depth, IList<IList<int>> list)
        {
            if (root == null)
                return;

            if (list.Count < depth)
                list.Add(new List<int>());

            list[depth - 1].Add(root.val);

            LevelOrderRecursion(root.left, depth + 1, list);
            LevelOrderRecursion(root.right, depth + 1, list);
        }
        private void Reverse(IList<IList<int>> list)
        {
            var end = list.Count - 1;
            for (int i = 0; i < list.Count / 2; i++)
            {
                var temp = list[i];
                list[i] = list[end];
                list[end--] = temp;
            }
        }
    }
}