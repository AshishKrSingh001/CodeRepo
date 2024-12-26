public class MergeSortedArray {
    public static void mergeSortedArray(int[]A, int[]B, int[]res){
        int i=0, j=0, k=-1;
        while(i<A.length && j<B.length){
            if(A[i]<B[j]){
                res[++k] = A[i++];
            }else{
                res[++k] = B[j++];
            }
        }
        while(i<A.length){
            res[++k] = A[i++];
        }
        while(j<B.length){
            res[++k] = B[j++];
        }
    }
    public static void printArray(int A[], String msg){
        System.out.print(msg + "->{");
        for(int i=0;i<A.length;i++){
            System.out.print(A[i]);
            if(i!=A.length-1){
                System.out.print(", ");
            }
        }
        System.out.println("}");
    }
    public static void main(String[] args) {
        int A[] = {1, 5, 7, 10, 12, 13};
        int B[] = {2, 4, 5, 6, 8, 11};
        int res[] = new int[A.length+B.length];
        printArray(A, "Array One");
        printArray(B, "Array Two");
        mergeSortedArray(A, B, res);
        printArray(res, "Result Merged Array");
        
    }
}
