public class Solution
{
    public int LengthOfLastWord(string s)
    {
        if (s != null && s.Trim() != "")
        {
            string[] arr = s.Trim().Split(' ');
            int length = arr[arr.Length - 1].Length;
            return length;
        }
        return 0;
    }
}