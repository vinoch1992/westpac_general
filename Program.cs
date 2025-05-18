using System;

class Program
{
    static void Main()
    {
        Requirement1();
        Requirement2();
    }

    public static void Requirement1()
    {
        Console.WriteLine("Requirement 1");
        Console.WriteLine("-------------------");
        Console.WriteLine();

        // Prompt user for input
        Console.Write("Enter an integer: ");
        string inputValue = Console.ReadLine();

        // Check if the input is an integer
        int input;
        if (!int.TryParse(inputValue, out input))
        {
            Console.Write("Input must be an integer.");
            return;
        }

        // Check if the input is positive and greater than or equal to 1
        // If not, print a message and return
        if (input < 1)
        {
            Console.Write("Input must be greater than or equal to zero.");
            return;
        }

        // This holds the sum of numbers divisible by 3 or 5
        int sum = 0;

        // This holds the string representation of numbers divisible by 3 or 5
        string result = string.Empty;

        for (int i = 1; i <= input; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                // If the number is divisible by 3 or 5, add it to the result string
                result += i.ToString() + "+";

                // Add the number to the sum
                sum += i;
            }
        }

        if (sum == 0)
        {
            Console.Write("No numbers divisible by 3 or 5.");
            return;
        }
        else
        {
            // Remove last '+' if it exists
            if (result.EndsWith("+"))
            {
                result = result.Remove(result.Length - 1);
            }

            // Print the result
            // and the sum of numbers divisible by 3 or 5
            Console.Write($"{result} = {sum}");
        }
    }

    public static void Requirement2()
    {
        Console.WriteLine("\n\n");
        Console.WriteLine("Requirement 2");
        Console.WriteLine("-------------------");
        Console.WriteLine();

        // File path to save the Fibonacci sequence.
        // NOTE: For this assessment, I am using a relative path.
        string filePath = "Fibonacci.txt";

        // Array to hold the first 15 Fibonacci numbers
        int[] fibonacci = new int[15];

        // Initialize the first two Fibonacci numbers
        fibonacci[0] = 0;
        fibonacci[1] = 1;

        // Generate the rest of the Fibonacci sequence
        for (int i = 2; i < 15; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }

        // Writing the Fibonacci sequence to a file
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("First 15 numbers of the Fibonacci sequence:");

            string result = string.Empty;
            foreach (int number in fibonacci)
            {
                result += number.ToString() + ",";
            }

            // Remove last ',' if it exists
            if (result.EndsWith(","))
            {
                result = result.Remove(result.Length - 1);
            }

            // Write the Fibonacci sequence to the file
            writer.Write(result);
        }

        Console.WriteLine("Fibonacci sequence saved to 'Fibonacci.txt'");
    }
}