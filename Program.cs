using System;

class Program
{
    static void Main()
    {
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
}