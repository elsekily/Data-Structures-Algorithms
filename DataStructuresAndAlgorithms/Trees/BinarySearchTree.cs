using System;

namespace DataStructuresAndAlgorithms.Trees
{
    public class BinarySearchTree
    {
        private Node root;
        internal class Node
        {
            public int Value { get; set; }
            public Node LeftChild { get; set; }
            public Node RightChild { get; set; }
            public Node(int value)
            {
                Value = value;
            }
            public override string ToString()
            {
                return "Value= " + Value.ToString();
            }
        }
        public void Insert(int value)
        {
            if (root == null)
            {
                root = new Node(value);
                return;
            }


            var current = root;
            while (true)
            {
                if (current.Value <= value)
                {
                    if (current.RightChild == null)
                    {
                        current.RightChild = new Node(value);
                        return;
                    }
                    current = current.RightChild;
                }
                else
                {
                    if (current.LeftChild == null)
                    {
                        current.LeftChild = new Node(value);
                        return;
                    }
                    current = current.LeftChild;
                }
            }
        }
        public bool Find(int value)
        {
            var current = root;
            while (current != null)
            {
                if (current.Value == value)
                    return true;

                if (current.Value <= value)
                    current = current.RightChild;
                else
                    current = current.LeftChild;

            }
            return false;
        }
        public void PreOrderTraversal()
        {
            PreOrderTraversal(root);
        }
        private void PreOrderTraversal(Node node)
        {
            if (node == null)
                return;
            Console.WriteLine(node.Value);
            PreOrderTraversal(node.LeftChild);
            PreOrderTraversal(node.RightChild);
        }
        public void InOrderTraversal()
        {
            InOrderTraversal(root);
        }
        private void InOrderTraversal(Node node)
        {
            if (node == null)
                return;
            InOrderTraversal(node.LeftChild);
            Console.WriteLine(node.Value);
            InOrderTraversal(node.RightChild);
        }
        public void PostOrderTraversal()
        {
            PostOrderTraversal(root);
        }
        private void PostOrderTraversal(Node node)
        {
            if (node == null)
                return;
            PostOrderTraversal(node.LeftChild);
            PostOrderTraversal(node.RightChild);
            Console.WriteLine(node.Value);
        }
        public int Height()
        {
            return Height(root);
        }
        private int Height(Node node)
        {
            if (node.LeftChild == null && node.RightChild == null)
            {
                return 0;
            }

            if (node.LeftChild == null)
                return 1 + Height(node.RightChild);
            if (node.RightChild == null)
                return 1 + Height(node.LeftChild);

            return 1 + Math.Max(Height(node.LeftChild), Height(node.RightChild));
        }
        public int Minmum()
        {
            return Minmum(root);
        }
        private int Minmum(Node node)
        {
            if (node.LeftChild == null && node.RightChild == null)
                return node.Value;
            if (node.LeftChild == null)
                return Math.Min(node.Value, Minmum(node.RightChild));
            if (node.RightChild == null)
                return Math.Min(node.Value, Minmum(node.LeftChild));

            return Math.Min(node.Value, Math.Min(Minmum(node.LeftChild), Minmum(node.RightChild)));
        }
        public int MinmumBinarySearchTree()
        {
            var current = root;
            while (current.LeftChild != null)
                current = current.LeftChild;

            return current.Value;
        }
        public bool CheckEquilty(BinarySearchTree binaryTree)
        {
            return CheckbyNode(this.root, binaryTree.root);
        }
        private bool CheckbyNode(Node thisNode, Node thatNode)
        {
            if (thisNode == null && thatNode == null)
                return true;
            if (thisNode == null || thatNode == null)
                return false;

            if (thisNode.Value != thatNode.Value)
                return false;

            return true && CheckbyNode(thisNode.LeftChild, thatNode.LeftChild)
                && CheckbyNode(thisNode.RightChild, thatNode.RightChild);
        }
        public bool IsBinarySearchTree()
        {
            return IsBinarySearchTree(root, Int32.MinValue, Int32.MaxValue);
        }
        private bool IsBinarySearchTree(Node node, int min, int max)
        {
            if (node == null)
                return true;

            if (!(node.Value > min && node.Value < max))
                return false;

            return true && IsBinarySearchTree(node.LeftChild, min, node.Value)
                && IsBinarySearchTree(node.RightChild, node.Value, max);
        }
        public void NodesAtK(int k)
        {
            NodesAtK(root, k);
        }
        private void NodesAtK(Node node, int k)
        {
            if (node == null)
                return;
            if (k == 0)
            {
                Console.WriteLine(node.Value);
                return;
            }
            NodesAtK(node.LeftChild, k - 1);
            NodesAtK(node.RightChild, k - 1);
        }
    }
}
