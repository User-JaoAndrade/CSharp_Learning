// Faça um Programa que converta metros para centímetros.

using System;

namespace _05_ConvertendoMetros_paraCentimetros{
    class Program{
        static void Main()
        {
            Console.Write("Informe um número para converter para metros: ");
            float metros = float.Parse(Console.ReadLine());

            Console.Write($"{metros}m = {metros * 100}cm");
        }
    }
}