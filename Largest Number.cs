public class Solution
{
    public String LargestNumber(int[] num)
    {
        int n = num.Length;
        if (n < 1) return "";

        //������ת��Ϊ�ַ�������  
        String[] strs = new String[n];
        for (int i = 0; i < n; i++)
        {
            strs[i] = num[i].ToString();
        }

        //���������ڽ���е�λ������  
        Array.Sort(strs, new Cmp());

        //�������ַ���ƴ����һ��  
        String ans = "";
        for (int i = n - 1; i >= 0; i--)
        {
            ans += strs[i];
        }

        //ȥ�����ֿ�ͷ��0��������[0, 0]  
        int m = 0;
        while (m < n && ans[m] == '0')
        {
            m++;
        }
        if (m == n) return "0";

        return ans.Substring(m);
    }

    class Cmp : IComparer<string>
    {

        public int Compare(String a, String b)
        {
            String ab = a + b;
            String ba = b + a;
            if (double.Parse(ab) - double.Parse(ba) > 0) return 1;
            if (double.Parse(ab) - double.Parse(ba) == 0) return 0;
            else return -1;
        }

    }
}