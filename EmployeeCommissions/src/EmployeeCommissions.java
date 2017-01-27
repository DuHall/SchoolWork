/**
 * Created by Dustin Hall on 1/27/2017.
 */
import java.util.Scanner;

public class EmployeeCommissions {
    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        /**
         * Employee 1 Information
         */
        double empOneCommissionTotal = 0;
        System.out.print("Welcome to the Employee Commissions tool.");
        System.out.print("Enter the name of Employee 1: ");
        String empOneName = input.next();

        System.out.print("Enter "+ empOneName +" monthly sales: ");
        double empOneSales = input.nextDouble();

        System.out.print("Enter "+ empOneName + "'s commission rate: ");
        double empOneCommission = input.nextDouble();


        /**
         * Calculate employee one total commission
         */

        empOneCommissionTotal = empOneSales * empOneCommission;

        /**
         * Employee 2 Information
         */
        double empTwoCommissionTotal = 0;
        System.out.print("Enter the name of Employee 2: ");
        String empTwoName = input.next();

        System.out.print("Enter "+ empTwoName +" monthly sales: ");
        double empTwoSales = input.nextDouble();

        System.out.print("Enter "+ empTwoName + "'s commission rate: ");
        double empTwoCommission = input.nextDouble();

        /**
         * Calculate employee two total commission
         */

        empTwoCommissionTotal = empTwoSales * empTwoCommission;

        /**
         * Employee 3 Information
         */
        double empThreeCommissionTotal = 0;
        System.out.print("Enter the name of Employee 3: ");
        String empThreeName = input.next();

        System.out.print("Enter "+ empThreeName +" monthly sales: ");
        double empThreeSales = input.nextDouble();

        System.out.print("Enter "+ empThreeName + "'s commission rate: ");
        double empThreeCommission = input.nextDouble();

        /**
         * Calculate employee three total commission
         */

        empThreeCommissionTotal = empThreeSales * empThreeCommission;


        /**
         * Sort the commissions from largest to smallest.
         */

       if (empOneCommissionTotal > empTwoCommissionTotal && empOneCommissionTotal > empThreeCommissionTotal){
           if (empTwoCommissionTotal > empThreeCommissionTotal){
               System.out.println(empOneName + " " + empOneCommissionTotal + "\n" +empTwoName + " " + empTwoCommissionTotal + "\n" +empThreeName + " " + empThreeCommissionTotal);
           }else {
               System.out.println(empOneName + " " + empOneCommissionTotal + "\n" +empThreeName + " " + empThreeCommissionTotal + "\n" +empTwoName + " " + empTwoCommissionTotal);
           }
       }
       else if (empTwoCommissionTotal > empOneCommissionTotal && empTwoCommissionTotal > empThreeCommissionTotal){
           if (empOneCommissionTotal > empThreeCommissionTotal){
               System.out.println(empTwoName + " " + empTwoCommissionTotal + "\n" +empOneName + " " + empOneCommissionTotal + "\n" +empThreeName + " " + empThreeCommissionTotal);
           }else{
               System.out.println(empTwoName + " " + empTwoCommissionTotal + "\n" +empThreeName + " " + empThreeCommissionTotal + "\n" +empOneName + " " + empOneCommissionTotal);
           }
       }
       else if (empThreeCommissionTotal > empOneCommissionTotal && empThreeCommissionTotal > empTwoCommissionTotal){
           if (empOneCommissionTotal > empTwoCommissionTotal){
               System.out.println(empThreeName + " " + empThreeCommissionTotal + "\n" +empOneName + " " + empOneCommissionTotal + "\n" +empTwoName + " " + empTwoCommissionTotal);
           }   else{
               System.out.println(empThreeName + " " + empThreeCommissionTotal + "\n" +empTwoName + " " + empTwoCommissionTotal + "\n" +empOneName + " " + empOneCommissionTotal);
           }
       }
    }
}
