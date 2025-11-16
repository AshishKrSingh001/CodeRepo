#include <stdio.h>
#include <math.h>
#define N 9

void inputSudoku(int board[][N])
{
    printf("\nEnter An empty SUDOKU\n");
    for(int i=0;i<N;i++)
    {
        for(int j=0;j<N;j++)
        {
            scanf("%d", &board[i][j]);
        }
    }
}
int isSafePosition(int board[][N], int row, int col, int val)
{
    for(int i=0;i<N;i++)
    {
        if(board[row][i] == val)
        {
            return 0;
        }
    }

    for(int i=0;i<N;i++)
    {
        if(board[i][col] == val)
        {
            return 0;
        }
    }

    int sq = (int)sqrt(N);
    int rowStart = row - (row % sq);
    int colStart = col - (col % sq);
    int rowEnd = rowStart + sq;
    int colEnd = colStart + sq;

    for(int i=rowStart;i<rowEnd;i++)
    {
        for(int j=colStart;j<colEnd;j++)
        {
            if(board[i][j] == val)
            {
                return 0;
            }
        }
    }
    return 1;
}
void printSudoku(int board[][N])
{
    printf("\n********************SUDOKU_START********************\n");
    for(int i=0;i<N;i++)
    {
        for(int j=0;j<N;j++)
        {
            printf("%d", board[i][j]);
            if(j != N-1)
            {
                printf(", ");
            }
        }
        printf("\n");
    }
    printf("********************SUDOKU_END********************\n");
}
int sudokuAutomation(int board[][N])
{
    int isEmpty = 1;
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
                isEmpty = 0;
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
        return 1;
    }
    for(int i=1;i<=N;i++)
    {
        if(isSafePosition(board, row, col, i) == 1)
        {
            board[row][col] = i;
            if(sudokuAutomation(board))
            {
                return 1;
            }
            else
            {
                board[row][col] = 0;
            }
        }
    }
    return 0;
}

int main()
{
    int sudokuGrid[9][9] = {
        {1, 0, 0, 0, 0, 0, 7, 0, 0},
        {0, 2, 0, 4, 0, 0, 0, 0, 6},
        {0, 8, 0, 3, 6, 0, 0, 0, 0},
        {0, 0, 0, 7, 8, 0, 2, 1, 0},
        {5, 0, 0, 0, 9, 0, 0, 0, 0},
        {9, 0, 0, 0, 0, 0, 0, 0, 0},
        {2, 4, 1, 0, 0, 0, 0, 0, 0},
        {0, 0, 3, 0, 0, 1, 4, 6, 7},
        {0, 0, 0, 8, 4, 3, 0, 0, 0}
    };
    printSudoku(sudokuGrid);
    printf("%d",sudokuAutomation(sudokuGrid));
    printSudoku(sudokuGrid);
    return 0;
}
