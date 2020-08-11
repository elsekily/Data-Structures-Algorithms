using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class RomantoInteger
    {
        private Dictionary<char, int> symbolValue;
        public RomantoInteger()
        {
            symbolValue = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
        }
        public int RomanToInt(string s)
        {
            if (s.Length == 0 || s == null)
                return 0;

            return RomanToInt(s, 0, s.Length - 1);
        }
        private int RomanToInt(string s, int start, int end)
        {
            if (start == end) 
                return symbolValue[s[start]];


            var subValue = RomanToInt(s, start + 1, end);

            var symboltoValue = symbolValue[s[start]];

            if (symboltoValue == subValue || symboltoValue == symbolValue[s[start + 1]])
                return subValue + symboltoValue;

            if (symboltoValue > subValue)
                return symboltoValue + subValue;

            return subValue - symboltoValue;
        }
    }
}