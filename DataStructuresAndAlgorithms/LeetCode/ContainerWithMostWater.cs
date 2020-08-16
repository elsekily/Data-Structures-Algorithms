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
                    var area = Math.Min(height[i], height[j]) * (j - i);
                    maxArea = area > maxArea ? area : maxArea;
                }
            }
            return maxArea;
        }
    }
}
