public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int windowStart = 0;
        int windowSize = 0;
        int length = 0;
        int oneCount = 0;
       // Dictionary<int, int> oneCount = new Dictionary<int, int>();
        
        while (windowSize < nums.Length)
        {
            if (nums[windowSize] == 1)
            {
                oneCount++;
            }
            if (windowSize - windowStart + 1 - oneCount > k)
            {
                length = Math.Max(length, windowSize - windowStart);
                if (nums[windowStart] == 1)
                {
                    oneCount--;
                }
                windowStart++;
                continue;
            }
            windowSize++;
        }
        return Math.Max(length, windowSize - windowStart);
    }
}