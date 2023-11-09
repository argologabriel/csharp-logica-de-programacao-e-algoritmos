/// Faça um programa que calcule e mostre o volume de uma esfera sendo fornecido o valor de seu raio (R). A fórmula para calcular o volume é: (4/3) * pi * R^3. Considere (atribua) para pi o valor 3.14159. ///

using System;
using System.Globalization;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            double raio;
            double volume;

            // Entrada de Dados

            Console.WriteLine("Informe o valor do raio: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Processamento de Dados

            volume = (4 / 3.0) * 3.14159 * Math.Pow(raio, 3.0);

            // Saída de Dados

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));

            }
        }
    }