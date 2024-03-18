class Prime extends Thread
{
    private int F_num,L_num;
    private int arr[];
    private int count;
    Prime(int f_num,int l_num)
    {
        arr = new int[5];
        if(f_num>l_num)
        {
            f_num = f_num - l_num;
            l_num = f_num + l_num;
            f_num = l_num - f_num;
        }
        F_num = f_num;
        L_num = l_num;        
    }
    public void Insert(int element)
    {
        if (arr.length == count) 
        {
            int newArr[] = new int[count+1];
            for (int i = 0; i < count; i++) 
            {
                newArr[i] = arr[i];
            }
            arr = newArr;
        }           
        arr[count++] = element;
    }
    public void run()
    {
        for(int element : arr)
        {
            System.out.println(element);
            try
            {
                Thread.sleep(1000);
            }
            catch(InterruptedException e)
            {}
        }
    }
    public void checkPrime()
    {
        for (int i = F_num; i <= L_num; i++) 
        {
            int count=0;
            for(int j=2;j<=i/2;j++)
            {
                if(i%j==0)
                {
                    count++;
                }
            }
            if(count==0)
            {
                Insert(i);
            }   
        }
    }
}
class Palindrome extends Thread
{
    private int F_num,L_num;
    private int arr[],arra[];
    private int count,count1;
    Palindrome(int f_num,int l_num)
    {
        arr = new int[5];
        if(f_num>l_num)
        {
            f_num = f_num - l_num;
            l_num = f_num + l_num;
            f_num = l_num - f_num;
        }
        F_num = f_num;
        L_num = l_num;        
    }
    public void Insert(int element)
    {
        if (arr.length == count) 
        {
            int newArr[] = new int[count+1];
            for (int i = 0; i < count; i++) 
            {
                newArr[i] = arr[i];
            }
            arr = newArr;
        }           
        arr[count++] = element;
    }
    public void run()
    {
        for(int element : arr)
        {
            System.out.print(element+"\t");
            try
            {
                Thread.sleep(1000);
                System.out.println(" ");
            }
            catch(InterruptedException e)
            {}
        }
    }
    public void checkPalindrome()
    {
        for (int i = F_num; i <= L_num; i++) 
        {
            int rev=0,num=i;
            while(num>0)
            {
                int rem = num%10;
                rev = rev*10+rem;
                num = num/10;
            }
            if(i==rev)
            {
                Insert(i);
            }          
        }
    }
}
public class a151_ThreadException 
{
    public static void main(String[] args)
    {
        Palindrome A = new Palindrome(100, 1000);
        Prime B = new Prime(100, 1000);
        A.checkPalindrome();
        A.setPriority(10);
        A.start();
        B.checkPrime();
        A.setPriority(1);
        B.start();
    }    
}