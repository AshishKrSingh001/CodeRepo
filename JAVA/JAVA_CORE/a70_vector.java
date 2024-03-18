import java.util.ArrayList;
import java.util.Vector;

public class a158_vector 
{
    public static void main(String[] args) 
    {
        String str = new String("Ashish");
        System.out.println("String: "+str);

        String str1[] = {"Mango","Apple","Guava","Lichi","Cumcumber"};
        System.out.print("String[]:");
        for(String elemnt: str1)
        {System.out.print("\t"+elemnt);}

        StringBuffer str2 = new StringBuffer("Kumar");
        System.out.print("\nStringBuffer: "+str2);

        StringBuilder str4 = new StringBuilder("Singh");
        System.out.println("StringBuilder: "+str4);

        System.out.print("int[]:");
        int arr[] = {1,2,3,4,5};
        for(int elemnt: arr)
        {System.out.print("\t"+elemnt);}

        System.out.print("\ndouble[]:");
        double d[] =  {1.258,2.258,3.258,4.258,5.258};
        for(double elemnt: d)
        {System.out.print("\t"+elemnt);}

        System.out.print("\nfloat[]: ");
        float f[] =  {1.258f,2.258f,3.258f,4.258f,2.258f};
        for(float elemnt: f)
        {System.out.print("\t"+elemnt);}

        System.out.println("\nArrayList:");
        ArrayList ar = new ArrayList<>();
        ar.add(arr);
        ar.add(str);
        ar.add(str1);
        ar.add(40);
        for(Object elemnt: ar)
        {System.out.println("\t"+elemnt);}

        System.out.println("\nVector:");
        Vector v = new Vector<>();
        v.add(str2);
        v.add(str4);
        v.add(d);
        v.add(f);
        v.add(40.158);
        for(String elemnt: str1)
        {System.out.println("\t"+elemnt);}

        System.out.println("\nVector:");
        Vector v1 = new Vector<>();
        v1.add(ar);
        v1.add(v);
        v1.add(5.555f);
        for(String elemnt: str1)
        {System.out.println("\t"+elemnt);}

        System.out.println("\nArrayList:");
        ArrayList ar1 = new ArrayList<>();
        ar1.add(v1);
        ar1.add(ar);
        ar1.add("41558");
        for(String elemnt: str1)
        {System.out.println("\t"+elemnt);}

    }    
}
