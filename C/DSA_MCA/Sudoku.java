public class Sudoku 
{
    public static void main(String[] args) 
    {
        int[][] board = new int[][] {{0, 2, 3, 0},
                                    { 0, 0, 0, 1 },
                                    { 0, 1, 0, 0 },
                                    { 2, 4, 1, 0 }};
        printSudoko(board);                           
        sudokuFill(board);
        printSudoko(board);
    }
    public static boolean sudokuFill(int[][]board)
    {
        // take length of board
        int N = board.length;

        boolean isEmpty = true;
        int row = -1;
        int col = -1;
        for(int i=0;i<N;i++)
        {
            for(int j=0;j<N;j++)
            {
                if(board[i][j] == 0)
                {
                    row = i;
                    col = j;
                    isEmpty = false;
                    break;
                }
            }
            if(!isEmpty)
            {
                break;
            }
        }
        if(isEmpty)
        {
            return true;
        }
        for(int i=1;i<=N;i++)
        {
            if(isSafePosition(board, row, col, i))
            {
                board[row][col] = i;

                if (sudokuFill(board))
                {
                    return true;
                } 
                else 
                {
                    board[row][col] = 0; 
                }
            }
        }
          
        return false;
    }
    public static boolean isSafePosition(int[][]board, int row, int col, int val)
    {
        // take length of board
        int N = board.length;
        // checking for row
        for(int i=0;i<N;i++)
        {
            if(board[row][i] == val)
            {
                return false;
            }
        }
        
        // checking for column
        for(int i=0;i<N;i++)
        {
            if(board[i][col] == val)
            {
                return false;
            }
        }
        
        // checking for box
        int sqrt = (int)Math.sqrt(board.length);
        int rowStart = row - (row % sqrt);
        int rowEnd = rowStart + sqrt;
        int colStart = col - (col % sqrt);
        int colEnd = colStart + sqrt;
        
        for(int i=rowStart;i<rowEnd;i++)
        {
            for(int j=colStart;j<colEnd;j++)
            {
                if(board[i][j] == val)
                {
                    return false;
                }
            }
        }
        return true;
    }
    public static void printSudoko(int[][]board)
    {
        int N = board.length;
        System.out.println("****************************SUDOKO_START***************************");
        for(int i=0;i<N;i++)
        {
            for(int j=0;j<N;j++)
            {
                System.out.print(board[i][j]);
                if(j!=N-1)
                {
                    System.out.print(", ");
                }
            }
            System.out.println("");
        }
        System.out.println("******************************SUDOKO_END**************************");
    }
}
