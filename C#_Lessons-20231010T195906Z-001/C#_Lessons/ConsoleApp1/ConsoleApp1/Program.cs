/*
 Name: Magnus Linde
 Class: Comp Sci 20s
 Desc: This code gets the users age, then calculates thier age in 5 years
 */
using System.Diagnostics;

namespace StandardOutIn
{
    public class InputOut
    {
        public static void Main()
        {
            Console.WriteLine("how old are you? ");
            int age = Convert.ToInt32(Console.ReadLine());
            int OlderAge = age + 5;
            Console.WriteLine("You will be " + OlderAge + " in five years.");

        }
    }
}