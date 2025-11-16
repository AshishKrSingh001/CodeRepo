public class Searching 
{
    public static void main(String[]args){
        int A[] = {2, 3, 5, 7, 11, 16, 19, 24, 30};
        printArray(A, "Array Element");
        linearSearch(A, 24);
        binarySearch(A, 24);
        ternarySearch(A, 24);
    }
    public static void printArray(int[]A, String msg){
        System.out.print(msg + " ->{");
        for(int i=0;i<A.length;i++){
            System.out.print(A[i]);
            if(i!=A.length-1){
                System.out.print(", ");
            }
        }
        System.out.println("}");
    }
    public static void ternarySearch(int[]A, int searchValue){
        int start=0;
        int end = A.length-1;
        while(start<=end){
            int mid1 = start + (end - start)/3;
            int mid2 = end -  (end - start)/3;
            if(A[mid1] >= searchValue){
                if(A[mid1] == searchValue){
                    System.out.println("Found at "+mid1+" index");
                    return;
                }end = mid1 - 1;
            }else if(A[mid2] <= searchValue){
                if(A[mid2] == searchValue){
                    System.out.println("Found at "+mid1+" index");
                    return;
                }start = mid2 + 1;
            }else{
                start = mid1+1;
                end = mid2-1;
            }
        }
        System.out.println("Not found");
    }
    public static void binarySearch(int[]A, int searchValue){
        int start=0;
        int end = A.length-1;
        while(start<=end){
            int mid = start + (end - start)/2;
            if(A[mid] == searchValue){
                System.out.println("Found at "+mid+" index");
                return;
            }else if(A[mid] > searchValue){
                end = mid - 1;
            }else{
                start = mid + 1;
            }
        }
        System.out.println("Not found");
    }
    public static void linearSearch(int[]A, int searchValue){
        for(int i=0;i<A.length;i++){
            if(A[i]== searchValue){
                System.out.println("Found at "+i+" index");
                return;
            }
        }
        System.out.println("Not found");
    } 
}
