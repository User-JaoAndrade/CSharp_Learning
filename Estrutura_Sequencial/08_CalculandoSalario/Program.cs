/* Faça um Programa que pergunte quanto você ganha por hora e o número de horas trabalhadas no mês. 
Calcule e mostre o total do seu salário no referido mês.*/

using System;

namespace _08_CalculandoSalario{
    class Program{
        static void Main()
        {
            Console.Write("Quanto você recebe por hora?\n-> ");
            float ganho_por_hora = float.Parse(Console.ReadLine());

            Console.Write("Quantas horas trabalhou esse mês?\n-> ");
            int horas_trabalhadas = int.Parse(Console.ReadLine());

            Console.Write($"Seu salário vai ser de {ganho_por_hora * horas_trabalhadas}");
        }
    }
}