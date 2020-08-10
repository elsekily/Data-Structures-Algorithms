using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DataStructuresAndAlgorithms.DirectedGraphs
{
    internal class CompareEdge : IComparer<Edge>
    {
        public int Compare([AllowNull] Edge x, [AllowNull] Edge y)
        {
            return x.Weight.CompareTo(y.Weight);
        }
    }
}
