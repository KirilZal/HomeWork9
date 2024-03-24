using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Enter first number:");
            double.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Enter second number:");
            double.TryParse(Console.ReadLine(), out y);

            Console.WriteLine("Select operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            int choice;
            int.TryParse(Console.ReadLine(), out choice);

            Operation op = null;
            switch (choice)
            {
                case 1:
                    op = Calculator.Add;
                    break;
                case 2:
                    op = Calculator.Subtract;
                    break;
                case 3:
                    op = Calculator.Multiply;
                    break;
                case 4:
                    op = Calculator.Divide;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }

            double result = op(x, y);
            Console.WriteLine($"Result: {result}");
        }
    }
}
