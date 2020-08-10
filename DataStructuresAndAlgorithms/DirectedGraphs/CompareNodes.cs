using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DataStructuresAndAlgorithms.DirectedGraphs
{
    internal class CompareNodes : IComparer<NodeEntry>
    {
        public int Compare([AllowNull] NodeEntry x, [AllowNull] NodeEntry y)
        {
            return x.Priority.CompareTo(y.Priority);
        }
    }
}
