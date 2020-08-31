namespace DataStructuresAndAlgorithms.LeetCode
{
    class TwoSumII
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            if (numbers == null || numbers.Length == 0)
                return new int[] { 0 };

            var pointer1 = 0;
            var pointer2 = numbers.Length - 1;

            while (pointer1 != pointer2)
            {
                var sum = numbers[pointer1] + numbers[pointer2];
                
                if (sum == target)
                    return new int[] { pointer1 + 1, pointer2 + 1 };

                if (sum > target)
                    pointer2--;

                if (sum < target)
                    pointer1++;
            }

            return new int[] { 0 };
        }
    }
}
