using System;

namespace Calculator
{
    internal class Program
    {

        static void Main(string[] args)
        {
                        // Styling The Console
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Calculator \n \n");
            // Taking Inputs of Numbers and Operation
            Console.WriteLine("Enter Your First Number");
            string a = Console.ReadLine();
            int x = Convert.ToInt32(a);
            Console.WriteLine("\n Enter Your Second Number");
            string b = Console.ReadLine();
            int y = Convert.ToInt32(b);
            Console.WriteLine("\n Select An Operation To Perform:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Square");
            Console.WriteLine("6. Perentage");
            char operation = Console.ReadLine()[0];
            // Appying Operations to the Inputs
            char opr = 'h';
            double result = 0D;
            switch (operation)
            {
                case '1':
                result = x + y;
                    opr = '+';
                break;
                case '2':
                result = x - y;
                    opr = '-';
                    break; 
                case '3':
                result = x * y;
                    opr = 'x';
                    break;
                case '4':
                    if (y != 0)
                    {
                        result = x / y;
                        opr = '/';
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Error: Dividing By Zero");
                    }
                break;
                case '5':
                    result = Math.Pow(x,y);
                    opr = '^';
                    break;  
                case '6':
                    result = (x / y) * 100;
                    opr = '%';
                    break;

                default:
                    Console.WriteLine("Error");
                    break;
            }
            // Printing Out The Result
            Console.WriteLine($" \n \n {x} {opr} {y} = {result}");
            Console.WriteLine("\n \n Press Any Key To Exit...");
            Console.ReadLine();
        
        }
    }
}
