public class Solution
{
    public bool IsValid(string s)
    {
        if (s == null || s.Length < 1) return false;
        //if(s.Length % 2!= 0)return false;
        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(') stack.Push(')');
            //else if(s[i] == '(')stack.Push(')');
            else if (s[i] == '{') stack.Push('}');
            else if (s[i] == '[') stack.Push(']');
            else if (stack.Peek() == null || s[i] != stack.Peek()) return false;
            else stack.Pop();

        }
        return stack.Count == 0;
    }
}