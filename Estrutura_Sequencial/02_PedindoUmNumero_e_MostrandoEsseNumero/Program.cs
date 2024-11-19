// Faça um Programa que peça um número e então mostre a mensagem O número informado foi [número].
using System;

namespace _PedindoUmNumero_e_MostrandoEsseNumero{
    class Program{
        static void Main()
        {
            Console.Write("Me informe um número: "); 
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nO número informado foi {number}");
        }
    }
}