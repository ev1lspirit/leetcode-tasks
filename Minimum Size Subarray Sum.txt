public class Solution {
    public int MinSubArrayLen(int target, int[] nums)
        {
            int windowSize = 0;
            int windowStart = 0;
            int windowSum = 0;
            int length = Int32.MaxValue;

            while (windowSize < nums.Length)
            {
                if (windowSum < target)
                {
                    windowSum += nums[windowSize];
                    windowSize++;
                }
                else
                {
                    length = Math.Min(length, windowSize - windowStart);
                    windowSum -= nums[windowStart];
                    windowStart++;
                }
            }

            while (windowStart < windowSize)
            {
                if (windowSum >= target)
                {
                    length = Math.Min(length, windowSize - windowStart);
                    windowSum -= nums[windowStart];
                    windowStart++;
                }
                else
                {
                    break;
                }
            }
            return length == Int32.MaxValue ? 0 : length;
        }
}