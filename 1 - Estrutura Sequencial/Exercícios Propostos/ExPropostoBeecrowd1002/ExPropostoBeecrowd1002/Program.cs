/// A fórmula para calcular a área de uma circunferência é: area = π . raio2. Considerando para este problema que π = 3.14159: Efetue o cálculo da área, elevando o valor de raio ao quadrado e multiplicando por π. ///

using System;
using System.Globalization;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            double pi, raio;
            double area;

            // Entrada de Dados

            pi = 3.14159;

            Console.WriteLine("Informe o valor do raio: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Processamento de Dados

            area = pi * Math.Pow(raio, 2);

            // Saída de Dados

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}