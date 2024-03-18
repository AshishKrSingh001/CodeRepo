public class a66_method_varargs
{
    static int sum(int a,int b)
    {
        return a+b;
    }
    static int sum(int a,int b,int c)
    {
        return a+b+c;
    }
    static int sum(int a,int b,int c,int d)
    {
        return a+b+c+d;
    }
    static int sum(int...arr)
    {
        //Available as int [] arr
        int add=0;
        for(int a:arr)
        {
            add+=a;
        }
        return add;
    }
    public static void main(String[] args)
    {
        //for 2 argument
        System.out.println("Addition = "+sum(10,20));
        //for 3 argument
        System.out.println("Addition = "+sum(10,20,30));
        //for 4 argument
        System.out.println("Addition = "+sum(10,20,30,40));
        //for n argument
        System.out.println("Addition = "+sum(1,2,3,4,5,6,7,8,9));
        //for 0 argument
        System.out.println("Addition = "+sum());
    }
}
