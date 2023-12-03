/*
Leia um valor inteiro X. Em seguida apresente os 6 valores ímpares consecutivos a partir de X, um valor por linha, inclusive o X ser for o caso.
*/

using System;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            int x;

            // Entrada de Dados

            Console.WriteLine("Informe o valor de X: ");
            x = int.Parse(Console.ReadLine());

            // Processamento de Dados

            if (x % 2 == 0) {
                x = x + 1;
            }

            // Saída de Dados

            Console.WriteLine(x);
            Console.WriteLine(x + 2);
            Console.WriteLine(x + 4);
            Console.WriteLine(x + 6);
            Console.WriteLine(x + 8);
            Console.WriteLine(x + 10);

        }
    }
}