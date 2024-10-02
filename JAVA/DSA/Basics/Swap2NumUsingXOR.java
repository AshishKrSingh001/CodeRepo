public class Swap2NumUsingXOR 
{
    public static void main(String[]args)
    {
        int A[] = new int[1];
        int B[] = new int[1];
        A[0] = 10;
        B[0] = 20;
        System.out.println("****\nA = "+A[0]+"\nB = "+B[0]+"\n****");
        swap(A,B);
        System.out.println("****\nA = "+A[0]+"\nB = "+B[0]+"\n****");
    }
    public static void swap(int A[], int B[])
    {
        A[0] = A[0] ^ B[0];
        B[0] = A[0] ^ B[0];
        A[0] = A[0] ^ B[0];
    }
}

