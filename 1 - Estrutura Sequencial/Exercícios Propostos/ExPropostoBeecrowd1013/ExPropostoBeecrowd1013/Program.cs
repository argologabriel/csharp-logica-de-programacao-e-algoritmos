// Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”. Utilize a fórmula:

using System;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            int a, b, c;
            int maiorAB, maiorXC;

            // Entrada de Dados

            Console.WriteLine("Digite 3 valores: ");
            string[] valores = Console.ReadLine().Split(' ');

            a = int.Parse(valores[0]);
            b = int.Parse(valores[1]);
            c = int.Parse(valores[2]);

            // Processamento de Dados

            maiorAB = (a + b + Math.Abs(a - b)) / 2;
            maiorXC = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

            // Saída de Dados

            Console.WriteLine(maiorXC + " eh o maior");

            }
        }
    }
