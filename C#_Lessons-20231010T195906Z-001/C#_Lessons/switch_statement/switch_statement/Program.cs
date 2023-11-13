namespace Switch_Statements
{
    public class switches
    {
        
        public static void Main() 
        {
            /*
            Console.WriteLine("Type a number from 1-5");

            int number = Convert.ToInt32(Console.ReadLine());

            
            
            if (number == 1) {
                Console.WriteLine("January");
            }
            else if(number == 2) {
                Console.WriteLine("Febuary");
            }else if (number == 3)
            {
                Console.WriteLine("March");
            }else if (number == 4)
            {
                Console.WriteLine("April");
            }else if (number == 5)
            {
                Console.WriteLine("May");
            }
            else
            {
                Console.WriteLine("That is not within the perameters");
            }

            */

            // switch helps us compare one variable (value) to multiple
            // other cases
            // here the variable month is compared to the numbers
            // from 1 - 12

            /*
            switch(number)
            {
                case 1:
                    Console.WriteLine("January");
                    break; // break is needed to break out of the switch!
                case 2:
                    Console.WriteLine("Febuary");
                    break;  
                case 3:
                    Console.WriteLine("March");
                    break;  
                case 4:
                    Console.WriteLine("April"); 
                    break;  
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;  
                case 7:
                    Console.WriteLine("July");
                    break;  
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;

                default: // only executes if all the cases above it were wrong
                    Console.WriteLine("you found the hidden month");
                    break;
            }
            */

            Console.WriteLine("Enter your name to find grade");
            string name = Console.ReadLine();

            switch (name.ToLower())
            {
                case "greg":
                    Console.WriteLine("42%");
                    break;
                case "magnus":
                    Console.WriteLine("99999%");
                    break;
                case "martin":
                    Console.WriteLine("88%");
                    break;
                case "lachlan":
                    Console.WriteLine("69%");
                    break;
                default:
                    Console.WriteLine("Not in our database");
                    break;
            }




        }

    }



}