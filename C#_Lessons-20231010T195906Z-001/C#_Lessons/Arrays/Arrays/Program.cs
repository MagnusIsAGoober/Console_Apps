/*
 Name: Magnus Linde
 Class: Comp Sci 20s
 Desc: This code deals wi5th arrays
 */

namespace ArraysConsoleApp
{
    public class ArraysClass
    {
        public static void Main()
        {
            // regular variables that store single vales
            string name = "Magnus";
            name = "MaggiePoo";
            Console.WriteLine(name);
            int x = 10;
            x = 20;
            Console.WriteLine(x);

            // string arrays
            // index in programming begin from 0
            string[] names = { "Spongebob", "Patrick", "Squidward", "Plankton", "Gary", "Sandy", "Pearl" };
            Console.WriteLine(names[0]); //prints spongebob
            Console.WriteLine(names[1]); //prints patrick
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);
            Console.WriteLine(names[4]);
            Console.WriteLine(names[5]);
            Console.WriteLine(names[6]);

            double[] scores = { 1.1, 2.3, 3.5, 4.7 };

            Console.WriteLine(scores[0]);
            Console.WriteLine(scores[1]);
            Console.WriteLine(scores[2]);
            Console.WriteLine(scores[3]);
            // length gives the number of values in the array 
            Console.WriteLine("THE NUMBER OF NAMES IS " + names.Length);
            Console.WriteLine("THE NUMBER OF SCORES IS " + scores.Length);

            //int[] ints = { 10, 20, 30, 40, 50 };
            int[] ints = new int[5];
            ints[0] = 10;
            ints[1] = 20;
            ints[2] = 30;
            ints[3] = 40;
            ints[4] = 50;
            Console.WriteLine(ints[0]);
            Console.WriteLine(ints[1]);
            Console.WriteLine(ints[2]);
            Console.WriteLine(ints[3]);
            Console.WriteLine(ints[4]);

            int[] numbers = new int[5];
            Console.WriteLine("Enter first integer");
            numbers[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second integer");
            numbers[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third integer");
            numbers[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter fourth integer");
            numbers[3] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter fifth integer");
            numbers[4] = Convert.ToInt32(Console.ReadLine());

            Array.Sort(numbers);
            Console.WriteLine(numbers[0] + "\t" + numbers[1] + "\t" + numbers[2] + "\t" + numbers[3] + "\t" + numbers[4] + "\t");
        }
    }
}

