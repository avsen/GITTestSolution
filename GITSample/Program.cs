using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GITSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            Console.WriteLine("Enter the first number");
            string num1 = Console.ReadLine();
            Console.WriteLine("Enter the second number");
            string num2 = Console.ReadLine();
            Console.WriteLine("Enter A for Addition and M for Multiplication");
            string opType = Console.ReadLine();
            if(opType.Trim().ToUpper().Equals("A"))
            {
                result = Convert.ToInt32(num1) + Convert.ToInt32(num2);
                Console.WriteLine("The result is: " + result.ToString());
                Console.Read();
            }
            else if(opType.Trim().ToUpper().Equals("M"))
            {
                result = Convert.ToInt32(num1) * Convert.ToInt32(num2);
                Console.WriteLine("The result is: " + result.ToString());
                Console.Read();
            }
            else
            {



            }
        }
    }
}
