using DataStructuresAndAlgorithms.LeetCode.InputTypes;
using System;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class FindLargestValueinEachTreeRow
    {
        private List<int> list;
        public IList<int> LargestValues(TreeNode root)
        {
            list = new List<int>();
            TreePreorderTraversal(root, 0);
            return list;
        }
        private void TreePreorderTraversal(TreeNode root, int level)
        {
            if (root == null)
                return;

            if (list.Count == level)
                list.Add(root.val);
            else
                list[level] = Math.Max(root.val, list[level]);

            TreePreorderTraversal(root.left, level + 1);
            TreePreorderTraversal(root.right, level + 1);
        }
    }
}
