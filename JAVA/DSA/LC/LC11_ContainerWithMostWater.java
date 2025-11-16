public class LC11_ContainerWithMostWater 
{
    public static void main(String[] args) 
    {
        int []A = {8,20,1,2,3,4,5,6};
        System.out.println(maxArea(A));
    }
    public static int maxArea(int[] height) 
    {
        int maxArea = 0;
        int n = height.length;
        for(int i=0;i<n;i++)
        {
            int index = nextGreaterElementPosition(height, i);
            System.out.println(i+"\t"+index);
            int length = Integer.min(height[i], height[index]);
            int breadth = (Math.abs(index-i));
            // System.out.println(length+"\t"+breadth);
            int area = length * breadth;
                if(area>maxArea)
                    maxArea = area;
                // System.out.println(area);
        }
        return maxArea;
    }
    public static int nextGreaterElementPosition(int[]height,int index)
    {
        int n = height.length;
        int resIndex = index;
        for(int i=0;i<n;i++)
        {
            if(height[index]<=height[i])
            {
                resIndex = (Math.abs(resIndex-index)<=Math.abs(i-index))?i:resIndex;
            }
            
        }
        if(resIndex == 0)
            return Integer.max(height.length-1-index, index-0);
        return resIndex;
    }
}
