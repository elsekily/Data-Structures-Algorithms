using System.Collections;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class LongestValidParentheses
    {
        public int MyLongestValidParentheses(string s)
        {
            if (s.Length == 0)
                return 0;

            var maxLength = 0;
            var length = 0;
            var stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if(s[i]=='(')
                    stack.Push(s[i]);

                if (s[i] == ')')
                {
                    if (stack.Count == 0 && i == 0)
                        continue;

                    if(stack.Count==0 && length != 0)
                    {
                        maxLength = maxLength < length ? length : maxLength;
                        length = 0;
                        continue;
                    }

                    if (length != 0 && stack.Peek() == '(')
                    {
                        length += 2;
                        stack.Pop();
                    }
                    
                }
            }
            maxLength = maxLength < length ? length : maxLength;
            return maxLength;
        }
    }
}
