using System;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int maxArea = 0;
            for (int i = 0; i < height.Length - 1; i++)
            {
                for (int j = i + 1; j < height.Length; j++)
                {
                    maxArea = Math.Max(Math.Min(height[i], height[j]) * (j - i), maxArea);
                }
            }
            return maxArea;
        }
        public int MaxAreaTwoPointers(int[] height)
        {
            int maxArea = 0, left = 0, right = height.Length - 1;
            while (left < right)
            {
                maxArea = Math.Max(maxArea, Math.Min(height[left], height[right]) * (right - left));
                if (height[left] < height[right])
                    left++;
                else
                    right--;
            }
            return maxArea;
        }
    }
}
