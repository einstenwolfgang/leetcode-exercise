public class Solution
{
    public IList<string> FindRepeatedDnaSequences(string s)
    {
        IList<string> ans = new List<string>();
        Dictionary<int, int> map = new Dictionary<int, int>();
        int key = 0;
        for (int i = 0; i < s.Length; i++)
        {
            key = ((key << 3) | (s[i] & 0x7)) & 0x3fffffff;
            if (i < 9) continue;
            if (!map.ContainsKey(key))
            {
                map.Add(key, 1);
            }
            else if (map[key] == 1)
            {
                ans.Add(s.Substring(i - 9, i + 1));
                map.Add(key, 2);
            }
        }
        return ans;
    }
}