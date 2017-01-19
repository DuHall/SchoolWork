/**
 * Created by Dustin Hall on 1/17/2017.
 */


import java.util.InputMismatchException;
import java.util.Scanner;

public class AppleOrchard {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        System.out.print("Welcome to Apple Orchard version 1.0, please enter your first name: ");
        String teacherName = input.next();

        try
        {
            System.out.print("Hi, " + teacherName + "! So, how many students do you have with you today?");
            int studentCount = input.nextInt();

        }
        catch(InputMismatchException exc)
        {
            System.out.println("ummmmm, this needs to be a number and you can't have half a student.");
        }

        if (studentCount >= 20) {
            System.out.print("Wow, you have " + studentCount + " students, geez!! I guess we better get to work");
            System.out.print("How many apples have your students collected?");
            double appleCount = input.nextDouble();

            double studentToAppleCount = appleCount / studentCount;

            System.out.println("You have a total of " + appleCount + " apples, so each student will get " + studentToAppleCount + " apples. Now I need a nap!");
        } else {
            System.out.print("Well " + studentCount + "student's isn't too bad. Don't worry, I can do this in my sleep.");
            System.out.print("How many apples have your students collected?");
            double appleCount = input.nextDouble();

            double studentToAppleCount = appleCount / studentCount;

            System.out.println("You have a total of " + appleCount + " apples, so each student will get " + studentToAppleCount + " apples. See, pretty easy!");
        }
    }
}