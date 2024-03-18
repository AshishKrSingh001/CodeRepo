import java.util.Scanner;
public class a21_Strings
{
    public static void main(String[] args)
    {
        System.out.println("\"Good morning\"");
        String s = "Hello world";
        System.out.println(s);//Generate a new line at the end;
        System.out.print(s);//No new line generated at the end;
        int a = 10;
        System.out.printf("\n%d\n",a);//Works same as C language;
        System.out.format("%d",a);//Works same as printf;

        //String input:
        Scanner sc = new Scanner(System.in);
        String str1,str2;
        System.out.println("\nEnter a String:");
        str1 = sc.nextLine();
        str2 = sc.next();
        System.out.println(str1+str2);
        System.out.printf("\n%s%s",str1,str2);


    }
}
