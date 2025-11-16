package pack1;
import java.lang.annotation.*;
import java.lang.reflect.*;


@Retention(RetentionPolicy.RUNTIME)
@Target(ElementType.METHOD)
@interface MyCustomAnnotation
{
	int value();
}

class B
{
	@MyCustomAnnotation(value=11)
	public void hello()
	{
		System.out.println("Hello");
	}
}
public class A02_Annotations
{
	public static void main(String []args)
	{
		B a = new B();
		Method m = a.getClass().getMethod("hello");
		
		MyCustomAnnotation my = m.getAnnotation(MyCustomAnnotation.class);
		System.out.println("Value is: " + my.value());
	}
} 