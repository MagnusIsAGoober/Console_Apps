/*
 Name: Magnus Linde
 Class: Comp Sci 20s
 Desc: This is a program that takes a number from the user, then determines if it is larger than 10 or not
 */
namespace StandardOutIn
{
    public class InputOut
    {
        public static void Main()
        {


            Console.WriteLine("");

            int length = Convert.ToInt32(Console.ReadLine());

            Console.Write("8");
            for (int i = 0; i < length; i++)
            {
                Console.Write("=");
                Thread.Sleep(100); // Simulate work being done
            }
            Console.WriteLine("D");
     
            Console.ReadLine();
        }
    }

}
