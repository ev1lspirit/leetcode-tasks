public class Solution {
    public int LengthOfLongestSubstring(string str)
    {
        if (str.Length == 0) return 0;
        int windowStart = 0;
        HashSet<char> letters = new HashSet<char>();
        int maxLength = 0;
        int windowSize = 0;

        while (windowSize < str.Length)
        {
            if (letters.Contains(str[windowSize]))
            {
                maxLength = Math.Max(maxLength, windowSize - windowStart);
                letters.Remove(str[windowStart]);
                windowStart++;
            }
            else
            {
                letters.Add(str[windowSize]);
                windowSize++;
            }
        }  
        maxLength = Math.Max(maxLength, windowSize - windowStart);
        return maxLength == 0 ? str.Length : maxLength;
    }
}