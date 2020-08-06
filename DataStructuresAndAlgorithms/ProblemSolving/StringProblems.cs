using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructuresAndAlgorithms.ProblemSolving
{
    class StringProblems
    {
        public char FirstNonRepeatedChar(string input)
        {
            var lowerCaseInput = input.ToLower();
            var dictionary = new Dictionary<char, int>();
            foreach (var letter in lowerCaseInput)
            {
                if (dictionary.ContainsKey(letter))
                    dictionary[letter]++;
                else
                    dictionary.Add(letter, 1);
            }
            foreach (var item in dictionary)
            {
                if (dictionary[item.Key] == 1)
                    return item.Key;
            }
            return char.MinValue;
        }
        public char FirstRepeatedChar(string input)
        {
            var lowerCaseInput = input.ToLower();
            var set = new HashSet<char>();
            foreach (var letter in lowerCaseInput)
            {
                if (set.Contains(letter))
                    return letter;

                set.Add(letter);
            }
            return char.MinValue;
        }
    }
}
