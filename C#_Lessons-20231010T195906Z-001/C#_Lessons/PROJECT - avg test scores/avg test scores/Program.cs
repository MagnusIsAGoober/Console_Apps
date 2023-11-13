/*
 Name: Magnus Linde
 Class: Comp Sci 20s
 Desc: This code gets the avg between the entered doubles
 */
namespace StandardOutIn
{
    public class InputOut
    {
        public static void Main()
        {
            double[] Numbers = new double[3];

            

            Console.WriteLine("enter the first number");
            Numbers[0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the second number");
            Numbers[1] = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("enter the third number");
            Numbers[2] = Convert.ToDouble(Console.ReadLine());

            double sum = 0.0;

            foreach (double Score in Numbers)
            {
                sum += Score;
            }

            double average = sum / Numbers.Length;


            Console.WriteLine("the first test score is " + Numbers[0]);


        }
    }
}
