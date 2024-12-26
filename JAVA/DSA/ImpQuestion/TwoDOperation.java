import java.util.ArrayList;
public class TwoDOperation 
{
    public static void main(String[] args) {
        int matrix[][] = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
        print2DArray(matrix, "Matrix");
        // transposeMatrix(matrix);
        // print2DArray(matrix, "Transpose Matrix");
        // rotateMatrix90CW(matrix);
        // print2DArray(matrix, "90CW rotated Matrix");
        // rotateMatrix90ACW(matrix);
        // print2DArray(matrix, "90ACW rotated Matrix");
        ArrayList<Integer>list = spiralMatrix(matrix);
        System.out.println("Spiral Matrix:-> "+list);
    }
    public static ArrayList<Integer>spiralMatrix(int[][]matrix){
        ArrayList<Integer>list = new ArrayList<>();
        int left = 0;
        int right = matrix[0].length-1;
        int top = 0;
        int bottom = matrix.length-1;
        while(left <= right && top <= bottom){
            for(int i=left;i<=right;i++){
                list.add(matrix[top][i]);
            }top++;
            for(int i=top;i<=bottom;i++){
                list.add(matrix[i][right]);
            }right--;
            for(int i=right;i>=left;i--){
                list.add(matrix[bottom][i]);
            }bottom--;
            for(int i=bottom;i>=top;i--){
                list.add(matrix[i][left]);
            }left++;
        }

        return list;
    }
    public static void print2DArray(int[][]A, String msg){
        System.out.println(msg+": ");
        for(int i=0;i<A.length;i++){
            for(int j=0;j<A[i].length;j++){
                System.out.print(A[i][j]);
                if(j!=A[i].length-1){
                    System.out.print(", ");
                }
            }System.out.println("");
        }
        System.out.println("");
    }
    public static void rotateMatrix90CW(int[][]matrix){
        transposeMatrix(matrix);
        for(int i=0;i<matrix.length;i++){
            for(int j=0;j<matrix[i].length/2;j++){
                swapMatrixElement(matrix,i, j, i, matrix[i].length-j-1);
            }
        }
    }
    public static void rotateMatrix90ACW(int[][]matrix){
        transposeMatrix(matrix);
        for(int i=0;i<matrix.length/2;i++){
            for(int j=0;j<matrix[i].length;j++){
                swapMatrixElement(matrix, i, j, matrix.length-i-1, j);
            }
        }
    }
    public static void transposeMatrix(int[][]matrix){
        for(int i=0;i<matrix.length;i++){
            for(int j=0;j<matrix[i].length;j++){
                if(i==j){
                    break;
                }
                swapMatrixElement(matrix, i, j, j, i);
            }
        }
    }
    public static void swapMatrixElement(int[][]matrix, int i, int j, int k, int l){
        int temp = matrix[i][j];
        matrix[i][j] = matrix[k][l];
        matrix[k][l] = temp;
    }   
}
