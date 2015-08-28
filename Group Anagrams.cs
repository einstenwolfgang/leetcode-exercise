public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<String, List<String>> map = new Dictionary<string, List<string>>();

        foreach (String s in strs)
        {
            char[] chars = s.ToCharArray();
            Array.Sort(chars);
            String tmp = new String(chars);
            if (map.ContainsKey(tmp))
            {
                map[tmp].Add(s);
            }
            else
            {
                List<String> list = new List<String>();
                list.Add(s);
                map.Add(tmp, list);
            }
        }

        IList<IList<String>> groups = new List<IList<string>>(map.Values);

        for (int i = 0; i < groups.Count; i++)
        {
            List<String> group = (List<String>)groups[i];
            String[] ss = group.ToArray();
            Array.Sort(ss);
            groups[i] = ss.ToList();
        }
        return groups;
    }
}