public class Solution
{
    public int ComputeArea(int A, int B, int C, int D, int E, int F, int G, int H)
    {
        int AreaA = (C - A) * (D - B);
        int AreaB = (G - E) * (H - F);
        int A1 = Math.Max(A, E); int A2 = Math.Max(B, F); int B1 = Math.Min(C, G); int B2 = Math.Min(D, H);
        int result = AreaA + AreaB;
        if (B2 <= A2 || B1 <= A1) return result;
        return result = result - (B1 - A1) * (B2 - A2);
    }
}