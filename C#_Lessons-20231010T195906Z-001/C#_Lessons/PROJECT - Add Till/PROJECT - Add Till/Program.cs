/*
 Name: Magnus Linde
 Class: Comp Sci 20s
 Desc: This code uses a loop to get each number between 0 and the entered bound, then totals them up and tells the user
 */
using System.ComponentModel.Design;
using System.Xml.Schema;

namespace StandardOutIn
{
    public class InputOut
    {
        public static void Main()
        {

            Console.WriteLine("Enter the upper bound");

            int UpperBound = Convert.ToInt32(Console.ReadLine());   
            
            int total = 0;
            for (int i = 0; i <= UpperBound; i++) { 
                    Console.WriteLine(i);
                total += i;
            }

            Console.WriteLine("The sum of the entered number above is " + total);

        }
    }
}