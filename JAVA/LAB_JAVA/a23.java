// WAP in java input multiple integer numbers using command line after that find average

//package LAB_JAVA;

class a23 
{
    public static void main(String[] args) 
    {
        if(args.length>0)
        {
            double add=0;
            for(String element:args)
            {
                add = (add+Integer.parseInt(element));
            }
			double avg = add/args.length;
            System.out.println("Average: "+avg);
        }  
        else
        {
            System.out.println("No argument given");
        }     
    }        
}
