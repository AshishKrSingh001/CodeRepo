public class FindUniqueNoUsingXOR 
{
    public static void main(String[] args) 
    {
        int A[] = {1,2,3,4,5,6,5,4,3,2,1};
        System.out.println(findUniqueNum(A));
    }   
    public static int findUniqueNum(int[]A)
    {
        int num = 0;
        for(int i=0;i<A.length;i++)
        {
            num = num ^ A[i];
        }
        return num;
    } 
    public static void find2UniqueNum(int[]A)
    {
        int num = 0;
        for(int i=0;i<A.length;i++)
        {
            num = num ^ A[i];
        }
    } 
}
