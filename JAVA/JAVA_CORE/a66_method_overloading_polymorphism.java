
class Calculate
{
    public Calculate(int a,char c,int b)
    {
        switch(c)
        {
            case '+':
            System.out.println("Addition: "+(a+b));
            break;
            case '-':
            System.out.println("Subtraction: "+(a-b));
            break;
            case '*':
            System.out.println("Multiplication: "+(a*b));
            break;
            case '/':
            System.out.println("Division: "+(a/b));
            break;
        }
    }
}
public class a154_method_overloading_polymorphism 
{
    public static void main(String[] args) 
    {
        Calculate cal = new Calculate(10, '+', 74);
    //     Calculate cal = new Calculate(10, '-', 74);
    //     Calculate cal = new Calculate(10, '*', 74);
    //     Calculate cal = new Calculate(1000, '/', 74);
    }
}
