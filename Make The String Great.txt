public class Solution {
    public string MakeGood(string s) {
        var stack = new Stack<char>();
        string result = string.Empty;
        stack.Push(s[0]);
        
        for (int i = 1; i < s.Length; i++)
        {
            if (stack.Count > 0 && Math.Abs((int)s[i] - (int)stack.Peek()) == 32)
                stack.Pop();
            else 
                stack.Push(s[i]);
        }
        
        while (stack.Count > 0)
        {
            result = string.Concat(stack.Peek(), result);
            stack.Pop();
        }
    return result;
  }
}