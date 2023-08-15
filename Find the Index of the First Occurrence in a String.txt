public class Solution {
    public int StrStr(string haystack, string needle)
        {
            HashSetstring hashSet = new HashSetstring();
            hashSet.Add(needle);

            int start = 0;
            int strLen = needle.Length;
            int size = strLen - 1;

            for (;size  haystack.Length; size++)
            {
                if (hashSet.Contains(haystack.Substring(start, strLen)))
                {
                    return start;
                }
                start++;
                
            }
            return -1;
    }
}