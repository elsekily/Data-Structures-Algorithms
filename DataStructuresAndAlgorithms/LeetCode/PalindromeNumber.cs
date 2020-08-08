using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.LeetCode
{
    class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0))
                return false;
            var str = x.ToString();
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                    return false;
            }
            return true;
        }
        public bool AnotherSolution(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0)) 
                return false;

            int revertedNumber = 0;
            while (x > revertedNumber) 
            {
                revertedNumber = revertedNumber * 10 + x % 10;
                x /= 10;
            }
            
            return x == revertedNumber || x == revertedNumber / 10;
        }
    }
}
