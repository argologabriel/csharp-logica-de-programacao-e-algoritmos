/// Leia quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D) ///

using System;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            int A, B, C, D;
            int DIFERENCA;

            // Entrada de Dados

            Console.WriteLine("Informe o valor de A: ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de B: ");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de C: ");
            C = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de D: ");
            D = int.Parse(Console.ReadLine());

            // Processamento de Dados

            DIFERENCA = (A * B) - (C * D);

            // Saída de Dados

            Console.WriteLine("DIFERENCA = " + DIFERENCA);

            }
        }
    }