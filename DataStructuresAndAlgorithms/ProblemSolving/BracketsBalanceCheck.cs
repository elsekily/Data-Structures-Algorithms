using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.ProblemSolving
{
    public class BracketsBalanceCheck
    {
        private List<char> leftBracket;
        private List<char> rightBracket;
        public BracketsBalanceCheck()
        {
            leftBracket = new List<char>()
            {
                '(', '<', '{', '['
            };
            rightBracket = new List<char>()
            {
                ')', '>', '}', ']'
            };
        }
        public bool CheckBalance(string input)
        {
            //60,62,91,93,40,41
            if (input == null)
                throw new Exception();

            var stack = new Stack<char>();
            foreach (var item in input)
            {
                if (leftBracket.Contains(item))
                {
                    stack.Push(item);
                }
                if (rightBracket.Contains(item))
                {
                    if (stack.Count == 0)
                        return false;
                    if (leftBracket.IndexOf(stack.Peek()) != rightBracket.IndexOf(item))
                        return false;
                    stack.Pop();
                }
            }
            if (stack.Count > 0)
                return false;
            return true;
        }
    }
}
