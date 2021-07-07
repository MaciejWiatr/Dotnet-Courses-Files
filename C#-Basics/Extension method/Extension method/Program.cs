using System;

namespace Extension_method
{
    class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now;
            var before = now.Subtract(new TimeSpan(7, 0, 0, 0));
            var after = now.AddDays(7);

            bool isDateBetween = Utils.IsDateBetween(now, before, after);
            Console.WriteLine(isDateBetween);
            Console.WriteLine(now.IsBetween(before, after));
            Console.WriteLine(2.Squared());
        }
    }
}
