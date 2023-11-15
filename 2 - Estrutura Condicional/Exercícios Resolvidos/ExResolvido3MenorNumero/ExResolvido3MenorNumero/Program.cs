/*
Fazer um programa para ler três números inteiros. Em seguida, mostrar qual o menor dentre os três números lidos. Em caso de empate, mostrar apenas uma vez.
*/

using System;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            int valor1, valor2, valor3;

            // Entrada de Dados
             
            Console.WriteLine("Digite 3 números inteiros: ");
            string[] valores = Console.ReadLine().Split(' ');

            valor1 = int.Parse(valores[0]);
            valor2 = int.Parse(valores[1]);
            valor3 = int.Parse(valores[2]);

            // Processamento e Saída de Dados
            
            if (valor1 < valor2 && valor1 < valor3) {

                Console.WriteLine("MENOR = " + valor1);
            }

            else if (valor2 < valor3) {

                Console.WriteLine("MENOR = " + valor2);
            }

            else {

                Console.WriteLine("MENOR = " + valor3);
            }
        }
    }
}