using System;
using System.Collections.Generic;
using System.Text;

namespace Prevod_bankoveho_uctu
{
    internal class Calculator
    {
       public void Main(string args)
        {            
            Console.WriteLine("Zadajte číslo Vášho účtu:");
            decimal num1 = Convert.ToDecimal (Console.ReadLine());
            Console.WriteLine("Zadajte číslo účtu od kina:");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());

            char operation = '+';
            decimal result = 0;
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


