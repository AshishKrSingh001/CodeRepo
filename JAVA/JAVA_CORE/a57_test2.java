public class a145_test2
{
	
    public static void main(String[] args) 
    {
        if(args.length>0)
		{
			int num=0;
			//num = Integer.parseInt(element);
			for(String element:args)
			{
				num = Integer.parseInt(element)+num;
			}
			System.out.printf("Addition of %d number is: %d\n",args.length,num);
		}
		else
		{
			System.out.println("Please Enter n number");
		}

        
        
    }
}