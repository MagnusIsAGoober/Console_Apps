/*
 Name: Magnus Linde
 Class: Comp Sci 20s
 Desc: This code scans the entered sentance for a word, then changes its respone accordingly
 */

namespace StandardOutIn
{
    public class InputOut
    {
        public static void Main()
        {
            
            Console.WriteLine("Enter your sentance and we will check for any bombs in the sentance");
            string sentance = Console.ReadLine();
            string bomb = "bomb";

            bool HasWord = sentance.Contains(bomb, StringComparison.OrdinalIgnoreCase);

            if (HasWord)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("FOUND THE BOMB");
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("Nope, No Bombs Here");
            }

            Console.ReadLine();

        }
    }
}