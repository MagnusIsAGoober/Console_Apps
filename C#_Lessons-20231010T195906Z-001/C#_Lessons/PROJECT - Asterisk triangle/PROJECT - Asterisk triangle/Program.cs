/*
 Name: Magnus Linde
 Class: Comp Sci 20s
 Desc: This code uses a loop to create the rows that user chose, then within that loop, it adds a start to each written line, until the loop ends
 */
using System.ComponentModel.Design;
using System.Xml.Schema;

namespace StandardOutIn
{
    public class InputOut
    {
        public static void Main()
        {

            Console.WriteLine("Enter the number of rows in the asterisk tringle");

            int Rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= Rows; i++) 
            { 
                for (int stars = 0; stars < i; stars++) 
                {
                    Console.Write("*\t");
                }
                Console.WriteLine("");
            }
                
            
        }
    }
}