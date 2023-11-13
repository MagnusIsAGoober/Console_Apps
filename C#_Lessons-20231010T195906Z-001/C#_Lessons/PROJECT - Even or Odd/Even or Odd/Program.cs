/*
 Name: Magnus Linde
 Class: Comp Sci 20s
 Desc: This code takes input from the user and decides weather its odd or even
 */
namespace StandardOutIn
{
    public class InputOut
    {
        public static void Main()
        {
            Console.WriteLine("Enter an integer");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0){
                Console.WriteLine("The number is even.");
            }
            else{
                Console.WriteLine("The number is odd.");
            }
        }
    }

}
