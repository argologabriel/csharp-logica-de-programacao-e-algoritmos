/// Leia dois valores inteiros, no caso para variáveis A e B. A seguir, calcule a soma entre elas e atribua à variável SOMA. A seguir escrever o valor desta variável. ///

using System;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            int A, B;
            int SOMA;

            // Entrada de Dados

            Console.WriteLine("Informe o valor da variável A: ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor da variável B: ");
            B = int.Parse(Console.ReadLine());

            // Processamento de Dados

            SOMA = A + B;

            // Saída de Dados

            Console.WriteLine("SOMA = " + SOMA);

            }
        }
    }