using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.LeetCode
{
    /*
     Given an array of integers, return indices of the two numbers 
        such that they add up to a specific target.
      You may assume that each input would have exactly one solution,
        and you may not use the same element twice.
    Example:
        Given nums = [2, 7, 11, 15], target = 9,
        Because nums[0] + nums[1] = 2 + 7 = 9,
        return [0, 1].
    */
    class TwoSum
    {
        public int[] Solution(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };
                }
            }
            return new int[] { 0 };
        }
        public int[] Two_passHashTableSolution(int[] nums, int target)
        {
            var map = new Dictionary<int,int>();
            for (int i = 0; i < nums.Length; i++)
            {
                map.Add(nums[i], i);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement) && map[complement] != i)
                {
                    return new int[] { i, map[complement] };
                }
            }
            throw new InvalidOperationException("No two sum solution");
        }
    }
}
