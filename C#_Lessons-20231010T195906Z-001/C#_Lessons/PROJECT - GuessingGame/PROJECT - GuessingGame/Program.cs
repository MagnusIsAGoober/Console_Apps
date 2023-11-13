/*
 Name: Magnus Linde
 Class: Comp Sci 20s
 Desc: This code uses a loop to create a guessing game, until the user types the correct random number
 */
namespace StandardOutIn
{
    public class InputOut
    {
        public static void Main()
        {

            Console.WriteLine("Guess a number between 1 and 10");

            Random TempNum = new Random();

            int TargetNum = TempNum.Next(1,11);

            bool Guessed = false;

            while (!Guessed) {
                int Guess = Convert.ToInt32(Console.ReadLine());
                if (Guess == TargetNum)
                {
                    Console.WriteLine("Yes Thats Right! You Win!");
                    Guessed = true;
                }
                else
                {
                    Console.WriteLine("Nope! Try Agian");
                }
                 
            
            }

        }
    }
}

