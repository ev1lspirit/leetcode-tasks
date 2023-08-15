public class Solution {
    public int MaximumUniqueSubarray(int[] nums)
    {
        if (nums.Length == 0) return 0;
        int windowStart = 0;
        int windowSize = 0;
        int maxSum = 0;
        int currentSum = 0;
        HashSet<int> numsInSublist = new HashSet<int>();

        while (windowSize < nums.Length)
        {
            if (numsInSublist.Contains(nums[windowSize]))
            {
                maxSum = Math.Max(maxSum, currentSum);
                currentSum -= nums[windowStart];
                numsInSublist.Remove(nums[windowStart]);
                windowStart++;
            }
            else
            {
                numsInSublist.Add(nums[windowSize]);
                currentSum += nums[windowSize];
                windowSize++;
            }
        }
        return Math.Max(maxSum, currentSum); 
    }
}