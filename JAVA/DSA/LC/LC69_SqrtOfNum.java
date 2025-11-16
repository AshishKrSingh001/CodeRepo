public class LC69_SqrtOfNum
{
	public static void main(String[]args)
	{
		//System.out.println(countSquares(3933355));
		//System.out.println(countSquares(9));
		
		//System.out.println(find(5,3));
		
		System.out.println(findComplement(5));
	}
	public static int findComplement(int num) 
    {
		int n=num;
		for(int i=0;n>0;i++,n /= 2)
		{
			num = num ^ (1<<i);
		}
		return num;
    }
	static long find(long A,long B)
	{  
        return B-(A%B)+A;
    } 
	static int countSquares(int N) 
    {
        return mySqrt(N);
    }
    static int mySqrt(int num) 
    {
        int start = 1;
		int end = num;
		int res = 0;
		while(start<=end)
		{
			int mid = (start+end)/2;
			if(mid <= num/mid)
			{
				res = mid;
				start = mid+1;
			}
			else
				end = mid-1;
		}
		return (res==(double)num/res)?(res-1):res;
    }
}