public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        List<string> res = new List<string>();
        string temp = "";
        generate(res, 0, 0, temp, n);
        return res;
    }

    void generate(List<string> res, int lh, int rh, string temp, int n)
    {
        if (lh == n)
        {
            for (int i = 0; i < n - rh; i++)
            {
                temp += ")";
            }
            res.Add(temp);
            return;
        }
        generate(res, lh + 1, rh, temp + "(", n);
        if (lh > rh) generate(res, lh, rh + 1, temp + ")", n);
    }
}