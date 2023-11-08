/// Calcule o consumo médio de um automóvel sendo fornecidos a distância total percorrida (em Km) e o total de combustível gasto (em litros). ///

using System;
using System.Globalization;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main (string[] args) {

            // Declaração de Variáveis

            int X; // Distância percorrida
            double Y; //Combustível gasto

            double consumoMedio;

            // Entrada de Dados

            Console.WriteLine("Informe a distância percorrida (em Km) pelo automóvel: ");
            X = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o total de combustível gasto (em litros) pelo automóvel: ");
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Processamento de Dados

            consumoMedio = X / Y;

            // Saída de Dados

            Console.WriteLine(consumoMedio.ToString("F3", CultureInfo.InvariantCulture) + " km/l");

            }
        }
    }