/// Leia 2 valores inteiros e armazene-os nas variáveis A e B. Efetue a soma de A e B atribuindo o seu resultado na variável X. Imprima X. ///

using System;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            int A, B;
            int X;

            // Entrada de Dados

            Console.WriteLine("Digite o valor de A: ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            B = int.Parse(Console.ReadLine());

            // Processamento de Dados

            X = A + B;

            // Saída de Dados

            Console.WriteLine("X = " + X);
        }
    }
}