using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Prevod_bankoveho_uctu
{
    internal class Movies
    {      
        public void Main(string[] args)
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fileName = "Movie.txt";
            string fileLocale = Path.Combine(folder, fileName);
            if (!File.Exists(fileLocale))
            {
                Console.WriteLine("Súbor s používateľskými filmami neexistuje.");
                Console.ReadKey();
                return;
            }

            string[] movies = File.ReadAllLines(fileLocale);

            if (movies.Length == 0)
            {
                Console.WriteLine("Súbor je prázdny.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Dostupné filmy:");
            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + movies[i]);
            }

            int choice = 0;

            while (true)
            {
                Console.Write("\nVyberte číslo filmu (1 - 20): ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out choice))
                {
                    Console.WriteLine("Nesprávny film, skúste to znova.");
                    continue;
                }

                if (choice < 01 || choice > 20)
                {
                    Console.WriteLine("Nesprávny film, skúste to znova.");
                    continue;
                }

                break;
            }

            string selectedAccount = movies[choice - 1];
            Console.WriteLine("Vybrali ste účet: " + selectedAccount);

            Console.WriteLine("Ak by ste chceli, tak ponúkame aj snacky.");
            Console.WriteLine("Pre snack zadajte 'A', pre žiadny snack zadajte 'N'.");
            Console.Write("> ");

            string input_ = Console.ReadLine();
            Dictionary<string, int> selectedSnacks = new Dictionary<string, int>();

            if (input_.ToUpper() == "A")
            {
                Console.WriteLine("Ponúkame tieto snacky: ");
                Console.WriteLine("1. Popcorn - 2 eura");
                Console.WriteLine("2. Nachos - 2,50 eur");
                Console.WriteLine("3. Sladkosti - 1 euro");
                Console.WriteLine("4. Nápoje - Coca Cola, Nestea, Minerálka - 2,50 eur");
                Console.WriteLine("Zadajte číslo snacku alebo napíšte 'to je všetko'.");

                while (true)
                {
                    Console.Write("> ");
                    string snackChoice = Console.ReadLine();

                    if (snackChoice.ToLower() == "to je všetko")
                    {
                        
                    }

                    string snackName = "";

                    switch (snackChoice)
                    {
                        case "1":
                            snackName = "Popcorn";
                            break;
                        case "2":
                            snackName = "Nachos";
                            break;
                        case "3":
                            snackName = "Sladkosti";
                            break;
                        case "4":
                            snackName = "Nápoje";
                            break;
                        default:
                            Console.WriteLine("Neplatný výber, skúste znova.");
                            continue;
                    }

                    Console.Write("Zadajte počet kusov: ");
                    if (int.TryParse(Console.ReadLine(), out int count) && count > 0)
                    {
                        if (selectedSnacks.ContainsKey(snackName))
                        {
                            selectedSnacks[snackName] += count;
                        }
                        else
                        {
                            selectedSnacks.Add(snackName, count);
                        }

                        Console.WriteLine($"{snackName} – pridané {count} ks.");
                    }
                    else
                    {
                        Console.WriteLine("Neplatný počet.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Rozumiem, žiadny snack.");
            }

            Console.WriteLine("\nVybrali ste si tieto snacky:");

            if (selectedSnacks.Count == 0)
            {
                Console.WriteLine("Žiadne snacky.");
            }
            else
            {
                foreach (var snack in selectedSnacks)
                {
                    Console.WriteLine($"- {snack.Key}: {snack.Value} ks");
                }
            }

            Console.ReadKey();
        }
    }
}
