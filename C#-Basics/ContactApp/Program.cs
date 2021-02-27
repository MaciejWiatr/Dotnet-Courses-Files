using System;
using System.Collections.Generic;

namespace ContactApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu = $"\nCo chciałbyś zrobić" +
                $"\n1) Dodać kontakt" +
                $"\n2) Wyświetlić kontakt na podstawie numeru" +
                $"\n3) Wyświetlić wszystkie kontakty" +
                $"\n4) Wyszukać kontakty dla danej nazwy" +
                $"\n5) Wyjść" +
                $"\nTwoja odpowiedź: ";

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine(menu);
                if (int.TryParse(Console.ReadLine(), out int userOption))
                {
                    switch (userOption)
                    {
                        case 1:
                            {
                                Console.WriteLine("Podaj imie: ");
                                string nameInput = Console.ReadLine();
                                Console.WriteLine("Podaj numer: ");
                                int numberInput = int.Parse(Console.ReadLine());
                                ContactService.Add(nameInput, numberInput);
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Podaj numer: ");
                                int numberInput = int.Parse(Console.ReadLine());
                                Contact person = ContactService.GetByNumber(numberInput);
                                person.SayHi();
                                break;
                            }
                        case 3:
                            { ContactService.PrintAll(); }
                            break;
                        case 4:
                            {
                                Console.WriteLine("Podaj imie: ");
                                string nameInput = Console.ReadLine();
                                List<Contact> results = ContactService.GetByName(nameInput);
                                ContactService.PrintContacts(results);
                            }
                            break;
                        case 5:
                            {
                                isRunning = false;
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Niewłaściwa odpowiedź");
                    continue;
                }
            }


        }
    }
}
