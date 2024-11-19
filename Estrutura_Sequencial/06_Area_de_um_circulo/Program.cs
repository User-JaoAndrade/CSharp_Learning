// Faça um Programa que peça o raio de um círculo, calcule e mostre sua área.

using System;

namespace _06_Area_de_um_circulo{
    class Program{
        static void Main()
        {
            Console.Write("Informe o Raio de um Circulo: ");
            float raio_circulo = float.Parse(Console.ReadLine());

            Console.Write($"A Área do Circulo é de: {3.14 * (raio_circulo * raio_circulo)}");
        }
    }
}