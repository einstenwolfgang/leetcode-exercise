public class Solution
{
    public bool IsValidSudoku(char[,] board)
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (board[i, j] == '.')
                    continue;
                char tmp = board[i, j];
                board[i, j] = 'C';
                bool tr = isValid(board, i, j, tmp);
                board[i, j] = tmp;
                if (tr == false)
                    return tr;
            }
        }
        return true;
    }

    public bool isValid(char[,] board, int x, int y, char tmp)
    {
        for (int i = 0; i < 9; i++)
        {
            if (board[x, i] == tmp || board[i, y] == tmp)
                return false;
        }

        int start_x = x / 3;
        int start_y = y / 3;
        for (int i = 0; i < 9; i++)
        {
            int cur_x = start_x * 3 + i / 3;
            int cur_y = start_y * 3 + i % 3;
            if (board[cur_x, cur_y] == tmp)
                return false;
        }
        return true;

    }

}

