using System;

namespace Second_Project
{
    class Program
    {
        static void Double(int value)
        {
            value = 2 * value;
            Console.WriteLine($"Doubled var: {value}");
        }

        static bool IsDivisible(int val, int factor, out int reminder)
        {
            reminder = val % factor;

            return reminder == 0;
        }

        static void Main()
        {
            int someValue = 5;
            Double(someValue);

            Console.WriteLine($"Somevalue: {someValue}");

            int value = 5;
            int factor = 2;
            int reminder;

            if (IsDivisible(value, factor, out reminder))
            {
                Console.WriteLine($"{value} is divisible by {factor}");
            }
            else
            {
                Console.WriteLine($"{value} is not divisible by {factor}. Reminder: {reminder}");
            }

        }
    }
}
