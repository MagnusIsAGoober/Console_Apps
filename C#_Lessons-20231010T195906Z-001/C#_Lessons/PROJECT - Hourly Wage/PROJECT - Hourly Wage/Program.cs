/*
 Name: Magnus Linde
 Class: Comp Sci 20s
 Desc: This code gets a number from the user, then does some calculations to return some info
 */

namespace StandardOutIn
{
    public class InputOut
    {
        public static void Main()
        {

            Console.WriteLine("Enter the number of hours you worked");

            double hours = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your hourly rate");

            double rate = Convert.ToDouble(Console.ReadLine());

            double OThours = (hours - 40); if (OThours < 0) { OThours = 0; }
            double OTpay = OThours * rate * 1.5;
            double RP = (hours - OThours)* rate;
            
            double TP = RP + OTpay;

            Console.WriteLine("Regular pay is " + RP + " Dollars");
            Console.WriteLine("Overtime pay is " + OTpay + " Dollars");
            Console.WriteLine("Total pay is is " + TP + " Dollars");

            Console.ReadLine();

        }
    }
}