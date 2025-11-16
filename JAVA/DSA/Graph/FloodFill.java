
import java.util.LinkedList;
import java.util.Queue;

public class FloodFill {
    public static void main(String[] args){
        int[][]mat = {
            {1, 1, 1},
            {1, 1, 0},
            {1, 0, 1}
        };
        print2DArray(mat, "Before FLood Fill");
        // floodFillUsingDFS(mat, 1, 1, 2);
        floodFillUsingBFS(mat, 1, 1, 2);
        print2DArray(mat, "After FLood Fill");
    }
    public static void floodFillUsingBFS(int[][]image, int sr, int sc, int color){
        class Number{
            int row;
            int col;
            Number(int row, int col){
                this.row = row;
                this.col = col;
            }
        }
        boolean visitedArray[][] = new boolean[image.length][image[0].length];
        Queue<Number>queue = new LinkedList<>();
        int original = image[sr][sc];
        visitedArray[sr][sc] = true;
        queue.offer(new Number(sr, sc));
        while(!queue.isEmpty()){
            Number number = queue.poll();
            int row = number.row;
            int col = number.col;
            visitedArray[row][col] = true;
            image[row][col] = color;
            if((row-1 != -1) && (!visitedArray[row-1][col]) && (image[row-1][col] == original)){
                queue.offer(new Number(row-1, col));
            }if((row+1 != image.length) && (!visitedArray[row+1][col]) && (image[row+1][col] == original)){
                queue.offer(new Number(row+1, col));
            }if((col-1 != -1) && (!visitedArray[row][col-1]) && (image[row][col-1] == original)){
                queue.offer(new Number(row, col-1));
            }if((col+1 != image[0].length) && (!visitedArray[row][col+1]) && (image[row][col+1] == original)){
                queue.offer(new Number(row, col+1));
            }
        }
    }
    public static void floodFillUsingDFS(int[][]image, int sr, int sc, int color){
        boolean visitedArray[][] = new boolean[image.length][image[0].length];
        dfs(image, sr, sc, color, visitedArray, image[sr][sc]);
    }
    public static void dfs(int[][]image, int row, int col, int color, boolean[][]visitedArray, int original){
        if(row == -1 || row == image.length || col == -1 || col == image[0].length || image[row][col] != original){
            return;
        }
        visitedArray[row][col] = true;
        image[row][col] = color;
        dfs(image, row-1, col, color, visitedArray, original);
        dfs(image, row, col-1, color, visitedArray, original);
        dfs(image, row+1, col, color, visitedArray, original);
        dfs(image, row, col+1, color, visitedArray, original);
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

}
