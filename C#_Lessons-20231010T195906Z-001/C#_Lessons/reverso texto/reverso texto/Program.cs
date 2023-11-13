/*
 Name: Magnus Linde
 Class: Comp Sci 20s
 Desc: This code takes code input and reverses it then outputs
 */

namespace ConsoleApp
{
    public class WordoReverso
    {
        public static void Main()
        {
            Console.WriteLine("Enter a word");

            string word = (Console.ReadLine());
            string reversedWord = new string (word.Reverse().ToArray());

            Console.WriteLine(
                "Initial word was " + word + "\n" + "Reversed word is " + reversedWord);
        }
    }
}

