namespace StandardApp
{
    public class Yipee
    {
        public static void NarratorActive()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
        public static void UserActive()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public static void ResetColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Main()
        {
            NarratorActive(); Console.WriteLine("whats up my dude"); ResetColor();
            UserActive(); Console.ReadLine(); ResetColor();
            NarratorActive(); Console.WriteLine("stfu bitch ass i aint even know your name"); ResetColor();
            Console.Write("My name is: "); 
            UserActive(); 
            string Name = Console.ReadLine(); 
            ResetColor();
            NarratorActive(); Console.WriteLine("That name is hella gay, kill yourself loser"); ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"");

        }
    }
}