using DataStructuresAndAlgorithms.LeetCode.InputTypes;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.LeetCode
{
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
