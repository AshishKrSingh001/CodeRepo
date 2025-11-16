// .WAP in java to input three number using command line after that find greatest number using ternary operator
//package LAB_JAVA;

class a22 
{
    public static void main(String[] args) 
    {
        if(args.length==3)
        {
            int a = Integer.parseInt(args[0]);
            int b = Integer.parseInt(args[1]);
            int c = Integer.parseInt(args[2]);
            int gt = ((a>b)&&(a>c)?a:(b>c)?b:c);
            System.out.println("greatest number: "+gt);
        }  
        else
        {
            System.out.println("No argument given");
        }     
    }    
}
