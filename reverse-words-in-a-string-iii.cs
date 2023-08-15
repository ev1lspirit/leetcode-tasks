public class Solution {
    public void reverse(char[] wordArray, int start, int end)
    {
        end--;
        while (start < end)
        {
            char temporary = wordArray[start];
            wordArray[start] = wordArray[end];
            wordArray[end] = temporary;
            start++;
            end--;
        }
    }
    public string ReverseWords(string s) {
        if (s.Length == 1) return s;
        int start = 0;
        int end = 0;
        char[] wordArray = s.ToCharArray();
        
        while (end < s.Length)
        {
            if (s[end] == (char)32)
            {
                reverse(wordArray, start, end);
                end++;
                start = end;
            }
            end++;
        }
        reverse(wordArray, start, end);
        return new string(wordArray);
    }
}