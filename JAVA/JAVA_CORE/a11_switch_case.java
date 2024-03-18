import java.util.Scanner;
public class a32_switch_case
{
    public static void main(String[] args)
    {
          Scanner sc = new Scanner(System.in);
        System.out.println("Enter a number less than 9:");
          int a = sc.nextInt();
          switch (a)
          {
              case 1:
                  System.out.println("Hindi");
                  break;
              case 2:
                  System.out.println("English");
                  break;
              case 3:
                  System.out.println("Tamil");
                  break;
              case 4:
                  System.out.println("Telugu");
                  break;
              case 5:
                  System.out.println("Kannada");
                  break;
              case 6:
                  System.out.println("Malayalam");
                  break;
              case 7:
                  System.out.println("Spanish");
                  break;
              case 8:
                  System.out.println("French");
                  break;
              case 9:
                  System.out.println("Chinese");
                  break;
              case 0:
                  System.out.println("Again");
                  break;
              default:
                  System.out.println("Invalid number");
                  break;
          }
    }
}
