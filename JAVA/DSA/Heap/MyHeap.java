public class MyHeap{
    int heapSize;
    int heap[];
    int capacity;
    public MyHeap(int arr[]){
        heap = arr;
        heapSize = arr.length;
        capacity = arr.length;
    }
    private void swap(int i, int j){
        int temp = heap[i];
        heap[i] = heap[j];
        heap[j] = temp;
    }
    private void increaseHeapCapacity(){
        capacity *= 2;
        int newHeap[] = new int[capacity];
        for(int i=0;i<heapSize;i++){
            newHeap[i] = heap[i];
        }
        heap = newHeap;
    }
    private void heapify(int index){
        int tempIndex = index;
        int leftChildIndex = 2 * index + 1;
        int rightChildIndex = 2 * index + 2;

        // MAX HEAP
        if(leftChildIndex<heapSize && heap[leftChildIndex]>heap[tempIndex]){
            tempIndex = leftChildIndex;
        }
        
        if(rightChildIndex<heapSize && heap[rightChildIndex]>heap[tempIndex]){
            tempIndex = rightChildIndex;
        }

        // MIN HEAP
        // if(leftChildIndex<heapSize && heap[leftChildIndex]<heap[tempIndex]){
        //     tempIndex = leftChildIndex;
        // }
        
        // if(rightChildIndex<heapSize && heap[rightChildIndex]<heap[tempIndex]){
        //     tempIndex = rightChildIndex;
        // }
        if(index != tempIndex){
            swap(tempIndex, index);
            heapify(tempIndex);
        }
    }
    public void buldTree(){
        printArray("Array Before Heapify");
        for(int i= heapSize/2-1;i>=0;i--){
            heapify(i);
        }
        printArray("Array After Heapify");
    }
    public int extractMaxElement(){
        if(heapSize == 0){
            System.out.println("Heap is Empty");
            return -1;
        }
        printArray("Before Extracting Max ELement");
        int maxValue = heap[0];
        heap[0] = heap[heapSize-1];
        heapSize--;
        heapify(0);
        printArray("After Extracting Max ELement");
        return maxValue;
    }
    public void increaseKey(int index, int newValue){
        printArray("Before Increasing Value");
        if(index<0 || index>=heapSize || newValue<heap[index]){
            System.out.println("Invalid Index or data");
            return;
        }else if(index == 0){
            heap[index] = newValue;
            return;
        }
        heap[index] = newValue;
        while(index>0 && heap[(int)(Math.ceil(index/2.0)-1)]<heap[index]){
            swap(index, (int)(Math.ceil(index/2.0)-1));
            index = (int)(Math.ceil(index/2.0)-1);
        }
        printArray("After Increasing Value");
    }
    public void decreaseKey(int index, int newValue){
        printArray("Before Decreasing Value");
        if(index<0 || index>=heapSize || newValue>heap[index]){
            System.out.println("Invalid Index or data");
            return;
        }
        heap[index] = newValue;
        heapify(index);
        printArray("After Decreasing Value");
    }
    public void insert(int newValue){
        printArray("Before Insertion Value");
        if(heapSize==capacity){
            increaseHeapCapacity();
        }
        int index = heapSize++;
        heap[index] = newValue;
        while(index>0 && heap[(int)(Math.ceil(index/2.0)-1)]<heap[index]){
            swap(index, (int)(Math.ceil(index/2.0)-1));
            index = (int)(Math.ceil(index/2.0)-1);
        }
        printArray("After Insertion Value");
    }
    public void heapSort(){
        if(heapSize==0){
            System.out.println("Empty Heap");
            return;
        }
        for(int i=heapSize-1;i>=0;i--){
            swap(i,0);
            heapSize--;
            heapify(0);
        }
    }
    public static void main(String[]args){
        int A[] = {10, 5, 20, 6, 11};
        MyHeap heap = new MyHeap(A);
        heap.buldTree();
        //System.out.println("Max ELement: "+heap.extractMaxElement());
        // heap.increaseKey(3, 50);
        // heap.decreaseKey(0, 5);
        // heap.insert(100);
        // heap.insert(200);
        // heap.insert(300);
        // heap.insert(400);
        // heap.insert(500);
        heap.heapSort();
        System.out.print("After Sorting -> {");
        for(int i=0;i<A.length;i++){
            System.out.print(A[i]);
            if(i != A.length-1){
                System.out.print(", ");
            }
        }System.out.println("}\n");
    }
    private void printArray(String msg){
        if(heapSize == 0){
            System.out.println("Heap is Empty");
            return;
        }
        System.out.print(msg + " -> {");
        for(int i=0;i<heapSize;i++){
            System.out.print(heap[i]);
            if(i != heapSize-1){
                System.out.print(", ");
            }
        }System.out.println("}\n");
    }
}
