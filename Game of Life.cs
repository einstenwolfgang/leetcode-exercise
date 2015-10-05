public class Solution
{
    public void GameOfLife(int[,] board)
    {
        int m = board.GetLength(0);
        int n = board.GetLength(1);
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int lives = countSurrounding(board, i, j);
                if (board[i, j] == 1)
                {
                    board[i, j] = (lives < 2 || lives > 3) ? 3 : 1;
                }
                else
                {
                    board[i, j] = lives == 3 ? 2 : 0;
                }
            }
        }
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (board[i, j] == 2) board[i, j] = 1;
                else if (board[i, j] == 3) board[i, j] = 0;
            }
        }
        return;
    }

    int countLive(int[,] board, int i, int j)
    {
        if (i < 0 || j < 0 || i >= board.GetLength(0) || j >= board.GetLength(1)) return 0;
        return board[i, j] % 2;
    }

    int countSurrounding(int[,] board, int i, int j)
    {
        int lives = 0;
        lives += countLive(board, i - 1, j);
        lives += countLive(board, i + 1, j);
        lives += countLive(board, i, j - 1);
        lives += countLive(board, i, j + 1);
        lives += countLive(board, i - 1, j - 1);
        lives += countLive(board, i - 1, j + 1);
        lives += countLive(board, i + 1, j - 1);
        lives += countLive(board, i + 1, j + 1);
        return lives;
    }
}