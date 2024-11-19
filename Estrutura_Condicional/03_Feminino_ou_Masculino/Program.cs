// Faça um Programa que verifique se uma letra digitada é "F" ou "M".
//Conforme a letra escrever: F - Feminino, M - Masculino, Sexo Inválido.

using System;

namespace _03_F_or_M{
    class Program{
        static void Main()
        {
            Console.Write("[M] Masculino\n[F] Feminino\n[Other] Sexo Inválido\n-> ");
            char letra = char.Parse(Console.ReadLine());

            if (letra == 'F'){
                Console.Write("Feminino");
            } else if (letra == 'M'){
                Console.Write("Masculino");
            } else {
                Console.Write("Sexo Inválido");
            }
        }
    }
}