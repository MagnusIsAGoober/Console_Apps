/*
 Name: Magnus Linde
 Class: Comp Sci 20s
 Desc: This code prints text and obtains text from the user
 */


namespace StandardOutIn
{
    public class InputOut
    {
        public static void Main()
        {
            /*
            // a string is a list of characters
            // int is a number that does not have a decimal point  e.g -1, 0, 1
            // double (float) is a number that has a decimal point  e.g 1.7, 2.0, -5.0

            Console.WriteLine("what is your name?"); //asks name
            string name = Console.ReadLine();  //sets var (name) as whatever word is typed into console and entered
            Console.WriteLine("how old are you? "); //asks age
            int age = Convert.ToInt32(Console.ReadLine()); // sets var (age) as whatever integer is typed into console and entered
            Console.WriteLine("How tall are you? ");
            double height = Convert.ToDouble(Console.ReadLine()); // sets var (height) as whatever number w decimal is typed into console and entered
            int BirthYear = 2023 - age;
            
            //Console.WriteLine("Nice to meet you, " + name + "\nyour age is " + age + "\nyour height is " + height);
            Console.WriteLine(" Nice to meet you {0} \n you are {1} years old, you were born in {2}\n your height is {3}", name, age, BirthYear, height);
            */
        }
    }
}


namespace VideoGame
{
    public class CharacterCreate
    {
        public static void Main()
        {
            Console.WriteLine("Hello brave traveler, to start your adveNture, I must know, What is thai name?");
            string PlayerName = Console.ReadLine();
            Console.Write("Nice to meet you, ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(PlayerName);
            Console.ResetColor();
            Console.WriteLine("!");
            Console.WriteLine("Firstly, what is your class?\n Warlock\tWizard\tWarrior");
            
        }
    }

}
