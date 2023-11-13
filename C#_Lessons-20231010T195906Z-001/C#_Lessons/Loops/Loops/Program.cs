/*
 Name: Magnus Linde
 Class: Comp Sci 20s
 Desc: we are learning loops
 */

namespace StandardOutIn
{
    public class InputOut
    {

        public static void Main()
        {
            /*
            int counter = 10;

        Beginning: // this is a label
            Console.WriteLine(counter);
            counter -= 1;

            if (counter > 0)
            {
                goto Beginning; //returns to the label
            }

            */

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*
            int counter2 = 1;

            while (counter2 <= 25 ) { // condition must be true for the loop to work at all
                //the condition must become false at some point to prevent an infinite loop
            Console.WriteLine(counter2);

                counter2++;
            }


            bool keeprunning = true;
            string decision = "n";

            while (keeprunning)
            {
                Console.WriteLine("this loop is running");
                Console.WriteLine("Dou you want to stop it? Press y for yes or n for no");
                decision = Console.ReadLine();

                if (decision == "y")  { keeprunning=false; }
            }

            */

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*
            int counter = 1;
            do // while loops will always work at least one time, beacause it preforms the action first, then checks the condition.
            {
                Console.WriteLine("This loop is working");
                counter++;
            } while (counter < 10); // regardless of weather it is true or false it will work once.

            // the condition needs to be true to run it more than one time
            */

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*

            // initialization is i = 0
            //boolean expression is i < 10
            //update is i++
            //the loop will continue as long as the boolean expression is correct

            for (int i = 0; i < 10; i++)
            { 
                Console.WriteLine(i+1);
            }

            // initialization is i = 10
            //boolean expression is i < 100
            //update is i += 10 which means 1 = 1 + 10
            //the loop will continue as long as the boolean expression is correct
            
            
            for (int i = 10; i < 100; i+= 10)
            {
                Console.WriteLine(i);
            }
            //these will output the same
            for (int i = 1; i <= 10; i++) 
            { 
                Console.WriteLine(i*10);
            }

            //counts down from 10 to 1
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            //infinte loop
            for (int i = 1; i > 0; i++)
            {
                Thread.Sleep(50);
                Console.WriteLine(i);
            }

            */


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            /*

            String[] names = { "Greg", "Magnus", "Martin", "Jake Paul" }; // array

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            //there is a better way to loop through arrays

            foreach (String name in names)
            {
                Console.WriteLine(name);
            }


            int[] numbers = { 10, 20, 30, 100 };

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
            
            Console.ReadLine();

            */

            
        }
    }
}
