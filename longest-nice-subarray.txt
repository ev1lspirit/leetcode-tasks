public class Solution {
    public int LongestNiceSubarray(int[] nums)
        {
            int windowStart = 0;
            int windowSize = 0;
            int len = 1;
            bool interrupted = false;

            while (windowSize < nums.Length)
            {
                for (int i = windowStart; i < windowSize; ++i)
                {
                    if ((nums[i] & nums[windowSize]) != 0)
                    {
                        len = Math.Max(len, windowSize - windowStart);
                        windowStart++;
                        interrupted = true;
                        break;
                    }
                }
                
                if (interrupted == true)
                {
                    interrupted = false;
                }
                else
                {
                    windowSize++;
                }
            }
            return Math.Max(len, windowSize - windowStart); ;
        }
}