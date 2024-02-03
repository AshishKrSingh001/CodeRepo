import java.util.*;
public class Examplee
{
	public static void main(String args[])
	{
		Scanner sc = new Scanner(System.in);
        System.out.println("Integer");
		Integer i = new Integer(sc.nextInt());
        System.out.println("Float");
		Float f = new Float(sc.nextFloat());
        System.out.println("Double");
        Double d = new Double(sc.nextDouble());
        //System.out.println("Character");
       //Character c = new Character(sc.next());
        System.out.println("Byte");
        Byte b = new Byte(sc.nextByte());
        System.out.println("Boolean");
        Boolean bo = new Boolean(sc.nextBoolean());
        System.out.println("Long");
        Long l = new Long(sc.nextLong());
        System.out.println("Short");
        Short s = new Short(sc.nextShort()); 
        System.out.println("String");
        String str = new String(sc.next());
        sc.close();
		
        System.out.println("Integer: "+i+"\nFloat: "+f+"\nDouble: "+d+"\nShort: "+s+"\nLong: "+l+"\nByte: "+b+"\nBoolean: "+bo+"\nString: "+str);
	}
}