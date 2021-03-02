using System;

namespace TryParseExercise
{
    class Program
    {
        static bool TryParseNegativeInt(string value, out int result)
        {
            if (int.TryParse(value, out result))
            {

                if (result < 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                result = default;
                return false;
            }

        }

        static void Main(string[] args)
        {
            int inputVal;

            while (!TryParseNegativeInt(Console.ReadLine(), out inputVal))
            {
                Console.WriteLine("Insert negative number");
            }

            Console.WriteLine($"Inserted negative number: {inputVal}");
        }
    }
}
