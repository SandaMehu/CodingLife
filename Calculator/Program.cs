// See https://aka.ms/new-console-template for more information

using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Enhanced Calculator!");

            bool keepRunning = true;

            while (keepRunning)
            {
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter operation (+, -, *, /, %): ");
                char operation = Convert.ToChar(Console.ReadLine());

                double result = 0;
                bool validOperation = true;

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: Division by zero is not allowed!");
                            validOperation = false;
                        }
                        else
                            result = num1 / num2;
                        break;
                    case '%':
                        result = num1 % num2;
                        break;
                    default:
                        Console.WriteLine("Invalid operation!");
                        validOperation = false;
                        break;
                }

                if (validOperation)
                    Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");

                Console.Write("Do you want to perform another calculation? (y/n): ");
                char choice = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (choice != 'y')
                {
                    keepRunning = false;
                    Console.WriteLine("Thank you for using the calculator!");
                }
            }
        }
    }
}
