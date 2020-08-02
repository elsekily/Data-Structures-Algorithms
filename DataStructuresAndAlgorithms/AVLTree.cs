using System;

namespace DataStructuresAndAlgorithms
{
    public class AVLTree
    {
        private Node root;
        class Node
        {
            public int Value { get; set; }
            public Node RightChild { get; set; }
            public Node LeftChild { get; set; }
            public int Height { get; set; }

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
            root = Insert(value, root);
        }
        private Node Insert(int value, Node node)
        {
            if (node == null)
                return new Node(value);

            if (node.Value < value)
                node.RightChild = Insert(value, node.RightChild);
            else
                node.LeftChild = Insert(value, node.LeftChild);


            SetHeight(node);
            return Balance(node);
        }

        private Node Balance(Node node)
        {
            int balanceFactor = GetBalanceFactor(node);

            if (balanceFactor > 1)
            {
                if (GetBalanceFactor(node.LeftChild) < 0)
                    node.LeftChild = LeftRotate(node.LeftChild);
                node = RightRotate(node);
            }

            if (balanceFactor < -1)
            {
                if (GetBalanceFactor(node.RightChild) > 0)
                    node.RightChild = RightRotate(node.RightChild);
                node = LeftRotate(node);
            }

            return node;
        }

        private Node LeftRotate(Node node)
        {
            var newRoot = node.RightChild;
            node.RightChild = newRoot.LeftChild;
            newRoot.LeftChild = node;
            SetHeight(newRoot);
            SetHeight(node);
            return newRoot;
        }
        private Node RightRotate(Node node)
        {
            var newRoot = node.LeftChild;
            node.LeftChild = newRoot.RightChild;
            newRoot.RightChild = node;
            SetHeight(newRoot);
            SetHeight(node);
            return newRoot;
        }
        private void SetHeight(Node node)
        {
            node.Height = Math.Max(Height(node.LeftChild), Height(node.RightChild)) + 1;
        }
        private int Height(Node node) => node == null ? -1 : node.Height;
        private int GetBalanceFactor(Node node) => node == null ? 0 : Height(node.LeftChild) - Height(node.RightChild);
    }
}
