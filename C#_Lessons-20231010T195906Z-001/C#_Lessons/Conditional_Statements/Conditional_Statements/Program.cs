/*
 Name: Magnus Linde
 Class: Comp Sci 20s
 Desc: This is a program that takes a number from the user, then determines if it is larger than 10 or not
 */
namespace StandardOutIn
{
    public class InputOut
    {
        public static void Main()
        {
            /*
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            // <= means less than or equal to
            // >= means greater than or equal to
            // != means not equal to the number

            // < means less than
            if (num <= 10)
            {
                Console.WriteLine("the number is less than 10");

            }
            // == means equal to
            else if (num == 10) 
            {
                Console.WriteLine("the number is  10");
            }
            
            else
            {
                Console.WriteLine("the number is greater than 10");
            }
            Console.WriteLine(@"");
            Console.ReadLine();
            */
            /*
            Console.WriteLine("Enter your grade");
            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade >= 90)
            {
                Console.WriteLine("Your grade is A");
                Console.WriteLine(@"");

            }
            else if (grade >= 80 && grade <= 89)
            {
                Console.WriteLine("Your grade is B");

            }
            else if (grade >= 70 && grade <= 79)
            {
                Console.WriteLine("Your grade is C");

            }
            else if (grade >= 60 && grade <= 69)
            {
                Console.WriteLine("Your grade is D");

            }
            else if (grade >= 50 && grade <= 59)
            {
                Console.WriteLine("Your grade is E");

            }
            else
            {
                Console.WriteLine("Your grade is F");


            }

            if (grade == 69)
            {
                Console.WriteLine("\n NICE");
                Console.WriteLine(@"
          .--------._
         (`--'       `-.
          `.______      `.
       ___________`__     \
    ,-'           `-.\     |
   //                \|    |\
  (`  .'~~~~~---\     \'   | |
   `-'           )     \   | |
      ,---------' - -.  `  . '
    ,'             `%`\`     |
   /                      \  |
  /     \-----.         \    `
 /|  ,_/      '-._            |
(-'  /           /            ` 
,`--<           |        \     \
\ |  \         /%%             `\
 |/   \____---'--`%        \     \
 |    '           `               \
 |
  `--.__
        `---._______
                    `.
                      \");

            }
            Console.ReadLine();
            */

            /*
            bool IsSkyBlue = true; //bool is a true or false value
            bool IsFoodReady = true;

            //with the && (AND) oporator, the statement only executes if all conditions are met
            // true && false = false
            // false && true = false
            // false && false = false
            // true && true = true
            if (IsSkyBlue && IsFoodReady)
            {
                Console.WriteLine("Lets go for a picnic");
            }
            else
            { 
                Console.WriteLine("we cant go for some reason" + " emotes");
            }
            Console.ReadLine();
            */


            Console.WriteLine("Enter your grade to see if you are allowed on the field trip");
                
                int grade = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 50; i++)
            {
                Console.Write("=");
                Thread.Sleep(50); // Simulate work being done
            }
            // with || (OR) operator, only one condition needs to be met
            // false || false = false
            // true || false = true
            // false || true = true
            // true || true = true
            if (grade == 12 || grade == 11) {
                Console.WriteLine("Yes, You may attend the field trip, YIPEE");
            }
            else if (grade > 12)
            {
                Console.WriteLine("What are you doing here? Get lost.");
            }
            else 
            {
                Console.WriteLine("Sorry you cannot attend the field trip");
            }
            //OR
            if (grade != 12 && grade != 11)
            {
                Console.WriteLine("No, You may NOT attend the field trip, BOOO");
            }
            else 
            {
                Console.WriteLine("Sorry you cannot attend the field trip");
            }
            Console.ReadLine();
        }
    }

}
