using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Greeting the user
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            string input = Console.ReadLine();
            int age = Convert.ToInt32(input);

            Console.WriteLine($"\nHello {name}, you are {age} years old!");
            Console.WriteLine("Welcome to your personal CLI Calculator 🧮\n");

            bool running = true;

            while (running)
            {
                Console.WriteLine("\nSelect an operation:");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");
                Console.WriteLine("5. Modulus (%)");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice (1-6): ");

                string choice = Console.ReadLine();

                if (choice == "6")
                {
                    Console.WriteLine("Goodbye! Thanks for using the calculator, " + name + "!");
                    break;
                }

                Console.Write("Enter first number: ");
                double num1 = GetValidNumber();

                Console.Write("Enter second number: ");
                double num2 = GetValidNumber();

                double result = 0;
                bool valid = true;

                switch (choice)
                {
                    case "1":
                        result = num1 + num2;
                        Console.WriteLine($"Result: {num1} + {num2} = {result}");
                        break;
                    case "2":
                        result = num1 - num2;
                        Console.WriteLine($"Result: {num1} - {num2} = {result}");
                        break;
                    case "3":
                        result = num1 * num2;
                        Console.WriteLine($"Result: {num1} * {num2} = {result}");
                        break;
                    case "4":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Result: {num1} / {num2} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("⚠️ Error: Cannot divide by zero.");
                            valid = false;
                        }
                        break;
                    case "5":
                        result = num1 % num2;
                        Console.WriteLine($"Result: {num1} % {num2} = {result}");
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please select a number between 1 and 6.");
                        valid = false;
                        break;
                }

                if (valid)
                {
                    Console.Write("\nWould you like to do another operation? (y/n): ");
                    string again = Console.ReadLine().ToLower();
                    if (again != "y")
                    {
                        running = false;
                        Console.WriteLine($"See you soon, {name}! 👋");
                    }
                }
            }
        }

        static double GetValidNumber()
        {
            double num;
            while (!double.TryParse(Console.ReadLine(), out num))
            {
                Console.Write("Invalid input. Please enter a valid number: ");
            }
            return num;
        }
    }
}
