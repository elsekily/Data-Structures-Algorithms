﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.LeetCode
{
    /*
     Given a 32-bit signed integer, reverse digits of an integer.

        Example 1:

        Input: 123
        Output: 321

        Example 2:

        Input: -123
        Output: -321

        Example 3:

        Input: 120
        Output: 21

    Note:
        Assume we are dealing with an environment which could only
        store integers within the 32-bit signed integer range: [−231,  231 − 1]. 
        For the purpose of this problem, assume that your function returns 0
        when the reversed integer overflows.
      */
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            var output = 0;
            while(x!=0)
            {
                checked
                {
                    try
                    {
                        output *= 10;
                        output += x % 10;
                        x /= 10;
                    }
                    catch
                    {
                        return 0;
                    }
                }
            }
            return output;
        }
    }
}
