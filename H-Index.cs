public class Solution
{
    public int HIndex(int[] citations)
    {
        Array.Sort(citations);
        if (citations.Length < 1) return 0;
        for (int i = 0; i < citations.Length; i++)
        {
            if (citations[i] >= citations.Length - i) return citations.Length - i;
        }
        return 0;
    }
}