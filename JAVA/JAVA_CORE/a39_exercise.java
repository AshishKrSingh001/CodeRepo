import java.util.Random;
import java.util.Scanner;
class Game
{
    private int num;
    public Game(int n)
    {
       num = n;
    }
    public Game()
    {
        Random r = new Random();
        num = r.nextInt(1,10);
        num = num + 1;
    }
    public int getnum()
    {
        return num;
    }
}
public class a83_exercise
{
    public static void ISCORRECTNUM()
    {
        Scanner sc = new Scanner(System.in);
        Game value = new Game();
        for(int i=1;true;i++) {
            System.out.println("Guass the number:");
            int num = sc.nextInt();
            Game guass = new Game(num);
            if (value.getnum() < guass.getnum()) {
                System.out.println("Your guassed number is greater than actual number");
            }
            else if (value.getnum() > guass.getnum()) {
                System.out.println("Your guassed number is less than actual number");
            }
            else {
                System.out.println("You have found in " + i + " guasses");
                break;
            }
        }
    }
    public static void main(String[] args)
    {
        ISCORRECTNUM();
    }
}
