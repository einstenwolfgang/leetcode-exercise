public class Solution
{
    public int Divide(int dividend, int divisor)
    {
        try
        {
            int result = dividend / divisor;
            return result;
        }
        catch (Exception)
        {
            return int.MaxValue;
        }

    }
}