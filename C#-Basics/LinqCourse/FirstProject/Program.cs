using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

// ReSharper disable UseFormatSpecifierInInterpolation

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string csvPath = @"googleplaystore1.csv";
            var googleApps = LoadGoogleAps(csvPath);

            //ProjectData(googleApps);
            //DivideData(googleApps);
            //OrderData(googleApps);
            //DataSetOperation(googleApps);
            DataVerification(googleApps);

        }

        static void DataVerification(IEnumerable<GoogleApp> googleApps)
        {
            var allOperatorResult = googleApps.Where(a => a.Category == Category.WEATHER).All(a => a.Reviews > 15);
            Console.WriteLine(allOperatorResult);

            var anyBiggerThan2Mil = googleApps.Where(a => a.Category == Category.WEATHER).Any(a => a.Reviews > 2_000_000);
            Console.WriteLine(anyBiggerThan2Mil);
        }

        static void DataSetOperation(IEnumerable<GoogleApp> googleApps)
        {
            //var paidAppsCategories = googleApps.Where(a => a.Type == Type.Paid).Select(a => a.Category).Distinct();
            //Console.WriteLine(string.Join(", ", paidAppsCategories));

            var setA = googleApps.Where(a => a.Rating > 4.7 && a.Type == Type.Paid && a.Reviews > 1000);
            var setB = googleApps.Where(a => a.Name.Contains("Pro") && a.Rating > 4.6 && a.Reviews > 10000);
            //Display(setA);
            //Console.WriteLine("--------------------");
            //Display(setB);
            var appsUnion = setA.Union(setB);
            Console.WriteLine("Apps union ===============================");
            Display(appsUnion);
            Console.WriteLine("Apps intersect ===========================");
            var appsIntersect = setA.Intersect(setB);
            Display(appsIntersect);
            Console.WriteLine("Apps except ===========================");
            var appsExcept = setA.Except(setB);
            Display(appsExcept);

        }

        static void OrderData(IEnumerable<GoogleApp> googleApps)
        {
            var highRatedBeautyApps = googleApps.Where((app) => app.Rating > 4.4 && app.Category == Category.BEAUTY);
            var sortedResults = highRatedBeautyApps.OrderByDescending(app => app.Rating).ThenBy(app => app.Name).Take(5);
            Display(sortedResults);
        }

        static void DivideData(IEnumerable<GoogleApp> googleApps)
        {
            var highRatedBeautyApps = googleApps.Where((app) => app.Rating > 4.6 && app.Category == Category.BEAUTY);

            //var first5HighRatedBeautyApps = highRatedBeautyApps.TakeWhile(app => app.Reviews > 1000)

            //Display(first5HighRatedBeautyApps);

            var skippedApps = highRatedBeautyApps.Skip(5);
            Display(googleApps);
        }

        static void ProjectData(IEnumerable<GoogleApp> googleApps)
        {
            var highRatedBeautyApps = googleApps.Where((app) => app.Rating > 4.6 && app.Category == Category.BEAUTY);
            var highRatedBeautyAppNames = highRatedBeautyApps.Select(app => app.Name);

            var anonymousDtos = highRatedBeautyApps.Select(app => new { Name = app.Name, Reviews = app.Reviews });

            Console.WriteLine(string.Join(",", highRatedBeautyAppNames));


            foreach (var googleAppDto in anonymousDtos)
            {
                Console.WriteLine($"{googleAppDto.Name} - {googleAppDto.Reviews}");
            }


            var genres = highRatedBeautyApps.SelectMany(app => app.Genres);
            Console.WriteLine(string.Join(";", genres));
        }

        static void GetData(IEnumerable<GoogleApp> googleApps)
        {
            var highRatedApps = googleApps.Where((app) => app.Rating > 4.6);
            var highRatedBeautyApps = googleApps.Where((app) => app.Rating > 4.6 && app.Category == Category.BEAUTY);
            //Display(highRatedBeautyApps);

            var firstHighRatedBeautyApp = highRatedBeautyApps.FirstOrDefault((app) => app.Reviews < 50);
            Console.WriteLine(firstHighRatedBeautyApp);
            Console.WriteLine(highRatedBeautyApps.SingleOrDefault(app => app.Reviews < 200));
        }

        static void Display(IEnumerable<GoogleApp> googleApps)
        {
            foreach (var googleApp in googleApps)
            {
                Console.WriteLine(googleApp);
            }

        }
        static void Display(GoogleApp googleApp)
        {
            Console.WriteLine(googleApp);
        }

        static List<GoogleApp> LoadGoogleAps(string csvPath)
        {
            using (var reader = new StreamReader(csvPath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<GoogleAppMap>();
                var records = csv.GetRecords<GoogleApp>().ToList();
                return records;
            }

        }

    }


}
