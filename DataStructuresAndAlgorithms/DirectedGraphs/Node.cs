using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.DirectedGraphs
{
    internal class Node
    {
        public string Label { get; set; }
        public HashSet<Edge> Edges { get; set; }
        public Node(string label)
        {
            Label = label;
            Edges = new HashSet<Edge>();
        }
        public override string ToString()
        {
            return Label;
        }
    }
}
