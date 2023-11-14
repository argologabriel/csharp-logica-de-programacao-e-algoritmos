/*
Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara. Se não for possível calcular as raízes, mostre a mensagem correspondente “Impossivel calcular”, caso haja uma divisão por 0 ou raiz de numero negativo.
*/

using System;
using System.Globalization;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            double A, B, C;
            double delta, R1, R2;

            // Entrada de Dados

            Console.WriteLine("Digite os valores de A, B e C: ");
            string[] valores = Console.ReadLine().Split(' ');

            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            // Processamento e Saída de Dados

            delta = (Math.Pow(B, 2.0)) - (4.0 * A * C);

            if (A == 0 || delta < 0) {

                Console.WriteLine("Impossível calcular");

            }

            else {

                R1 = (-B + Math.Sqrt(delta)) / (2 * A);
                R2 = (-B - Math.Sqrt(delta)) / (2 * A);

                Console.WriteLine("R1 = " + R1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + R2.ToString("F5", CultureInfo.InvariantCulture));

            }
        }
    }
}