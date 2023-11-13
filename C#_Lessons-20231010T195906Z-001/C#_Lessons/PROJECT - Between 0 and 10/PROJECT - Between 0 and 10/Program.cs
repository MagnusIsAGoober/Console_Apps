/*
 Name: Magnus Linde
 Class: Comp Sci 20s
 Desc: This code gets a number from the user and decides weather its between 1 and 10
 */

namespace StandardOutIn
{
    public class InputOut
    {
        public static void Main()
        {

            Console.WriteLine("Enter a number between 0 and 10");
            
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 0 && num <= 10)
            {
                Console.WriteLine(num + " is between 0 and 10");
            }
            else
            {
                Console.WriteLine(num + " is not between 0 and 10");
            }

            Console.ReadLine();

        }
    }
}