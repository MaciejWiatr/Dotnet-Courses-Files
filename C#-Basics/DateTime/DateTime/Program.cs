﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;

namespace DateTimeEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTimeModification();
            //DateTimeFormatting();
            //TimeMeasurement();
            DateTimeHelpers();
        }

        static void DateTimeModification()
        {
            DateTime now = DateTime.Now;
            DateTime openDate = new DateTime(1992, 6, 17);

            TimeSpan result = now - openDate;

            Console.WriteLine(result.Days);
            Console.WriteLine(result.TotalDays);

            DateTime expiresAt = now.AddDays(7);
            DateTime expiresAt2 = now.Add(new TimeSpan(7, 1, 0, 0));

            Console.WriteLine(expiresAt);
            Console.WriteLine(expiresAt2);

            Console.WriteLine(expiresAt.Date == expiresAt2.Date);
        }

        static void DateTimeFormatting()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToString("g"));
            Console.WriteLine(now.ToString("G"));
            Console.WriteLine(now.ToString("yyyy-MM-dd hh:mm:ss"));
        }

        static void TimeMeasurement()
        {
            Console.WriteLine("What is 2+2");
            Console.WriteLine("a) 4");
            Console.WriteLine("b) 5");
            Console.WriteLine("c) 6");

            DateTime start = DateTime.Now;

            Stopwatch stopwatch = Stopwatch.StartNew();
            string userAnswer = Console.ReadLine();
            stopwatch.Stop();

            DateTime end = DateTime.Now;
            TimeSpan responseTime = end - start;

            Console.WriteLine($"You answered in {responseTime.TotalSeconds}");
            Console.WriteLine($"You answered in {stopwatch.Elapsed.TotalSeconds}");
        }

        static void DateTimeHelpers()
        {
            int daysInFeb2021 = DateTime.DaysInMonth(2021, 2);
            bool is2021LeapYear = DateTime.IsLeapYear(2021);

            Console.WriteLine(daysInFeb2021);
            Console.WriteLine(is2021LeapYear);

        }
    }
}
