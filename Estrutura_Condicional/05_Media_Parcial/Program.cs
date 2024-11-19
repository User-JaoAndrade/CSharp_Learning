/* Faça um programa para a leitura de duas notas parciais de um aluno.
 O programa deve calcular a média alcançada por aluno e apresentar:
    A mensagem "Aprovado", se a média alcançada for maior ou igual a sete;
    A mensagem "Reprovado", se a média for menor do que sete;
    A mensagem "Aprovado com Distinção", se a média for igual a dez */

using System;
using System.Net.Http.Headers;

namespace _05_MediaParcial{
    class Program{
        static void Main()
        {
            float[] nota = new float[2];
            Console.Write("Informe a primeira nota: ");
            nota[0] = float.Parse(Console.ReadLine());

            Console.Write("Informe a segunda nota: ");
            nota[1] = float.Parse(Console.ReadLine());

            float media = (nota[0] + nota[1]) / 2;

            if(media >= 7){
                Console.Write("Aprovado");
            } else if (media < 7){
                Console.Write("Reprovado");
            } else if (media == 10) {
                Console.Write("Aprovado com Distinção");
            }
        }
    }
}