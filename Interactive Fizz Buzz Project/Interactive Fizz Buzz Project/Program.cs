using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Fizz_Buzz_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("Brainiac Fizz Buzz v1");
            Console.WriteLine("Hello I am Brainiac.\n");
            Console.WriteLine("Pick a number between 1 and 100\n");
            Console.WriteLine("I will yell fizz for a number divisible by 3 and buzz for a number divisible by 5\n");
            Console.WriteLine(" and fizz buzz for a number divisible by both\n");
            Console.Write("Try me.\n");
            string UserValue = Console.ReadLine();
            int newNum = Convert.ToInt32(UserValue);
            if (newNum % 3 == 0 && newNum % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if (newNum % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (newNum % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine("oops you are out of bounds!");
            }

            Console.ReadLine();
        }
    }
}
        
    

