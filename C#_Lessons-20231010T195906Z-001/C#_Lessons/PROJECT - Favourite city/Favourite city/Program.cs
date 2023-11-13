/*
 Name: Magnus Linde
 Class: Comp Sci 20s
 Desc: This code gives different info about the users favourite city
 */

namespace ConsoleApp
{
    public class TheBigCity
    {
        public static void Main()
        {
            Console.WriteLine("Enter the name of your favourite city");

            string FavCity = (Console.ReadLine());

            Console.WriteLine(
                FavCity + " has " + FavCity.Length + " letters" + "\n"
                + FavCity + " in lowercase is " + FavCity.ToLower() + "\n"
                + FavCity + " in uppercase is " + FavCity.ToUpper() + "\n"
                + FavCity + " first letter is " + FavCity.Substring(0, 1) );
        }
    }
}

