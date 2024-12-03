import java.util.*;


public class LC_121FirstNegativeNumberInEveryWindowOfSizeK{
    public static void main(String[] args){
        int A[] = {6190, 9121, 6644, 8135, 2673, 9711, 8245};
        System.out.println(smallestSubWithSum(1, A));
        // ArrayList<Integer>arr = new ArrayList<>();
        // arr.add(7);
        // arr.add(3);
        // arr.add(2);
        // arr.add(4);
        // arr.add(9);
        // arr.add(12);
        // arr.add(56);
        // System.out.println(findMinDiff(arr, 3));
    }
    public static int smallestSubWithSum(int x, int[] arr) {
        int sum = 0;
        int ws = 0, ind = 0;
        int ans = 100000;
        while(ind<arr.length){
            if(sum<=x){
                sum += arr[ind];
                ind++;
            }else{
                int len = ind-ws + 1;
                if(ans > len){
                    ans = len;
                }
                sum = sum - arr[ws];
                ws += 1;
            }
        }
        while(ws<ind-1){
            if((ans>(ind-1-ws)) && (sum>x)){
                ans = (ind-1) - ws;
            }
            sum = sum - arr[ws];
            ws += 1;
        }
        return ans;
    }
    public static List<Integer> FirstNegativeInteger(int arr[], int k){
        Queue<Integer>queue = new LinkedList<>();
        for(int i=0;i<k;i++){
            if(arr[i] < 0 ){
                queue.offer(arr[i]);
            }
        }
        List<Integer>list = new ArrayList<>();
        list.add(queue.peek());
        for(int i=1;i<arr.length-k+1;i++){
            if(arr[i-1]<0){
                queue.poll();
            }
            if(arr[i+k-1] < 0 ){
                queue.offer(arr[i+k-1]);
            }
            if(queue.isEmpty()){
                list.add(0);
            }else{
                list.add(queue.peek());
            }
        }
        return list;
    } 
    public static int findMinDiff(ArrayList<Integer> arr, int m) {
        Collections.sort(arr);
        int min = 0;
        min = arr.get(m-1) - arr.get(0);
        for(int i=1;i<arr.size()-m+1;i++){
            int val = arr.get(i+m-1) - arr.get(i);
            if(val<min){
                min = val;
            }
        }
        return min;
    }
}
