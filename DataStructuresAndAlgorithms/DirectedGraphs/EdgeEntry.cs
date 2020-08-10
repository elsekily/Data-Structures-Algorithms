namespace DataStructuresAndAlgorithms.DirectedGraphs
{
    internal class EdgeEntry
    {
        public EdgeEntry(Edge edge, int priority)
        {
            Edge = edge;
            Priority = priority;
        }

        public Edge Edge { get; set; }
        public int Priority { get; set; }
    }
}
