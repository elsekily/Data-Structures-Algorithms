namespace DataStructuresAndAlgorithms.DirectedGraphs
{
    internal class NodeEntry
    {
        public NodeEntry(Node node, int priority)
        {
            Node = node;
            Priority = priority;
        }
        public Node Node { get; set; }
        public int Priority { get; set; }
    }
}
