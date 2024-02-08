package pack1;
import java.lang.Enum;
enum Days
{
	SUNDAY("01"),MONDAY("02"),TUESDAY("03"),WEDNESDAY("04"),THURSDAY("05"),FRIDAY("06"),SATURDAY("07");
	String value;
	Days(String value)
	{
		this.value = value;
	}
	public String getValue()
	{
		return value; 
	}
}
public class A01_Enum
{
	public static void main(String []args)
	{
		Days d1 = Days.SUNDAY;

		//System.out.println("Enum name: "+ d1.name());
		//System.out.println("Enum value: "+ d1.getValue());
		for(Days d : Days.values())
		{
			System.out.println("\nEnum name: "+ d.name()+" \nEnum value: "+d.getValue());
		}
	}
}