public class AddNNumber 
{
    public static int addNNumber(int num)
    {
        if(num == 0)
            return 0;
        return num + addNNumber(num-1);
    }
    public static void main(String[] args) 
    {
        System.out.println(addNNumber(10));
    }    
}
