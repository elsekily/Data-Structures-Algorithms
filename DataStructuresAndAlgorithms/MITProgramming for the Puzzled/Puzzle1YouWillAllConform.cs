using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace DataStructuresAndAlgorithms.MITProgramming_for_the_Puzzled
{
    public class Puzzle1YouWillAllConform
    {
        public void PleaseConfirm(char[] caps)
        {
            int start = 0;
            int forward = 0;
            int backward = 0;
            var intervals = new Dictionary<int[],char>();
            for (int i = 1; i < caps.Length; i++)
            {
                if (caps[i] != caps[start])
                {
                    AddInterval(intervals, caps, start, i - 1, ref forward, ref backward);
                    start = i;
                }                
            }
            AddInterval(intervals, caps, start, caps.Length - 1, ref forward, ref backward);

            Console.WriteLine(forward);
            Console.WriteLine(backward);
            foreach (var item in intervals)
            {
                Console.WriteLine("\"{0}\":  {1} => {2}",item.Value, item.Key[0], item.Key[1]);
            }
        }
        private void AddInterval(Dictionary<int[], char> intervals, char[] caps, int start, int end,
            ref int forward, ref int backward)
        {
            intervals.Add(new int[] { start, end }, caps[start]);
            if (caps[start] == 'F')
                forward++;
            else
                backward++;
        }
    }
}
