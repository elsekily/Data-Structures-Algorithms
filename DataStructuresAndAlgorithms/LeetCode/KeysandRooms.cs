using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class KeysandRooms
    {
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            var set = new HashSet<int>();
            var stack = new Stack<int>();
            stack.Push(0);
            while (stack.Count != 0)
            {
                var index = stack.Pop();
                if(!set.Contains(index))
                {
                    set.Add(index);
                    for (int i = 0; i < rooms[index].Count; i++)
                    {
                        stack.Push(rooms[index][i]);
                    }
                }
            }
            return set.Count == rooms.Count;
        }
    }
}