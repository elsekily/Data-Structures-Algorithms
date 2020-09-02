using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
    public class N_aryTreePostorderTraversal
    {
        public IList<int> Postorder(Node root)
        {
            if (root == null)
                return new List<int>(); 

            var list = new List<int>();
            Recursion(root, list);
            return list;
        }
        private void Recursion(Node root, IList<int> list)
        {
            foreach (var child in root.children)
            {
                Recursion(child, list);
            }
            list.Add(root.val);
        }
    }
 }
