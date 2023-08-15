public class Solution {
    public bool CheckIfExist(int[] arr) {
       var dict = new HashSet<int>(arr);
        bool morethanone = false;
       
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
            {
                if (!morethanone) 
                {
                    morethanone = true;
                    continue;
                }
            }
            if (dict.Contains(2 * arr[i])) return true;
        }
       return false;
    }
}