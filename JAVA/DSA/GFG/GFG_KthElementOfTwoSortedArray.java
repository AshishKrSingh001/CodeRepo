public class GFG_KthElementOfTwoSortedArray
{
	public static void main(String[]args)
	{
		int A[] = {2, 3, 6, 7, 9};
		int B[] = {1, 4, 8, 10};
		System.out.println(kthElement(5,A,B));
	}
	public static long kthElement(int k,int nums1[], int nums2[])
	{
		int n1 = nums1.length; // For storing length of first array i.e nums1 
		int n2 = nums2.length; // For storing length of second array i.e nums2 
		
		// for applying binary search in smaller array this array should be first array
		if(n1>n2)
			return kthElement(k,nums2,nums1); 
		// recursion applied for swaping smaller array in first place
		
		int start = Math.max(0,k-n2); // for starting of range where we apply binary search
		int end = Math.min(k,n1); // for ending of range where we apply binary search
		
		while(start<=end) // typical binary search concept
		{
			int cut1 =  (start+end)/2; // lets take cut1 instead of mid
			int cut2 =  k - cut1; // cut2 will automatically on second array
			int r1 = (cut1==n1)?Integer.MAX_VALUE:nums1[cut1]; // after applying cut1 first right element of cut1
			int l1 = (cut1==0)?Integer.MIN_VALUE:nums1[cut1-1]; // after applying cut1 first left element of cut1
			int r2 = (cut2==n2)?Integer.MAX_VALUE:nums2[cut2]; // after applying cut2 first right element of cut2
			int l2 = (cut2==0)?Integer.MIN_VALUE:nums2[cut2-1]; // after applying cut2 first left element of cut2
			
			if(l1<=r2 && l2<=r1)
			// for checking is cut valid i.e after applying cut
			//left side element of both array is smaller than right side element of both array
				return Math.max(l1,l2);
			else if(l1>r2) // if cut is not valid and l1>r2 will true then shift end to mid-1
				end = cut1 - 1;
			else // if cut is not valid and l2>r1 will true then shift start to mid+1
				start = cut1 + 1;
		}
		return 0;
	}

	
}