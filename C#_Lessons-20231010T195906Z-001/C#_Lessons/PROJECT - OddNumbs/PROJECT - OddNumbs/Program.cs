/*
 Name: Magnus Linde
 Class: Comp Sci 20s
 Desc: This code gets to peramaters from the user, and tells them each odd number between those peramaters
 */
namespace StandardOutIn
{
    public class InputOut
    {
        public static void Main()
        {

            Console.WriteLine("Enter the lower bound");
            int LowBound = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Higher bound");
            int HighBound = Convert.ToInt32(Console.ReadLine());

            int num = LowBound;

            Start:
            
                if (num % 2 != 0)
                {
                    Console.WriteLine(num);
                    


            }
             
            num++;
            
            if (num <= HighBound)
            {
                goto Start;
            }


        }
    }
}

