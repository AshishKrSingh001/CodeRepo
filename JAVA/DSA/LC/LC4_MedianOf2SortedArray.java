class LC4_MedianOf2SortedArray {
	public static void main(String[] args) {
	   int A[] = {2, 3, 6, 7, 9};
	   int B[] = {1, 4, 8, 10};
	   System.out.println(findMedianSortedArrays(A, B));
   }
   public static double findMedianSortedArrays(int A[], int B[])
   {
	   if(A.length>B.length)
		   return findMedianSortedArrays(B,A);
		
	   int NA = A.length;
	   int NB = B.length;
	   if(NA == 0)
	   {
		   return (NB%2 != 0)?B[NB/2]:((double)B[NB/2]+B[NB/2-1])/2;
	   }
	   if(NB == 0)
		   return 0;
	   int N = (NA+NB)/2;
	   
	   int start = 0;
	   int end = NA;
	   
	   while(start<=end)
	   {
		   int cut1 = (start+end)/2;
		   int cut2 = N - cut1;
		   
		   int l1 = (cut1==0)?Integer.MIN_VALUE:A[cut1-1];
		   int r1 = (cut1==NA)?Integer.MAX_VALUE:A[cut1];
		   int l2 = (cut2==0)?Integer.MIN_VALUE:B[cut2-1];
		   int r2 = (cut2==NB)?Integer.MAX_VALUE:B[cut2];
		   if(l1 <= r2 && l2 <= r1)
		   {
			   double l = (l1<l2)?l2:l1;
			   double r = (r1<r2)?r1:r2;
			   if((NA + NB) % 2 == 0)
			   {
				   return (l + r) / 2;
			   }
			   return r;
		   }
		   else if(l1 > r2)
		   {
			   end = cut1 - 1;
		   }
		   else
		   {
			   start = cut1 + 1;
		   }
	   }
	   return -1;
   }
}