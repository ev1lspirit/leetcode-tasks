public class Solution {
    public int MinOperations(int[] nums, int x)
        {
            int subarraySum = nums.Sum() - x;
            if (subarraySum < 0) return -1;
            else if (subarraySum == 0) return nums.Length;
        
            int windowSum = 0;
            int windowStart = 0;
            int windowSize = 0;
            int length = 0;

            while (windowSize < nums.Length)
            {
                if (windowSum < subarraySum)
                {
                    windowSum += nums[windowSize];
                    windowSize++;
                    continue;
                }
                if (windowSum == subarraySum)
                {
                    length = Math.Max(length, windowSize - windowStart);
                }
                windowSum -= nums[windowStart];
                windowStart++;
            }
        
            for (;windowStart < windowSize; ++windowStart)
            {
                if (windowSum == subarraySum)
                {
                    length = Math.Max(length, windowSize - windowStart);
                    break;
                }
                windowSum -= nums[windowStart];
            }

            if (length == 0)
            {
                return -1;
            }
            return nums.Length - length;
    }
}