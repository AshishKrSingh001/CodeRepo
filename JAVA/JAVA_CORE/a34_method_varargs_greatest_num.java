public class a67_method_varargs_greatest_num
{
    static int greatest(int...arr)
    {
        int gt=arr[0];
        for(int element:arr)
        {
            if(element>gt)
            {
                gt=element;
            }
        }
        return gt;
    }
    static int smallest(int...arr)
    {
        int st=arr[0];
        for(int element:arr)
        {
            if(element<st)
            {
                st=element;
            }
        }
        return st;
    }
    public static void main(String[] args)
    {
        System.out.println("Greatest number = "+greatest(1,2,3,4,5,6,7,8,9));
        System.out.println("Smallest number = "+smallest(1,2,3,4,5,6,7,8,9));
    }
}
