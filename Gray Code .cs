public class Solution
{
    public IList<int> GrayCode(int n)
    {
        if (n == 0)
        {
            List<int> result = new List<int>();
            result.Add(0);
            return result;
        }

        List<int> tmp = (List<int>)GrayCode(n - 1);
        int addNumber = 1 << (n - 1);
        List<int> res = new List<int>(tmp);
        for (int i = tmp.Count - 1; i >= 0; i--)
        {
            res.Add(addNumber + tmp[i]);
        }
        return res;
    }
}