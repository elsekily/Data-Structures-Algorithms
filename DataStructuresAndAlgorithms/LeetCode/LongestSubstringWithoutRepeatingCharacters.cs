using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0)
                return 0;

            var words = new List<string>();
            var set = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                set.Clear();
                set.Add(s[i]);
                var word = new StringBuilder();
                word.Append(s[i]);
                for (int j = i + 1; j < s.Length; j++)
                {
                    if(!set.Contains(s[j]))
                    {
                        set.Add(s[j]);
                        word.Append(s[j]);
                    }
                    else
                    {
                        break;
                    }
                }
                words.Add(word.ToString());
            }
            var output = words[0].Length;
            foreach (var word in words)
            {
                Console.WriteLine(word);
                output = word.Length > output ? word.Length : output;
            }
            return output;
        }
        public int LengthOfLongestSubstring1(String s)
        {
            int n = s.Length;
            int ans = 0;
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j <= n; j++)
                    if (AllUnique(s, i, j)) ans = Math.Max(ans, j - i);
            return ans;
        }
        private bool AllUnique(String s, int start, int end)
        {
            var set = new HashSet<char>();
            for (int i = start; i < end; i++)
            {
                char ch = s[i];
                if (set.Contains(ch)) return false;
                set.Add(ch);
            }
            return true;
        }
        public int LengthOfLongestSubstring2(String s)
        {
            int n = s.Length;
            var set = new HashSet<char>();
            int ans = 0, i = 0, j = 0;
            while (i < n && j < n)
            {
                // try to extend the range [i, j]
                if (!set.Contains(s[j]))
                {
                    set.Add(s[j++]);
                    ans = Math.Max(ans, j - i);
                }
                else
                {
                    set.Remove(s[i++]);
                }
            }
            return ans;
        }
    }
}
