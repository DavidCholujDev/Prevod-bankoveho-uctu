using System;
using System.Collections.Generic;
using System.Text;

namespace Prevod_bankoveho_uctu
{
    internal class Calculator: Movies
    {
       public void Main(string[] args)
        {            
            Console.WriteLine("Zadajte číslo Vášho účtu:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadajte číslo účtu od kina:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            char operation = '+';
            double result = 0;
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;                             
                default:
                    Console.WriteLine("Neplatná operácia.");
                    return;
            }
            Console.WriteLine($"Výsledok: {result}");
            Console.ReadKey();
        }
    }
}


