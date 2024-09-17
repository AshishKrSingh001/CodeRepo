public class GFGAllocateMinimumPages
{
	public static int bookAllocation(int books[],int students)
	{
		if(books.length < students)
			return -1;
		// range will be max of the array and sum of the array
		int start = Integer.MIN_VALUE; // for finding max element
		int end = 0; // for finding sum of array element
		
		for(int i=0;i<books.length;i++)
		{
			if(books[i]>start)
				start = books[i];
			end += books[i];
		}
		
		int res = -1;
		
		while(start<=end)
		{
			// max pages can be allocate to single student
			int mid = (start+end)/2;
			// if allocation is possible then minimize the no of pages
			if(isAllocationPossible(books,mid,students))
				end = mid - 1;
			else
				start = mid + 1;
		}
	}
	public static boolean isAllocationPossible(int books[],int maxPages,int students)
	{
		int currentStudent = 1;
		int pages = 0;
		for(int i=0;i<books.length;i++)
		{
			pages += books[i];
			// if pages exceed maxPages
			if(pages > maxPages)
			{
				// allocate to next student;
				currentStudent++;
				pages = books[i];
			}
			if(currentStudent > students)
				return false;
		}
		return true;
	}
}