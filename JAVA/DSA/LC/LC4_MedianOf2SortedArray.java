public class LC4_MedianOf2SortedArray
{
	public static void main(String[]args)
	{
		int A[] = {1,2};
		int B[] = {3,4};
		System.out.println(findMedianSortedArrays(A,B));
	}
	public static double findMedianSortedArrays(int nums1[], int nums2[])
	{
		int n1 = nums1.length; // For storing length of first array i.e nums1 
		int n2 = nums2.length; // For storing length of second array i.e nums2 
		int N = n1+n2; // For storing length of merged array i.e nums1+nums2
		
		// for applying binary search in smaller array this array should be first array
		if(n1>n2)
			return findMedianSortedArrays(nums2,nums1); // recursion applied for swaping smaller array in first place
		
		int start = 0; // for starting of range where we apply binary search
		int end = n1; // for ending of range where we apply binary search
		
		while(start<=end) // typical binary search concept
		{
			int cut1 =  (start+end)/2; // lets take cut1 instead of mid
			int cut2 =  N/2 - cut1; // cut2 will automatically on second array
			int r1 = (cut1==n1)?Integer.MAX_VALUE:nums1[cut1]; // after applying cut1 first right element of cut1
			int l1 = (cut1==0)?Integer.MIN_VALUE:nums1[cut1-1]; // after applying cut1 first left element of cut1
			int r2 = (cut2==n2)?Integer.MAX_VALUE:nums2[cut2]; // after applying cut2 first right element of cut2
			int l2 = (cut2==0)?Integer.MIN_VALUE:nums2[cut2-1]; // after applying cut2 first left element of cut2
			
			if(l1<=r2 && l2<=r1)
			// for checking is cut valid i.e after applying cut
			//left side element of both array is smaller than right side element of both array
			{
				if(N%2!=0) // checking length of merged array is even or odd
					return (double)min(r1,r2); // In case of odd
				else
					return ((max(l1,l2)+min(r1,r2))/2.0); // In case of even
			}
			else if(l1>r2) // if cut is not valid and l1>r2 will true then shift end to mid-1
				end = cut1 - 1;
			else // if cut is not valid and l2>r1 will true then shift start to mid+1
				start = cut1 + 1;
		}
		return 0.0;
	}
	static int min(int num1, int num2)
	{
		return (num1<num2)?num1:num2;
	}
	static int max(int num1, int num2)
	{
		return (num1<num2)?num2:num1;
	}
	
}