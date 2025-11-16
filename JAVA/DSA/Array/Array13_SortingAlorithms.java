public class Array13_SortingAlorithms 
{
    public static void outputInArray(int A[],String message)
	{
		System.out.println("**********Output-Start***********\n"+message+" elements are:");
        System.out.print("->\t");
		for(int i=0;i<A.length;i++)
		{
			System.out.print(A[i]+"\t");
		}
		System.out.println("\n**********Output-End***********\n");
	}
    public static void main(String[] args) 
    {
        System.out.println("Hello");
        int A[] = {31, 19, 67, 42, 91, 13, 75, 28, 56};
        outputInArray(A,"Previous Array");
        // insertionSort(A);
        // selectionSortBidirectional(A);
        // bubbleSort(A);
        // brickSort(A);
        // A = countingSort(A);
        // redixSort(A);
        // pigeonholSort(A);
        // cycleSortFor1ToN(A);
        cyclicSort(A);
        outputInArray(A,"After performing Sorting Alorithm");
    }
    public static void cyclicSort(int A[])
    {
        int n = A.length;
        for(int i=0;i<n-1;i++)
        {
            int pos = i;
            int item = A[i];
            for(int j=i+1;j<A.length;j++)
            {
                if(A[j]<item)
                    pos++;
            }
            if(pos==i)
                continue;
            
            while(A[pos]==item)
                pos++;

            if(pos != i)
            {
                int temp = A[pos];
                A[pos] = item;
                item = temp;
            }
            while(pos != i)
            {
                pos = i;
                for(int j=i+1;j<A.length;j++)
                {
                    if(A[j]<item)
                        pos++;
                }
                while(A[pos]==item)
                    pos++;

                if(item != A[pos])
                {
                    int temp = A[pos];
                    A[pos] = item;
                    item = temp;
                }

            }
            
        }
    }
    public static void cycleSortFor1ToN(int A[])
    {
        int n = A.length;
        int index = 0;
        while(index<n)
        {
            int element = A[index];
            int actualIndex = element - 1;
            if(A[index]<n && A[index]!=A[actualIndex])
                swap(A, index, actualIndex);
            else
                index++;
        }
    }
    public static void pigeonholSort(int A[])
    {
        int n = A.length; // Array length
        int minElement = Integer.MAX_VALUE; // For evaluating the Min value of array
        int maxElement = Integer.MIN_VALUE; // For evaluating the Max value of array
        for(int i=0;i<n;i++)
        {
            if(minElement > A[i])
                minElement = A[i]; // k will have min value
            if(maxElement < A[i])
                maxElement = A[i]; // k will have max value
        }
        if(minElement==Integer.MAX_VALUE && maxElement==Integer.MIN_VALUE)
        {
            System.out.println("Invalid Array");
            return;
        }
        int sizeOfCountArray = maxElement - minElement + 1;
        int countArray[] = new int[sizeOfCountArray]; // declare the counting val will will count the frequency of element in array

        for(int i=0;i<n;i++)
        {
            int countIndex = A[i] - minElement;
            countArray[countIndex]++;
        }
        int index=-1;
        for(int i=0;i<sizeOfCountArray;i++)
        {
            while(countArray[i]>0)
            {
                A[++index] = minElement + i;
                countArray[i]--;
            }
        }
    }
    public static void redixSort(int A[])
    {
        int n = A.length; // Array length
        int k = Integer.MIN_VALUE; // For evaluating the Max value of array
        for(int i=0;i<n;i++)
        {
            if(k < A[i])
                k = A[i]; // k will have max value
        }
        if(k==Integer.MIN_VALUE)
        {
            System.out.println("Invalid Array");
            return;
        }
        
        for(int d=1;k/d>0;d*=10)
        {
            countingSortWithDigits(A, d);
            // outputInArray(A, "dryrun");
        }
    }
    public static void countingSortWithDigits(int A[], int digits)
    {
        int n = A.length; // Array length
        int k = 9; // For evaluating the Max value of array

        int countArray[] = new int[k+1]; // declare the counting val will will count the frequency of element in array

        for(int i=0;i<n;i++)
        {
            int index = (A[i]/digits)%10;
            countArray[index]++; // counting frequency 
        }

        for(int i=1;i<=k;i++)
            countArray[i] += countArray[i-1]; // storing no of smaller element in the array

        int sortedArray[] = new int[n]; // result array
        for(int i=n-1;i>=0;i--)
        {
            int countIndex = (A[i]/digits)%10;
            int index = --countArray[countIndex];
            sortedArray[index] = A[i]; // storing result array 
        }
        for(int i=0;i<n;i++)
            A[i] = sortedArray[i];
    }
    public static int[] countingSort(int A[])
    {
        int n = A.length; // Array length
        int k = Integer.MIN_VALUE; // For evaluating the Max value of array
        for(int i=0;i<n;i++)
        {
            if(k < A[i])
                k = A[i]; // k will have max value
        }
        if(k==Integer.MIN_VALUE)
            return A; // if array is empty then return same array

        int countArray[] = new int[k+1]; // declare the counting val will will count the frequency of element in array

        for(int i=0;i<n;i++)
            countArray[A[i]]++; // counting frequency 

        for(int i=1;i<=k;i++)
            countArray[i] += countArray[i-1]; // storing no of smaller element in the array

        int sortedArray[] = new int[n]; // result array
        for(int i=n-1;i>=0;i--)
        {
            int index = --countArray[A[i]];
            sortedArray[index] = A[i]; // storing result array 
        }
        return sortedArray;
    }
    public static void brickSort(int A[])
    {
        while(true)
        {
            boolean flag = false;
            for(int j = 0;j <= A.length-2;j += 2)
            {
                if(A[j]>A[j+1])
                {
                    swap(A, j, j+1);
                    flag = true;
                }
            }
            for(int j = 1;j <= A.length-2;j += 2)
            {
                if(A[j]>A[j+1])
                {
                    swap(A, j, j+1);
                    flag = true;
                }
            }
            if(!flag)
                return;
        }
    }
    public static void bubbleSort(int A[])
    {
        int n = A.length;
        for(int i=0;i<n-1;i++)
        {
            boolean flag = false;
            for(int j=0;j<n-i-1;j++)
            {
                if(A[j]>A[j+1])
                {
                    swap(A, j, j+1);
                    flag = true;
                }
            }
            if(!flag)
                break;
        }
    }
    public static void swap(int A[], int i, int j)
    {
        int temp = A[i];
        A[i] = A[j];
        A[j] = temp;
    }
    public static void selectionSort(int A[])
    {
        int n = A.length;
        for(int i=0;i<n-1;i++)
        {
            for(int j=i+1;j<n;j++)
            {
                if(A[i]>A[j])
                {
                    swap(A, i, j);
                }
            }
        }
    }
    public static void selectionSortBidirectional(int A[])
    {
        int k = A.length-1;
        for(int i=0;i<k;i++)
        {
            for(int j=i+1;j<=k;j++)
            {
                if(A[i]>A[j])
                {
                    swap(A, i, j);
                }
                if(A[k]<A[j])
                {
                    swap(A, k, j);
                    k--;
                }
            }
        }
    }
    public static void insertionSort(int A[])
    {
        int n = A.length;
        for(int i=1;i<n;i++)
        {
            int key = A[i];
            int j = i-1;
            while(j>=0 && A[j]>key)
            {
                A[j+1] = A[j];
                j--;
            }
            A[j+1] = key;
        }
    }
}
