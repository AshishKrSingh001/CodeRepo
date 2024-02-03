package emp;
public class InvalidGenderException extends Exception
{
	public InvalidGenderException()
	{
		super("Gender is not valid");
	}
}