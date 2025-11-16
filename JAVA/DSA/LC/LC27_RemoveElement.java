public class LC27_RemoveElement
{
    public static void main(String[] args) 
    {
        int A[] = {1};
        outputInArray(A);
        System.out.println(removeElement(A, 1));
    }

    public static int removeElement(int[] A, int val) 
    {
        if(A.length==1)
            return(A[0]==val)?0:1;
        int n = A.length-1;
		for(int i=0;i<=n;i++)
		{
			if(A[i] == val)
			{
				int temp = A[i];
				A[i] = A[n];
				A[n] = temp;
				n--;i--;
			}
		}
		return n+1;
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
}