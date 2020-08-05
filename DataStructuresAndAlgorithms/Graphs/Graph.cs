using System;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.Graphs
{
    public class Graph
    {
        private Dictionary<string, Node> Nodes;
        private Dictionary<Node, List<Node>> Edges;
        class Node
        {
            public string Label { get; set; }
            public Node(string label)
            {
                Label = label;
            }
            public override string ToString()
            {
                return Label;
            }
        }
        public Graph()
        {
            Nodes = new Dictionary<string, Node>();
            Edges = new Dictionary<Node, List<Node>>();
        }
        public void AddNode(string label)
        {
            Nodes.Add(label, new Node(label));
            Edges.Add(Nodes[label], new List<Node>());
        }
        public void DeleteNode(string label)
        {
            foreach (var node in Edges.Values)
                node.Remove(Nodes[label]);

            Edges.Remove(Nodes[label]);
            Nodes.Remove(label);
        }
        public void AddEdge(string from, string to)
        {
            if (Nodes[from] == null || Nodes[to] == null)
                return;
            Edges[Nodes.GetValueOrDefault(from)].Add(Nodes.GetValueOrDefault(to));
        }
        public void DeleteEdge(string from, string to)
        {
            if (Nodes[from] == null || Nodes[to] == null)
                return;
            Edges[Nodes[from]].Remove(Nodes[to]);
        }
        public void Print()
        {
            foreach (var node in Nodes.Values)
            {
                Console.Write("{0} >> [", node.Label);
                foreach (var connect in Edges.GetValueOrDefault(node))
                {
                    Console.Write("{0}, ", connect.Label);
                }
                if (Edges.GetValueOrDefault(node).Count != 0)
                    Console.Write("\b\b");
                Console.WriteLine("]");
            }
        }
        public void DepthFirstTraversal(string label)
        {
            DepthFirstTraversal(new HashSet<Node>(), Nodes[label]);
        }
        private void DepthFirstTraversal(HashSet<Node> visitedSet, Node node)
        {
            visitedSet.Add(node);
            Console.WriteLine(node.Label);
            foreach (var connect in Edges[node])
            {
                if (!visitedSet.Contains(node))
                    DepthFirstTraversal(visitedSet, connect);
            }
        }
        public void DepthFirstTraversalIterative(string label)
        {
            var node = Nodes[label];
            var stack = new Stack<Node>();
            var visited = new HashSet<Node>();
            stack.Push(node);
            while (stack.Count != 0)
            {
                var current = stack.Pop();
                Console.WriteLine(current.Label);
                visited.Add(current);
                foreach (var connect in Edges[current])
                {
                    if (!visited.Contains(connect))
                        stack.Push(connect);

                }
            }
        }
        public void BreadthFirstTraversalIterative(string label)
        {
            var node = Nodes[label];
            var queue = new Queue<Node>();
            var visited = new HashSet<Node>();
            queue.Enqueue(node);
            while (queue.Count != 0)
            {
                node = queue.Dequeue();
                Console.WriteLine(node.Label);
                visited.Add(node);
                foreach (var connect in Edges[node])
                {
                    if (!visited.Contains(connect))
                        queue.Enqueue(connect);
                }

            }
        }
        public void TopologicalSort()
        {
            var stack = new Stack<Node>();
            var visited = new HashSet<Node>();
            foreach (var node in Nodes.Values)
                TopologicalSort(stack, node, visited);

            while (stack.Count != 0)
                Console.WriteLine(stack.Pop().Label);
        }
        private void TopologicalSort(Stack<Node> stack, Node node, HashSet<Node> visited)
        {
            if (visited.Contains(node))
                return;
            visited.Add(node);
            foreach (var connect in Edges[node])
                TopologicalSort(stack, connect, visited);

            stack.Push(node);
        }
        public bool HasCycle()
        {
            var visiting = new Dictionary<Node, Node>();
            var visited = new HashSet<Node>();
            foreach (var node in Nodes.Values)
            {
                if (HasCycle(visited, visiting, node, null))
                {
                    return true;
                }
            }
            return false;
        }
        private bool HasCycle(HashSet<Node> visited, Dictionary<Node, Node> visiting, Node node, Node parent)
        {
            if (visited.Contains(node))
                return false;
            if (visiting.ContainsKey(node))
                return true;
            visiting.Add(node, parent);
            foreach (var connect in Edges[node])
            {
                if (HasCycle(visited, visiting, connect, node))
                    return true;
            }
            visiting.Remove(node);
            visited.Add(node);

            return false;
        }
    }
}
