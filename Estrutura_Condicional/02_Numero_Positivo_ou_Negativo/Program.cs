// Faça um Programa que peça um valor e mostre na tela se o valor é positivo ou negativo.

using System;

namespace _02_Positivo_ou_Negativo{
    class Program{
        static void Main()
        {
            Console.Write("Informe um número: ");
            float numero = float.Parse(Console.ReadLine());

            if (numero < 0){
                Console.Write($"{numero} é um número negativo");
            } else {
                Console.Write($"{numero} é um número positivo");
            }
        }
    }
}