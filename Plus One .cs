public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        if (digits == null || digits.Length == 0)
            return digits;
        int carry = 1;
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            int digit = (digits[i] + carry) % 10;
            carry = (digits[i] + carry) / 10;
            digits[i] = digit;
            if (carry == 0)
                return digits;
        }
        int[] res = new int[digits.Length + 1];
        res[0] = 1;
        return res;
    }
}