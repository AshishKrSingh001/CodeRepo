
import java.util.Stack;

public class LC735_AsteroidCollision 
{
    public static int[] asteroidCollision(int[] asteroids) 
    {
        Stack<Integer>stack = new Stack<>();
        for(int i=0;i<asteroids.length;i++)
        {
            // if value is +ve or stack is empty blind insertion
            if(stack.isEmpty() || asteroids[i]>0)
            {
                stack.push(asteroids[i]);
            }
            else
            {
                while(!stack.isEmpty())
                {
                    int top = stack.peek();
                    if(top<0)
                    {
                        stack.push(asteroids[i]);
                        break;
                    }
                    int absVal = Math.abs(asteroids[i]);
                    if(absVal == top)
                    {
                        stack.pop();
                        break;
                    }
                    else if(absVal < top)
                    {
                        break;
                    }
                    else
                    {
                        stack.pop();
                        if(stack.isEmpty())
                        {
                            stack.push(asteroids[i]);
                            break;
                        }
                    }
                }
            }
        }
        int n = stack.size();
        asteroids = new int[n];
        for(int i=n-1;i>=0;i--)
            asteroids[i] = stack.pop();
        return asteroids;
    }
    public static void main(String[] args) 
    {
        int []a = {8,-8};
        outputInArray(a);
        a = asteroidCollision(a);
        outputInArray(a);
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
