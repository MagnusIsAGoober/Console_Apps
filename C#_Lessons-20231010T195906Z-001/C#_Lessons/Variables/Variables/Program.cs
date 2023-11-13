/*
 Name: Magnus Linde
 Class: Comp Sci 20s
 Desc: A code that shows mathematical operations on int, double varibales
 */
using System.Runtime.ExceptionServices;

namespace StandardOutIn
{
    public class VarHello
    {
        public static void Main()
        {
            
            Console.WriteLine("Here is a number");
            const int num = 10; // const is a term that makes the variable constant i.e unable to change 
            Console.WriteLine(" the number is " + num);
            

            Console.WriteLine("Enter the number");

            int num1= Convert.ToInt32(Console.ReadLine());
            int num2 = num1 % 2; // % gives the remainder of divided numbers it is called modulus

            Console.WriteLine(num2);


            Console.WriteLine("Enter the first integer");
            double first = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second integer");
            double second = Convert.ToDouble(Console.ReadLine());

            double sum = first + second;
            double difference = first - second;
            double product =   first * second;
            double quotient = first / second;
            double remainder = first % second;
            //int FirstSquared = first * first;
            //int SecondSquared = second * second;

            Console.WriteLine("the sum is " + sum);
            Console.WriteLine("the difference is " + difference);
            Console.WriteLine("the product is " + product);
            Console.WriteLine("the quotient is " + quotient);
            Console.WriteLine("the remainder is " + remainder);
            //Console.WriteLine(first + " squared is " + FirstSquared);
            //Console.WriteLine(second + " squared is " + SecondSquared);
            


        }
    }

}
