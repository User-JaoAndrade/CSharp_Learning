// Faça um Programa que verifique se uma letra digitada é vogal ou consoante.

using System;

namespace _04_Vogal_ou_Consoante{
    class Program{
        static void Main()
        {
            Console.Write("Informe uma letra: ");
            char letra = char.Parse(Console.ReadLine());

            if (letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U'){
                Console.Write($"{letra} é uma vogal");
            } else {
                Console.Write($"{letra} é uma consoante");
            }
        }
    }
}