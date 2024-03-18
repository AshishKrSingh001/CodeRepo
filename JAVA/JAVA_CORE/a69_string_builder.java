public class a157_string_builder 
{
    public static void main(String[] args) 
    {
        StringBuilder str = new StringBuilder("Ashish");
        String s = str.toString();
        System.out.println("str: "+str);
        System.out.println("str.delete(1, 4): "+str.delete(1, 4));
        System.out.println("str.reverse(): "+str.reverse());
        System.out.println("str.toString(): "+str.toString());
        System.out.println("str.append(Ak): "+str.append("Ak"));



        StringBuffer str1 = new StringBuffer("kumar");
        String s1 = str1.toString();
        System.out.println("str: "+str1);

        System.out.println("String: "+s.concat(" ").concat(s1));
    }    
}
