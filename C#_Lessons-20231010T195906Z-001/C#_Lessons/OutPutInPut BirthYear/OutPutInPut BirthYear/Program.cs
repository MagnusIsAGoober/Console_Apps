/*
 Name: Magnus Linde
 Class: Comp Sci 20s
 Desc: This code gets age from the user and tells then thier birth year
 */

namespace StandardOutIn
{
    public class InputOut
    {
        public static void Main()
        {
            Console.WriteLine("How old are you?"); //asks age
            int age = Convert.ToInt32(Console.ReadLine());  //sets var (age) as whatever Int typed into console and entered
            int BirthYear = 2023 - age; // creates a new variable for the birth year, by subtracting the input age from the current year
            Console.WriteLine("you were born in " + BirthYear); // tells the user the year they were born in

        }
    }
}
