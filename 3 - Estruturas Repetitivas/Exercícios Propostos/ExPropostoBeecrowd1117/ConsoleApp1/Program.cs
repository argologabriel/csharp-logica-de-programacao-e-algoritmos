/* Faça um programa que leia as notas referentes às duas avaliações de um aluno. Calcule e imprima a média semestral. Faça com que o algoritmo só aceite notas válidas (uma nota válida deve pertencer ao intervalo [0,10]). Cada nota deve ser validada separadamente. */

using System;
using System.Globalization;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Entrada de dados 

            double media;
            double sum = 0.0;
            int cont = 0;

            // Processamento e saída de dados

            while (cont < 2) {

                Console.WriteLine("Informe sua nota: ");
                double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (nota >= 0.0 && nota <= 10.0) {
                    sum = sum + nota;
                    cont++;
                }
                else {
                    Console.WriteLine("nota invalida");
                }
            }
            media = sum / cont;
            Console.WriteLine("media = " + media.ToString(CultureInfo.InvariantCulture));
        }
    }
}