/*
Faça um programa que leia 6 valores. Estes valores serão somente negativos ou positivos (desconsidere os valores nulos). A seguir, mostre a quantidade de valores positivos digitados.
*/

using System;
using System.Globalization;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            double a, b, c, d, e, f;
            int contador;

            // Entrada de Dados
            
            Console.WriteLine("Digite seis valores, sejam eles negativos ou positivos: ");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Processamento de Dados

            contador = 0;

            if (a > 0.0) {
                contador = contador + 1;
            }
            if (b > 0.0) {
                contador = contador + 1;
            }
            if (c > 0.0) {
                contador = contador + 1;
            }
            if (d > 0.0) {
                contador = contador + 1;
            }
            if (e > 0.0) {
                contador = contador + 1;
            }
            if (f > 0.0) {
                contador = contador + 1;
            }

            // Saída de Dados

            Console.WriteLine(contador + " valores positivos");
        }
    }
}