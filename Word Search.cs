public class Solution
{
    bool[,] visited;

    public bool Exist(char[,] board, string word)
    {
        int m = board.GetLength(0);
        int n = board.GetLength(1);
        visited = new bool[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (word[0] == board[i, j] && search(word, board, i, j, 0)) return true;
            }
        }
        return false;
    }

    bool search(string word, char[,] board, int i, int j, int index)
    {
        if (index == word.Length) return true;
        if (i < 0 || i >= board.GetLength(0) || j < 0 || j >= board.GetLength(1) || visited[i, j] || board[i, j] != word[index]) return false;
        visited[i, j] = true;
        if (search(word, board, i - 1, j, index + 1) ||
        search(word, board, i, j + 1, index + 1) ||
        search(word, board, i, j - 1, index + 1) ||
        search(word, board, i + 1, j, index + 1)
        ) return true;

        visited[i, j] = false;
        return false;
    }
}