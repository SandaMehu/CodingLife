// See https://aka.ms/new-console-template for more information

using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string history1 = "", history2 = "", history3 = "", history4 = "", history5 = "";

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n=== Scientific Calculator ===");
                Console.WriteLine("1. Basic Operations (+, -, *, /, %)");
                Console.WriteLine("2. Square Root");
                Console.WriteLine("3. Power (x^y)");
                Console.WriteLine("4. View History");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter first number: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter operation (+, -, *, /, %): ");
                        char op = Convert.ToChar(Console.ReadLine());

                        double result = 0;
                        bool validOp = true;

                        switch (op)
                        {
                            case '+': result = num1 + num2; break;
                            case '-': result = num1 - num2; break;
                            case '*': result = num1 * num2; break;
                            case '/':
                                if (num2 == 0)
                                {
                                    Console.WriteLine("Error: Division by zero!");
                                    validOp = false;
                                }
                                else result = num1 / num2;
                                break;
                            case '%': result = num1 % num2; break;
                            default:
                                Console.WriteLine("Invalid operation!");
                                validOp = false;
                                break;
                        }

                        if (validOp)
                        {
                            Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
                            ShiftHistory(ref history1, ref history2, ref history3, ref history4, ref history5,
                                $"{num1} {op} {num2} = {result}");
                        }
                        break;

                    case "2":
                        Console.Write("Enter a number: ");
                        double number = Convert.ToDouble(Console.ReadLine());
                        if (number < 0)
                            Console.WriteLine("Error: Cannot take square root of a negative number!");
                        else
                        {
                            double sqrtResult = Math.Sqrt(number);
                            Console.WriteLine($"Result: √{number} = {sqrtResult}");
                            ShiftHistory(ref history1, ref history2, ref history3, ref history4, ref history5,
                                $"√{number} = {sqrtResult}");
                        }
                        break;

                    case "3":
                        Console.Write("Enter base: ");
                        double baseNum = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter exponent: ");
                        double exponent = Convert.ToDouble(Console.ReadLine());
                        double powResult = Math.Pow(baseNum, exponent);
                        Console.WriteLine($"Result: {baseNum}^{exponent} = {powResult}");
                        ShiftHistory(ref history1, ref history2, ref history3, ref history4, ref history5,
                            $"{baseNum}^{exponent} = {powResult}");
                        break;

                    case "4":
                        Console.WriteLine("=== Calculation History ===");
                        if (string.IsNullOrEmpty(history1))
                            Console.WriteLine("No history yet!");
                        else
                        {
                            if (history1 != "") Console.WriteLine("1. " + history1);
                            if (history2 != "") Console.WriteLine("2. " + history2);
                            if (history3 != "") Console.WriteLine("3. " + history3);
                            if (history4 != "") Console.WriteLine("4. " + history4);
                            if (history5 != "") Console.WriteLine("5. " + history5);
                        }
                        break;

                    case "5":
                        exit = true;
                        Console.WriteLine("Thank you for using the Scientific Calculator!");
                        break;

                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            }
        }

        static void ShiftHistory(ref string h1, ref string h2, ref string h3, ref string h4, ref string h5, string newEntry)
        {
            h5 = h4;
            h4 = h3;
            h3 = h2;
            h2 = h1;
            h1 = newEntry;
        }
    }
}
