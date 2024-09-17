public class ArrayReverse 
{
    public static void arrayReverse(int[]A, int i, int j)
    {
        if(i>=j)
        {
            return;
        }
        int temp = A[i];
        A[i] = A[j];
        A[j] = temp;
        arrayReverse(A, ++i, --j);
    } 
    public static void outputInArray(int A[])
	{
		System.out.println("**********Output-Start***********\nArray elements are:");
		for(int i=0;i<A.length;i++)
		{
			System.out.print(A[i]+"\t");
		}
		System.out.println("\n**********Output-End***********");
	}
    public static void main(String[] args) 
    {
        int A[] = {1,2,3,4,5,6,7,8,9};
        outputInArray(A);
        arrayReverse(A, 0, A.length-1);
        outputInArray(A);
    }
}
