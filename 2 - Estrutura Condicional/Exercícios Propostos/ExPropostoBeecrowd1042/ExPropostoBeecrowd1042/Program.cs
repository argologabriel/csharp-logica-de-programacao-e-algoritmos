/*
Leia 3 valores inteiros e ordene-os em ordem crescente. No final, mostre os valores em ordem crescente, uma linha em branco e em seguida, os valores na sequência como foram lidos.
*/

using System;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            int a, b, c;
            int menor, meio, maior;

            // Entrada de Dados

            Console.WriteLine("Digite 3 valores inteiros: ");
            string[] valores = Console.ReadLine().Split(' ');

            a = int.Parse(valores[0]);
            b = int.Parse(valores[1]);
            c = int.Parse(valores[2]);

            // Processamento de Dados

            if (a < b && a < c) {
                menor = a;

                if (b < c) {
                    meio = b;
                    maior = c;
                }

                else {
                    meio = c;
                    maior = b;
                }
            }

            else if (b < c) {
                menor = b;

                if (a < c) {
                    meio = a;
                    maior = c;
                }
                else {
                    meio = c;
                    maior = a;
                }
            }

            else {
                menor = c;

                if (a < b) {
                    meio = a;
                    maior = b;
                }
                else {
                    meio = b;
                    maior = a;
                }
            }

            // Saída de Dados

            Console.WriteLine(menor);
            Console.WriteLine(meio);
            Console.WriteLine(maior);

            Console.WriteLine();

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);   
        }
    }
}