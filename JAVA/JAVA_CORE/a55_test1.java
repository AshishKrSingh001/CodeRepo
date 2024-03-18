public class a143_test1
{
	private int f_num,l_num;
	a143_test1(int f_num,int l_num)
	{
		this.f_num = f_num;
		this.l_num = l_num;
		System.out.println("Good Morning");
	}
	public void palindrome()
	{
		System.out.printf("Palindrome Number between %d and %d: \n",f_num,l_num);
           for(int i=f_num;i<=l_num;i++)
           {
               int d,rev=0,z=i;
               while(z>0)
               {
                   d = z%10;
                   rev = rev*10 + d;
                   z=z/10;
               }
               if(i==rev)
               {
                   System.out.printf("%d\t",rev);
               }
            }
	}
	public void prime_num()
	{
		System.out.printf("\nPrime Number between %d and %d: \n",f_num,l_num);
		for(int i=f_num;i<=l_num;i++)
            {
                int c=0;
                for(int j=2;j<=i/2;j++)
                {
                    if(i%j==0)
                    {
                        c++;
                    }
                }
                if(c==0)
                {
                    System.out.printf("%d\t",i);
                }
            }
	}
	
    public static void main(String[] args) 
    {
        if(args.length==2)
		{
			a143_test1 t = new a143_test1(Integer.parseInt(args[0]),Integer.parseInt(args[1]));
			t.palindrome();
			t.prime_num();
		}
		else
		{
			System.out.println("Please Enter 2 number");
		}

        
        
    }
}