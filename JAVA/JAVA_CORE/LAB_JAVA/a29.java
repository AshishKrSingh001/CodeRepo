// WAP in java to input five strings after that sort in ascending order.
//package LAB_JAVA;
import java.util.Scanner;
class String_
{
    String[] str;
    int n;
    Scanner sc = new Scanner(System.in);
    String_()
    {
        System.out.println("Enter size of array: ");
        n = sc.nextInt();
        str = new String[n];
    }
    void input()
    {
        System.out.println("Enter "+n+" string: ");
        for(int i=0;i<n;i++)
        {
            str[i]=sc.nextLine();
        }
        
    }
    void output()
    {
        System.out.println("Strings are:");
        for(int i=0;i<n;i++)
        {
            System.out.println("String"+(i+1)+": "+str[i]);
        }
    }
    void sorting()
    {
        for(int i=0;i<n-1;i++)
        {
            for(int j=i+i;j<n;j++)
            {
                if(str[i].compareTo(str[j])>0)
                {
                    String s = str[i];
                    str[i] = str[j];
                    str[j] = s;
                }
            }
        }
    }
}
class a29
{
    public static void main(String[] args) 
    {
        String_ s = new String_();
        s.input();
        s.output();
        s.sorting();
        s.output();
        
    }    
}
