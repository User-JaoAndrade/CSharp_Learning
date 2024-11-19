// Faça um Programa que peça dois números e imprima o maior deles.

using System;

namespace _01_MaiorNumero{
    class Program{
        static void Main()
        {
            float[] numero = new float[2];

            Console.Write("Número 1: ");
            numero[0] = float.Parse(Console.ReadLine());

            Console.Write("Número 2: ");
            numero[1] = float.Parse(Console.ReadLine());

            if (numero[0] > numero[1]){
                Console.Write($"O maior número é o {numero[0]}");
            } else {
                Console.Write($"O maior número é o {numero[1]}");
            }
            
        }
    }
}