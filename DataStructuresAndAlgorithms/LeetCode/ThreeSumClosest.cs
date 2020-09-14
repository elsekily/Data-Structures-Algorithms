using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class ThreeSumClosest
    {
        public int Three_SumClosest(int[] nums, int target)
        {
            var min = 0;
            for (int i = 0; i < 3; i++)
            {
                min += nums[i];
            }

            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        var sum = nums[i] + nums[j] + nums[k];
                        if (sum == target)
                            return sum;

                        if (Math.Abs(target - sum) < Math.Abs(target - min))
                            min = sum;
                    }
                }
            }
            return min;
        }
    }
}
