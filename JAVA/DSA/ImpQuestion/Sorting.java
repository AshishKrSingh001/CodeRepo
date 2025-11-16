public class Sorting {
    public static void main(String[]args){
        int A[] = {31, 19, 67, 42, 91, 13, 75, 28, 56};
        printArray(A, "Array Element");
        // insertionSort(A);
        // selectionSort(A);
        // bubbleSort(A);
        // brickSort(A);
        // int B[] = countingSort(A);
        // printArray(B, "After Array Sorting");
        // pigeonholeSort(A);
        // radixSort(A);
        cyclicSort(A);
        printArray(A, "After Array Sorting");
    }
    public static void printArray(int[]A, String msg){
        System.out.print(msg + " -> [");
        for(int i=0;i<A.length;i++){
            System.out.print(A[i]);
            if(i!=A.length-1){
                System.out.print(", ");
            }
        }
        System.out.println("]");
    }
    public static void cyclicSort(int[]A){
        int N = A.length;
        for(int i=0;i<N-1;i++){
            int pos = i;
            int item = A[i];
            for(int j=i+1;j<N;j++){
                if(A[j]<item){
                    pos++;
                }
            }
            if(pos == i){
                continue;
            }
            while(A[pos] == item){
                pos++;
            }
            if(pos != i){
                int temp = A[pos];
                A[pos] = item;
                item = temp;
            }
            while(i != pos){
                pos = i;
                for(int j=i+1;j<N;j++){
                    if(A[j]<item){
                        pos++;
                    }
                }
                if(pos == i){
                    continue;
                }
                while(A[pos] == item){
                    pos++;
                }
                if(item != A[pos]){
                    int temp = A[pos];
                    A[pos] = item;
                    item = temp;
                }
            }
        }
    }
    public static void radixSort(int[]A){
        int maxElement = 0;
        for(int i=0;i<A.length;i++){
            if(maxElement<A[i]){
                maxElement = A[i];
            }
        }
        for(int digits=1;digits<maxElement;digits*=10){
            int countArray[] = new int[10];
            for(int i=0;i<A.length;i++){
                int ind = (A[i]/digits) % 10;
                countArray[ind]++;
            }
            for(int i=1;i<countArray.length;i++){
                countArray[i] += countArray[i-1];
            }
            int res[] = new int[A.length];
            for(int i = res.length-1;i>=0;i--){
                int ind = (A[i]/digits) % 10;
                int resIndex = --countArray[ind];
                res[resIndex] = A[i];
            }
            for(int i=0;i<A.length;i++){
                A[i] = res[i];
            }
        }
    }
    public static void pigeonholeSort(int[]A){
        int maxElement = A[0];
        int minElement = A[0];
        for(int i=1;i<A.length;i++){
            if(maxElement<A[i]){
                maxElement = A[i];
            }if(minElement>A[i]){
                minElement = A[i];
            }
        }
        int countArray[] = new int[maxElement - minElement + 1];
        for(int i=0;i<A.length;i++){
            countArray[A[i] - minElement]++;
        }
        int index = -1;
        for(int i=0;i<countArray.length;i++){
            while(countArray[i]>0){
                A[++index] = i+minElement;
                countArray[i]--;
            }
        }
    }
    public static int[] countingSort(int[]A){
        int maxElement = 0;
        for(int i=0;i<A.length;i++){
            if(maxElement<A[i]){
                maxElement = A[i];
            }
        }
        int countArray[] = new int[maxElement+1];
        for(int i=0;i<A.length;i++){
            countArray[A[i]]++;
        }
        for(int i=1;i<countArray.length;i++){
            countArray[i] += countArray[i-1];
        }
        int res[] = new int[A.length];
        for(int i=res.length-1;i>=0;i--){
            int ind = countArray[A[i]] - 1;
            res[ind] = A[i];
        }
        return res;
    }
    public static void brickSort(int[]A){
        for(int i=0;i<A.length-1;i++){
            boolean flag = false;
            for(int j=0;j<A.length-1;j+=2){
                if(A[j]>A[j+1]){
                    swap(A, j, j+1);
                    flag = true;
                }
            }
            for(int j=1;j<A.length-1;j+=2){
                if(A[j]>A[j+1]){
                    swap(A, j, j+1);
                    flag = true;
                }
            }
            if(!flag){
                break;
            }
        }
    }
    public static void bubbleSort(int[]A){
        for(int i=0;i<A.length-1;i++){
            for(int j=0;j<A.length-1-i;j++){
                if(A[j]>A[j+1]){
                    swap(A, j, j+1);
                }
            }
        }
    }
    public static void selectionSort(int[]A){
        for(int i=0;i<A.length-1;i++){
            for(int j=i+1;j<A.length;j++){
                if(A[i]>A[j]){
                    swap(A, i, j);
                }
            }
        }
    }
    public static void insertionSort(int[]A){
        for(int i=1;i<A.length;i++){
            int key = A[i];
            int j = i-1;
            while(j>=0 && A[j]>key){
                A[j+1] = A[j];
                j--;
            }
            A[j+1] = key;
        }
    }
    public static void swap(int[]A, int i, int j){
        int temp = A[i];
        A[i] = A[j];
        A[j] = temp;
    }
}
