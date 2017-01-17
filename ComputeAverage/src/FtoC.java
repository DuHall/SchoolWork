import java.util.Scanner;

/**
 * Created by Terminalogic84 on 1/16/2017.
 */
public class FtoC {
    public static void main (String[] args) {
        Scanner input = new Scanner(System.in);

        System.out.print("Enter a degree in Fahrenheit:  ");
        double fahrenheit = input.nextDouble();

        double celsius = (5.0/9.0) + (fahrenheit -32);

        // Power datatype and casting
        int x = 10;
        int y = (int) Math.pow(x, 2);

        //increment/decrement
        x++;
        x=x+1;

        x=x-1;

        int z = (x++ *10);
        System.out.println(x);


    }
}
