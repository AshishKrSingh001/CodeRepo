// WAP in java to input your name after that print name using command line
//package LAB_JAVA;

class a21 
{
    public static void main(String[] args) 
    {
        if(args.length==1)
        {
            System.out.println("Name: "+args[0]);
        }  
        else
        {
            System.out.println("No argument given");
        }     
    }    
}
