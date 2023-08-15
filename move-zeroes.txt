public class Solution {
    public void MoveZeroes(int[] nums) {
        int zeroCount = 0;
        int counter = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[counter] = nums[i];
                counter++;
            }
           
        }
        Console.WriteLine(counter);
        for (int i = counter; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}