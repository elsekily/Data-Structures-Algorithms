using System;

namespace DataStructuresAndAlgorithms
{
    public class BinaryTree
    {
        private Node root;
        public partial class Node
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

        public bool Validate()
        {
            return Validate(root);
        }
        private bool Validate(Node node)
        {
            if (node.RightChild == null && node.LeftChild == null)
                return true;

            bool x = false;
            if (node.Value > node.LeftChild.Value && node.Value < node.RightChild.Value)
                x = true;

            return x && Validate(node.RightChild) && Validate(node.RightChild);
        }

        public void Swap()
        {
            var temp = root.LeftChild;
            root.LeftChild = root.RightChild;
            root.RightChild = temp;
        }

    }
}
