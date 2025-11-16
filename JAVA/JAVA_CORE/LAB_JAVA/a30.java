// WAP in java to input five strings after that count vowel character for each string
package LAB_JAVA;

import java.util.Scanner;

public class a30 
{
    Scanner sc = new Scanner(System.in);
    String[]str;
    int n;
    a30()
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
    void vowels()
    {
        for(int i=0;i<n;i++)
        {
            int count=0;
            for(int j=0;j<str[i].length();j++)
            {
                char ch =str[i].charAt(0);
                switch(ch)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                    count++;
                    break;
                    default:
                    continue;
                }
            } 
            System.out.println("vowels in "+str[i]+": "+count); 
        }
        
    }
    public static void main(String[] args) 
    {
        a30 a = new a30();
        a.input();
        a.output();
        a.vowels();
    }    
}

