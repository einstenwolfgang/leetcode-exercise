public class Solution
{
    public bool WordBreak(string s, ISet<string> wordDict)
    {
        // Check Bad Input Values
        if (wordDict == null || wordDict.Count == 0)
            return false;
        if (string.IsNullOrEmpty(s))
            return wordDict.Contains(s);

        // Check the whole word first
        if (wordDict.Contains(s))
            return true;

        int n = s.Length;
        // Suppose i is the start of a word and j it's end with 0 < i <= j< n
        // Lets create a table C (n*n) that check if s(i,j) is breakable
        // We have this formula for C[i,j]
        // C[i,j] = C[i,j-1] and s[j,j] is in the dictionary
        // C[i,j] = s(i,j) is in dictionary
        // C[i,j] = C[i,k] and s(k+1,j) is in dictonary, 0<k<j
        bool[,] C = new bool[n, n]; // initialiazed to false;

        // Fill the diagonal by checking if a word i,i is in the dictionary
        for (int i = 0; i < n; ++i)
        {
            C[i, i] = wordDict.Contains(s.Substring(i, 1));
        }

        // Compute C[0,j] here
        for (int j = 1; j < n; ++j)
        {
            C[0, j] = C[0, j] ||
              (C[0, j - 1] && C[j, j]) || // C[i,j-1] and s[j,j] is in the dictionary
              wordDict.Contains(s.Substring(0, j + 1));//s(i,j) is in dictionary
            if (!C[0, j])
            {
                // Search for k: C[i,j] = C[i,k] and s(k+1,j) is in dictonary, 0<k<j
                int k = 0;
                while (k < j - 1 && !C[0, j])
                {
                    C[k + 1, j] = wordDict.Contains(s.Substring(k + 1, j - k));
                    C[0, j] = C[0, k] && C[k + 1, j];
                    ++k;
                }
            }
        }

        // Return true if s(0,n-1) is breakable
        return C[0, n - 1];
    }
}