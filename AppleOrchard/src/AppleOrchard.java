import java.io.IOException;
import java.text.DecimalFormat;
import java.util.InputMismatchException;
import java.util.Scanner;

/**
 * Created by Dustin Hall on 1/17/2017.
 *
 * Note to Instructor: I understand this is beyond the scope of the project, I just wanted to get a feel for java :)
 */
public class AppleOrchard {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        /** Begin program by asking for the Teachers name    */

        System.out.print("Welcome to Apple Orchard version 1.0, please enter your first name and hit Enter: ");
        String teacherName = input.next();

        /** Set studentCount to 0 temporarily before collecting information     */
        int studentCount = 0;

        /** Set bool for while/try/catch studentCount Validation    */
        boolean validInput = false;
        while (!validInput) {
            /** Ask for studentCount and if it's a number continue,  else throw an exception and stop the program    */
            try {
                System.out.print("Hi, " + teacherName + "! So, how many students do you have with you today?");
                while (!input.hasNextInt()) {
                    System.out.println("ummmmm, this needs to be a number and you can't divide a student into pieces, soooo. Please try again.");
                    input.next();
                }
                studentCount = input.nextInt();
                validInput = true;
            } catch (Exception e) {
            }
        }

        boolean validAppleCt = false;
        while (!validAppleCt) {
            try {

                if (studentCount >= 20) {
                    System.out.print("Wow, you have " + studentCount + " students, geez!! I guess we better get to work!   ");
                    System.out.print("How many apples have your students collected?");
                    while (!input.hasNextDouble()) {
                        System.out.println("wait...that was a letter, not a number. Please enter a number.");
                        input.next();
                    }
                    double appleCount = input.nextDouble();

                    /** pass and return Less than 20 calculated value to and from Method   */
                    calculateRatioGreater(appleCount, studentCount);
                    validAppleCt = true;
                } else {
                    System.out.print("Well " + studentCount + " student's isn't too bad. Don't worry, I can do this in my sleep."    );
                    System.out.print("How many apples have your students collected?");
                    while (!input.hasNextDouble()){
                        System.out.println("wait...that was a letter, not a number. Please enter a number.");
                        input.next();
                    }
                    double appleCount = input.nextDouble();

                    /** pass and return Greater than calculated value to and from Method   */
                    calculateRatioLesser(appleCount, studentCount);
                    validAppleCt = true;
                }
            }
            catch(Exception e)
            {

            }
        }
    }
    /** Setup formatting for final answer, set to a whole number.   */
    private static DecimalFormat df = new DecimalFormat("##");

    /** Method to calculate Greater than or = to 20 calculate value and give final answer   */
    public static double calculateRatioGreater (double appleCount, double studentCount) {

        if (appleCount < studentCount){
            System.out.println("There are more students than apples, so you can't give them out evenly.");
            System.exit( 0);
        }else{
        }

        /** Divide the number of apples, by the number of students to get the evenly dispersed value.  */
        double studentToAppleCount = appleCount / studentCount;
        /** Use modulus to get the remainder. */
        double teacherRemainder = appleCount % studentCount;

        /** Print results */

        System.out.println("You have a total of " + appleCount + " apples, so each student will get " + df.format(studentToAppleCount) + " apples and you get the remaining " + teacherRemainder + ". Now I need a nap!");
        return studentToAppleCount + teacherRemainder;

    }
    /** Method to calculate Less than 20 calculated value and give final answer   */
    public static double calculateRatioLesser (double appleCount, double studentCount){

        if (appleCount < studentCount){
            System.out.println("There are more students than apples, so you can't give them out evenly.");
            System.exit( 0);
        }else{
        }

        /** Divide the number of apples, by the number of students to get the evenly dispersed value.  */
        double studentToAppleCount = appleCount / studentCount;
        /** Use modulus to get the remainder. */
        double teacherRemainder = appleCount % studentCount;

        /** Print results */
        System.out.println("You have a total of " + appleCount + " apples, so each student will get " + df.format(studentToAppleCount) + " apples and you get the remaining " + teacherRemainder + ". See, pretty easy!");
        return studentToAppleCount;
    }
}