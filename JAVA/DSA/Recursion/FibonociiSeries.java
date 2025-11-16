public class FibonociiSeries 
{
    //  0   1   1   2   3   5   8   13  21
    public static int fibonociiSeries(int num)
    {
        if(num==0)
            return 0;
        if(num==1)
            return 1;
        return fibonociiSeries(num-1) + fibonociiSeries(num - 2);
    }
    public static void main(String[] args) 
    {
        System.out.println(fibonociiSeries(8));
    }    
}
