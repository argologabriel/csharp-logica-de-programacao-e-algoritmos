/*
Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si.
*/

using System;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            int A, B;

            // Entrada de Dados

            Console.WriteLine("Digite dois valores inteiros: ");
            string[] valores = Console.ReadLine().Split(' ');

            A = int.Parse(valores[0]);
            B = int.Parse(valores[1]);

            // Processamento e Saída de Dados

            if (A % B == 0 || B % A == 0) {
                Console.WriteLine("Sao Multiplos");
            }
            else {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}