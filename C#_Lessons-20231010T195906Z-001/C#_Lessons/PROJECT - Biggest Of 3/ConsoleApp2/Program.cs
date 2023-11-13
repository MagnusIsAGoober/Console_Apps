/*
 Name: Magnus Linde
 Class: Comp Sci 20s
 Desc: This code gets the largest between the entered doubles
 */
using System.Xml.Linq;

namespace StandardOutIn
{
    public class InputOut
    {
        public static void Main()
        {
            double[] Numbers = new double[3];

            Console.WriteLine("enter the first number");
            Numbers[0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the second number");
            Numbers[1] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the third number");
            Numbers[2] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("the biggest number is " + Numbers.Max());

        }
    }
}
