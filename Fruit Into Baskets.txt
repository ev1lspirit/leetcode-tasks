public class Solution {
    public int TotalFruit(int[] fruitTrees)
    {
        int start = 0;
            Dictionary<int, int> set = new Dictionary<int, int>();
            int maxLen = 0;
            int size = 0;

            while (size < fruitTrees.Length)
            {
                if (set.ContainsKey(fruitTrees[size]))
                {
                    set[fruitTrees[size]]++;
    
                }
                else if (set.Count == 2)
                {
                    if (set[fruitTrees[start]] == 1)
                    {
                        set.Remove(fruitTrees[start]);
                    }
                    else set[fruitTrees[start]]--;
                    maxLen = Math.Max(maxLen, size - start);
                    start++;
                    size--;
                }
                else
                {
                    set.Add(fruitTrees[size], 1);
                }
                size++;
            }
            
        return Math.Max(maxLen, size- start);
    }
}