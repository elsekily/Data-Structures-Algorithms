using System.Collections.Generic;
using System.Linq;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class HandofStraights
    {
        public bool IsNStraightHand(int[] hand, int W)
        {
            var dict = new Dictionary<int, int>();
            foreach (var card in hand)
            {
                if (dict.ContainsKey(card))
                    dict[card]++;
                else
                    dict.Add(card, 1);
            }
            while (dict.Count != 0)
            {
                int first = dict.First().Key;
                for (int i = first; i < first + W; i++) 
                {
                    if (!dict.ContainsKey(i))
                        return false;

                    if (dict[i] == 1)
                        dict.Remove(i);
                    else
                        dict[i]--;
                }
            }

            return true;
        }
    }
}
