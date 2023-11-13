
using System.ComponentModel.Design;

namespace StandardOutIn
{
    public class InputOut
    {
        public static void WhatWillYouDO()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("What will you do?");
            Console.ResetColor();
        }

        public static void Decision1()
        {
            Console.WriteLine("You wake up in a strange, forest, not knowing who, or where you are.");
            WhatWillYouDO();
            Console.WriteLine("1: Explore the area");
            Console.WriteLine("2: Check your pockets");
            Console.WriteLine("3: Go back to sleep");

            int Choise = Convert.ToInt32(Console.ReadLine());

            switch (Choise)
            {
                case 1:
                    Console.WriteLine("You get up and search, the sorrounding area, eventually stumbling upon a cave." +
                        " Its getting dark and you hear some howling in the other direction! When frantically searching around" +
                        " you notice a feint light in the distance.");
                    WhatWillYouDO();
                    Console.WriteLine("1: Enter the cave");
                    Console.WriteLine("2: Run to the light");
                    break;
                case 2:
                    Console.WriteLine("You died lmao");
                    break;
                case 3:
                    Console.WriteLine("you go back to sleep, thats cool i guess");
                break;

            }
        }
        public static void Main()
        {
                
            }

        }
    }
}
