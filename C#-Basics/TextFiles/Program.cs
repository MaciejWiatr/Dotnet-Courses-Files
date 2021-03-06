using System;
using System.IO;

namespace TextFiles
{
    class Program
    {
        static string path = @"../../../";

        // Get file from current directory
        static string Gc(string p1)
        {
            return Path.Combine(path, p1);
        }

        static void ScanAndAppend()
        {
            var files = Directory.GetFiles(Gc("Append/"), "*.txt", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                File.AppendAllText(file, $"{Environment.NewLine}All rights reserved");
            }

        }


        static void ReadFiles()
        {
            Gc("document1.txt");
            var document1 = File.ReadAllText(Gc("document1.txt"));
            var document2 = File.ReadAllLines(Gc("document2.txt"));
            var document2String = string.Join(Environment.NewLine, document2);

            System.Console.WriteLine($"Document 1:\n{document1}\n");

            System.Console.WriteLine($"Document 2:\n{document2String}\n");


        }

        static void GenerateDocuments()
        {
            string name;
            string orderNumber;

            Console.Write("Insert name: ");
            name = Console.ReadLine();
            Console.Write("Insert order number: ");
            orderNumber = Console.ReadLine();

            var template = File.ReadAllText(Gc("template.txt"));
            var document = template.Replace("{name}", name).Replace("{orderNumber}", orderNumber).Replace("{dateTime}", DateTime.Now.ToString());

            File.WriteAllText(Gc($"document-{name}.txt"), document);
        }

        static void Main(string[] args)
        {
            //ReadFiles();
            //GenerateDocuments();
            ScanAndAppend();
        }
    }
}
