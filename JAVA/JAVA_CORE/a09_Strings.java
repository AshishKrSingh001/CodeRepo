import java.util.Scanner;
public class a22_Strings
{
    public static void main(String[] args)
    {
        String str1 = new String("Ashish");

        System.out.printf("The length of the string is %d\n",str1.length());//Count length of the string
        System.out.println(str1.toLowerCase());//Convert to lower case
        System.out.println(str1.toUpperCase());//Convert to upper case
        String str2 = "       AKS      ";
        System.out.println(str2);
        System.out.println(str2.trim());//Remove White space from leading and trailing

        String str3 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        System.out.println(str3.substring(2));//Print the String from given index to last
        System.out.println(str3.substring(2,20));//print the String between the range given,End is excluded

        String str4 = "Carpenter";
        System.out.println(str4.replace('C','c'));//Replace first given character to second
        System.out.println(str4.replace("ter","mno"));//Replace first element of the String to given second element

        System.out.println(str4.startsWith("c"));//Give boolean value if string starts with given value or not

        System.out.println(str4.endsWith("r"));//Give boolean value if string ends with given value or not

        System.out.println(str4.charAt(4));//Give at given index what character it is

        System.out.println(str4.indexOf("rp"));//Give what is the index of given element of string starts with in the string
        System.out.println(str4.indexOf('r'));//Give what is the index of given char starts with in the string
        System.out.println(str3.indexOf("YZ",20));//It also give the index but it searching starts with given index value
        System.out.println(str3.indexOf('Y',24));

        System.out.println(str3.lastIndexOf("M"));//It gives the last index of M in the string
        System.out.println(str3.lastIndexOf("M",10));//It also gives the last index but here it will search under given index

        System.out.println(str4.equals("carpenter"));//It checks weather the given strings is equal to the another string or not, case sensitive
        System.out.println(str4.equalsIgnoreCase("carpenter"));//It checks weather the given strings is equal to the another string or not, not case sensitive



    }
}
