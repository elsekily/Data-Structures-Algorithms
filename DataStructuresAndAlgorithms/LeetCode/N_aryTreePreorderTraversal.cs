using DataStructuresAndAlgorithms.LeetCode.InputTypes;
using System.Collections.Generic;
using System.Linq;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class N_aryTreePreorderTraversal
    {
        private List<int> list;
        public IList<int> Preorder(Node root)
        {
            list = new List<int>();
            var stack = new Stack<Node>();
            stack.Push(root);

            while (stack.Count != 0)
            {
                var node = stack.Pop();
                list.Add(node.val);
                if (node.children != null)
                {
                    for (int i = node.children.Count - 1; i >= 0; i--)
                    {
                        stack.Push(node.children[i]);
                    }
                }
            }

            return list;
        }
        public IList<int> PreorderRecursion(Node root)
        {
            list = new List<int>();
            Recursion(root);
            return list;
        }
        private void Recursion(Node root)
        {
            if (root == null)
                return;

            list.Add(root.val);
            foreach (var child in root.children)
            {
                Recursion(child);
            }
        }
    }
}