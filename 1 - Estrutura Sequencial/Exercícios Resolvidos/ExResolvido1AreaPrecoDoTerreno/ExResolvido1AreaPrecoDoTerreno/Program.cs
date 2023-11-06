/// Fazer um programa para ler as medidas da lagura e comprimento de um terreno retangular com uma casa decimal, bem como o valor do metro quadrado doterreno com duas casas decimais. Em seguida, o programa deve mostrar o valor da área do terreno, bem como o valor do preço do terreno, ambos com duas casas decimais. ///

using System;
using System.Globalization;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            double larguraTerreno;
            double comprimentoTerreno;
            double precoMetro2;

            double areaTerreno;
            double precoTerreno;

            // Entrada de Dados

            Console.WriteLine("Informe a largura do terreno: ");
            larguraTerreno = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o comprimento do terreno: ");
            comprimentoTerreno = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o valor do metro quadrado do terreno: ");
            precoMetro2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Processamento de Dados

            areaTerreno = larguraTerreno * comprimentoTerreno;
            precoTerreno = areaTerreno * precoMetro2;

            // Saída de Dados

            Console.WriteLine("AREA = " + areaTerreno.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO = " + precoTerreno.ToString("F2", CultureInfo.InvariantCulture));

            }
        }
    }