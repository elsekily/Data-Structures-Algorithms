namespace DataStructuresAndAlgorithms.DirectedGraphs
{
    internal class Edge
    {
        public Node From { get; set; }
        public Node To { get; set; }
        public int Weight { get; set; }

        public Edge(Node from, Node to, int weight)
        {
            From = from;
            this.To = to;
            this.Weight = weight;
        }

        public override string ToString()
        {
            return "=>" + To.ToString();
        }
    }
}
