
import java.util.Arrays;

public class SieveAlgorithmm
{
    public static void main(String[] args) 
    {
        System.out.println("Hi");
        sieveAlgo(10);
        System.out.println("Bye");
    }
    public static void sieveAlgo(int num)
    {
        boolean []Arr = new boolean[num+1];
        Arrays.fill(Arr, true);
        int counter = 2;
        while(counter<num)
        {
            if(Arr[counter])
            {
                for(int i=counter+counter;i<=num;i+=counter)
                {
                    Arr[i] = false;
                }
            }
            counter++;
        }
        for(int i=2;i<=num;i++)
        {
            System.out.println(i+ "-> "+ Arr[i]);
        }
    }
}