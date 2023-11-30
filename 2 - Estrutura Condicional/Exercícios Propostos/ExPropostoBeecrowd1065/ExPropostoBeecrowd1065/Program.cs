/*
Faça um programa que leia 5 valores inteiros. Conte quantos destes valores digitados são pares e mostre esta informação.
*/

using System;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            int a, b, c, d, e;
            int contador;

            // Entrada de Dados

            Console.WriteLine("Digite 5 valores inteiros quaisquer: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());

            // Processamento de Dados

            contador = 0;

            if (a % 2 == 0) {
                contador = contador + 1;
            }
            if (b % 2 == 0) {
                contador = contador + 1;
            }
            if (c % 2 == 0) {
                contador = contador + 1;
            }
            if (d % 2 == 0) {
                contador = contador + 1;
            }
            if (e % 2 == 0) {
                contador = contador + 1;
            }

            // Saída de Dados

            Console.WriteLine(contador + " valores pares");
        }
    }
}