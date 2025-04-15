using System;

class DivisionApp
{
    static void Main()
    {
        Console.WriteLine("=== Welcome to the Division App ===");

        int numerator = GetNumber("Enter the numerator: ");
        int denominator = GetNumber("Enter the denominator: ");

        PerformDivision(numerator, denominator);

        Console.WriteLine("Thanks for using the app. Have a great day!");
    }

    static int GetNumber(string prompt)
    {
        int number;
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (int.TryParse(input, out number))
                return number;

            Console.WriteLine("❌ Invalid input. Please enter a valid number.");
        }
    }

    static void PerformDivision(int num, int denom)
    {
        try
        {
            double result = Divide(num, denom);
            Console.WriteLine($"✅ Result: {num} / {denom} = {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("⚠️ Error: Cannot divide by zero.");
        }
    }

    static double Divide(int a, int b)
    {
        // Throws automatically if b == 0
        return (double)a / b;
    }
}
