/* Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma). */

using System;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Entrada de dados 

            Console.WriteLine("Digite os valores para X e Y: ");

            string[] input = Console.ReadLine().Split(" ");

            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);

            // Processamento e saída de dados

            while (x != 0 && y != 0) {

                if (x > 0 && y > 0) {
                    Console.WriteLine("primeiro");
                }

                else if (x < 0 && y > 0) {
                    Console.WriteLine("segundo");
                }

                else if (x < 0 && y < 0) {
                    Console.WriteLine("terceiro");
                }

                else {
                    Console.WriteLine("quarto");
                }

                Console.WriteLine("Digite os valores para X e Y: ");

                input = Console.ReadLine().Split();

                x = int.Parse(input[0]);
                y = int.Parse(input[1]);
            }
        }
    }
}