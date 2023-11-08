/// Fazer um programa para ler as medidas da base e altura de um retângulo. Em seguida, mostrar o valor da área, perímetro e diagonal deste retângulo, com quatro casas decimais ///

using System;
using System.Globalization;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            double BASE, ALTURA;
            double AREA, PERIMETRO, DIAGONAL;

            // Entrada de Dados 

            Console.WriteLine("Informe o valor da base do retângulo: ");
            BASE = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o valor da altura do retângulo: ");
            ALTURA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Processamento de Dados 

            AREA = BASE * ALTURA;

            PERIMETRO = (BASE * 2.0) + (ALTURA * 2.0);

            DIAGONAL = Math.Sqrt(Math.Pow(BASE, 2.0) + Math.Pow(ALTURA, 2.0));

            // Saída de Dados

            Console.WriteLine("AREA = " + AREA.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("PERIMETRO = " + PERIMETRO.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("DIAGONAL = " + DIAGONAL.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}