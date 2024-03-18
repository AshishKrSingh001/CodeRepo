import java.util.Random;
import java.util.Scanner;
public class a33_game
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);

        Random r = new Random();
        int rand = r.nextInt(3);
        rand = rand + 1;
        //System.out.println(rand);
        System.out.println("Enter 1 for Rock, 2 for Paper and 3 for Scissors:");
        int a = sc.nextInt();
        String s;
        if((rand==1 && a==2)||(rand==3 && a==1)||(rand==2 && a==3))
        {
            System.out.println("System got Rock and You got Paper\nYou Win");
        }
        else if((rand==1 && a==3)||(rand==2 && a==1)||(rand==3 && a==2))
        {
            System.out.println("System got Rock and You got Scissors\nYou Lose");
        }

        else if((rand==1 && a==1)||(rand==2 && a==2)||(rand==3 && a==3))
        {
            System.out.println("You both got same\nMatch tied");
        }
        else
        {
            System.out.println("Invalid input");
        }

    }
}
