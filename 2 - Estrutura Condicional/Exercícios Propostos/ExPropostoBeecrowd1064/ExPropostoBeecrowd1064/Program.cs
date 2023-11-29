/*
Leia 6 valores. Em seguida, mostre quantos destes valores digitados foram positivos. Na próxima linha, deve-se mostrar a média de todos os valores positivos digitados, com um dígito após o ponto decimal.
*/

using System;
using System.Globalization;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            double a, b, c, d, e, f;
            int contador;
            double soma, media;

            // Entrada de Dados

            Console.WriteLine("Digite seis números, sendo pelo menos um deles, positivo: ");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Processamento de Dados

            contador = 0;
            soma = 0.0;

            if (a > 0.0) {
                contador = contador + 1;
                soma = soma + a;
            }
            if (b > 0.0) {
                contador = contador + 1;
                soma = soma + b;
            }
            if (c > 0.0) {
                contador = contador + 1;
                soma = soma + c;
            }
            if (d > 0.0) {
                contador = contador + 1;
                soma = soma + d;
            }
            if (e > 0.0) {
                contador = contador + 1;
                soma = soma + e;
            }
            if (f > 0.0) {
                contador = contador + 1;
                soma = soma + f;
            }

            media = soma / contador;

            // Saída de Dados

            Console.WriteLine(contador + " valores positivos");

            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}