// Faça um Programa que calcule a área de um quadrado, em seguida mostre o dobro desta área para o usuário.

using System;

namespace _07_Dobrando_a_Area_de_um_quadrado{
    class Program{
        static void Main()
        {
            Console.Write("Informe o comprimento do lado do quadrado: ");
            float sqr_lado = float.Parse(Console.ReadLine());  

            float sqr_area = (float)Math.Pow(sqr_lado, 2); // Calculando a área

            Console.Write($"\nO Dobro da Área do quadrado é {sqr_area * 2}");
        }
    }
}