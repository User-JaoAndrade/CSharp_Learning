// Faça um Programa que peça as 4 notas bimestrais e mostre a média
using System;

namespace _04_MediaBimestral{
    class Program{
        static void Main()
        {
            double[] notas = new double[4];

            for (int i = 0; i < 4; i+=1){
                Console.Write($"Informe a nota {i+1}: ");
                notas[i] = float.Parse(Console.ReadLine());
            }
            
            Console.Write($"A sua média foi de {(notas[0] + notas[1] + notas[2] + notas[3])/4:F2}");
        }
    }
}