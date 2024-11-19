// Faça um Programa que peça dois números e imprima a soma.

using System;

namespace _03_SomandoDoisNumeros_{
    class Program
    {
        static void Main()
        {
            Console.Write("Informe um número: "); 
            int number = int.Parse(Console.ReadLine());

            Console.Write("\nInforme outro número: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.Write($"\n{number} + {number2} = {number + number2}");
        }
    }
}