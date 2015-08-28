public class Solution
{
    public string CountAndSay(int n)
    {
        int count = 1;
        string res = "1";
        while (count < n)
        {
            res = revolution(res);
            count++;
        }
        return res;
    }

    string revolution(string s)
    {
        char pre = s[0];
        int count = 1;
        string res = "";
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == pre)
            {
                count++;
            }
            else
            {
                res += count.ToString() + pre;
                pre = s[i];
                count = 1;
            }
        }
        res += count.ToString() + pre;
        return res;
    }
}