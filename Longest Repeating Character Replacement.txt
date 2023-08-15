public class Solution {
    public int CharacterReplacement(string str, int k)
        {
            int windowStart = 0;
            int windowSize = 0;
            int length = 0;
            char mostFrequentChar = str[0];
            Dictionary<char, int> symbolsInSubstring = new Dictionary<char, int>();

            for (windowSize = 0;  windowSize < str.Length; windowSize++)
            {
                if (!symbolsInSubstring.TryAdd(str[windowSize], 1))
                {
                    symbolsInSubstring[str[windowSize]]++;
                }
                if (symbolsInSubstring[str[windowSize]] > symbolsInSubstring[mostFrequentChar])
                {
                    mostFrequentChar = str[windowSize];
                }
                if (windowSize - windowStart + 1 - symbolsInSubstring[mostFrequentChar] > k)
                {
                    length = Math.Max(length, windowSize - windowStart);
                    symbolsInSubstring[str[windowStart]] -= 1;
                    windowStart++;
                }
            }
            return Math.Max(length, windowSize - windowStart);
    }
}