using System;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.DirectedGraphs
{
    public class DirectedGraph
    {
        private Dictionary<string, Node> Nodes { get; set; }
        public DirectedGraph()
        {
            Nodes = new Dictionary<string, Node>();
        }
        public int NodesCount()
        {
            return Nodes.Count;
        }
        public void AddNode(string label)
        {
            if (Nodes.ContainsKey(label))
                return;
            Nodes.Add(label, new Node(label));
        }
        public void AddEdge(string firstNode, string secondnode, int weight)
        {
            Nodes[firstNode].Edges.Add(new Edge(Nodes[firstNode], Nodes[secondnode], weight));
            Nodes[secondnode].Edges.Add(new Edge(Nodes[secondnode], Nodes[firstNode], weight));
        }
        public void Disp()
        {
            foreach (var node in Nodes.Values)
            {
                Console.Write("{0} >> [", node.Label);
                foreach (var edge in node.Edges)
                {
                    Console.Write("{0}{1}, ", node, edge);
                }
                if (node.Edges.Count != 0)
                    Console.Write("\b\b");
                Console.WriteLine("]");
            }
        }
        public void ShortestPath(string node1, string node2)
        {
            var from = Nodes[node1];
            var to = Nodes[node2];
            var queue = new SortedSet<NodeEntry>(new CompareNodes());
            var distances = new Dictionary<Node, int>();
            var previousNodes = new Dictionary<Node, Node>();
            var visited = new HashSet<Node>();
            foreach (var node in Nodes.Values)
            {
                previousNodes.Add(node, null);
                distances.Add(node, Int32.MaxValue);
            }
            distances[from] = 0;
            queue.Add(new NodeEntry(from, 0));
            while (queue.Count != 0)
            {
                var highEntryNode = queue.Min;
                queue.Clear();
                foreach (var edge in highEntryNode.Node.Edges)
                {
                    if (!visited.Contains(edge.To))
                    {
                        UpdateDistanceAndPrevious(previousNodes, distances, from, highEntryNode.Node, edge.To, edge.Weight);
                        queue.Add(new NodeEntry(edge.To, distances[edge.To]));
                    }
                }
                visited.Add(highEntryNode.Node);
            }

            Console.WriteLine("Shortest path from {0} to {1}", from, to);
            var current = to;
            var list = new LinkedList<Node>();
            list.AddFirst(current);
            while (current != from)
            {
                current = previousNodes[current];
                list.AddFirst(current);
            }
            Console.Write(list.First.Value);
            list.RemoveFirst();
            foreach (var item in list)
            {
                Console.Write(" -> {0}", item);
            }
        }
        private void UpdateDistanceAndPrevious(
            Dictionary<Node, Node> previousNodes, Dictionary<Node, int> distances,
            Node initailNode, Node current, Node edgeNode, int weight)
        {
            if (edgeNode == initailNode)
                return;
            var distance = weight + distances[current];
            if (distance < distances[edgeNode])
            {
                distances[edgeNode] = distance;
                previousNodes[edgeNode] = current;
            }
        }
        public bool HasCycle()
        {
            var Visiting = new HashSet<Node>();
            var visited = new HashSet<Node>();
            foreach (var node in Nodes.Values)
            {
                if (HasCycle(Visiting, visited, node, null))
                    return true;
            }
            return false;
        }
        private bool HasCycle(HashSet<Node> Visiting, HashSet<Node> visited, Node node, Node last)
        {
            if (Visiting.Contains(node))
                return true;
            if (visited.Contains(node))
                return false;

            Visiting.Add(node);
            foreach (var edge in node.Edges)
            {
                if (edge.To == last)
                    continue;

                if (HasCycle(Visiting, visited, edge.To, node))
                    return true;
            }
            visited.Add(node);
            Visiting.Remove(node);
            return false;
        }
        public DirectedGraph MinimumSpanningTree()
        {
            var queue = new SortedSet<Edge>(new CompareEdge());
            var visited = new HashSet<Node>();
            var paths = new DirectedGraph();

            var nodes = Nodes.Values.GetEnumerator();
            nodes.MoveNext();
            var node = nodes.Current;

            visited.Add(node);

            GetNodeEdges(node, queue);
            paths.AddNode(node.Label);

            while (paths.NodesCount() < Nodes.Count)
            {
                var next = queue.Min;
                queue.Remove(next);

                if (visited.Contains(next.To))
                    continue;

                visited.Add(next.To);
                GetNodeEdges(next.To, queue);

                paths.AddNode(next.To.Label);
                paths.AddEdge(next.From.Label, next.To.Label, next.Weight);

                node = next.To;
            }
            return paths;
        }
        private void GetNodeEdges(Node node, SortedSet<Edge> queue)
        {
            foreach (var edge in node.Edges)
                queue.Add(edge);
        }
    }
}
