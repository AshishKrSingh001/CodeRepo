
import java.util.ArrayList;

public class BucketSortExample{
    public static void main(String[] args){
        float arr[] = {0.78f, 0.17f, 0.39f, 0.26f, 0.72f, 0.94f, 0.21f, 0.12f, 0.23f, 0.68f};

        ArrayList<Float>sortedArray = bucketSort(arr);
        System.out.println(sortedArray);
    }
    public static ArrayList<Float> bucketSort(float arr[]){
        if(arr.length==0){
            return new ArrayList<Float>();
        }
        // calculate bucket size
        float maxElement = findMax(arr);
        int maxIndex = (int)(maxElement*arr.length);
        int bucketSize = maxIndex + 1;

        // create and init bucket
        ArrayList<Float>bucket[] = new ArrayList[bucketSize];
        for(int i=0;i<bucketSize;i++){
            bucket[i] = new ArrayList<>();
        }
        // insert appropriate value to the bucket
        for(int i=0;i<arr.length;i++){
            int index = (int)(arr[i]*arr.length);
            // bucket[index].add(arr[i]);

            // sort bucket while inserting using insertion sort
            int targetIndex = 0;
            while(targetIndex<bucket[index].size() && bucket[index].get(targetIndex)<arr[i]){
                targetIndex += 1;
            }
            bucket[index].add(targetIndex, arr[i]);
        }
        // // sort each bucket cell
        // for(int i=0;i<bucketSize;i++){
        //     Collections.sort(bucket[i]);
        // }
        // insert bucket element to array 
        ArrayList<Float>res = new ArrayList<>();
        for(int i=0;i<bucketSize;i++){
            System.out.println(bucket[i]);
            for(float Element:bucket[i]){
                res.add(Element);
            }
        }
        return res;
    }
    public static float findMax(float arr[]){
        float max = Float.MIN_VALUE;
        for(int i=0;i<arr.length;i++){
            if(max<arr[i]){
                max = arr[i];
            }
        }
        return max;
    }
}
