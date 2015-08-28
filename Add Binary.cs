public class Solution
{
    public string AddBinary(string a, string b)
    {
        if (a == null || a.Length < 1) return b;
        if (b == null || b.Length < 1) return a;
        int i = a.Length - 1;
        int j = b.Length - 1;
        int carry = 0;
        StringBuilder res = new StringBuilder();
        while (i >= 0 && j >= 0)
        {
            int digit = a[i] - '0' + b[j] - '0' + carry;
            carry = digit / 2;
            digit %= 2;
            res.Append(digit);
            i--;
            j--;
        }
        while (i >= 0)
        {
            int digit = a[i] - '0' + carry;
            carry = digit / 2;
            digit %= 2;
            res.Append(digit);
            i--;
        }
        while (j >= 0)
        {
            int digit = b[j] - '0' + carry;
            carry = digit / 2;
            digit %= 2;
            res.Append(digit);
            j--;
        }
        if (carry > 0) res.Append(carry);
        StringBuilder sb = new StringBuilder();
        for (int m = res.Length - 1; m >= 0; m--)
        {
            sb.Append(res[m]);
        }
        return sb.ToString();
    }
}