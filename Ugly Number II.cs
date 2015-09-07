public class Solution
{
    public int NthUglyNumber(int n)
    {
        if (n == 0) return 0;
        List<int> l1 = new List<int>();
        List<int> l2 = new List<int>();
        List<int> l3 = new List<int>();

        l1.Add(1); l2.Add(1); l3.Add(1);
        int u = 0;
        for (int i = 0; i < n; i++)
        {
            u = Math.Min(Math.Min(l1[0], l2[0]), l3[0]);
            if (u == l1[0]) l1.RemoveAt(0);
            if (u == l2[0]) l2.RemoveAt(0);
            if (u == l3[0]) l3.RemoveAt(0);

            l1.Add(u * 2);
            l2.Add(u * 3);
            l3.Add(u * 5);
        }
        return u;
    }
}