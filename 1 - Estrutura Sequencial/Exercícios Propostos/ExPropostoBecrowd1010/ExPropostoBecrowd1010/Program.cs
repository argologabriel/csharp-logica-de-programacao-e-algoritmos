/// Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago. //

using System;
using System.Globalization;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            int codigoPeca1, numeroPeca1;
            double valorPeca1;
            string[] vetorPeca1;

            int codigoPeca2, numeroPeca2;
            double valorPeca2;
            string[] vetorPeca2;

            double valorPagamento;

            // Entrada de Dados

            Console.WriteLine("Informe número, código e valor da peça 1: ");
            vetorPeca1 = Console.ReadLine().Split(' ');

            codigoPeca1 = int.Parse(vetorPeca1[0]);
            numeroPeca1 = int.Parse(vetorPeca1[1]);
            valorPeca1 = double.Parse(vetorPeca1[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Informe número, código e valor da peça 2: ");
            vetorPeca2 = Console.ReadLine().Split(' ');

            codigoPeca2 = int.Parse(vetorPeca2[0]);
            numeroPeca2 = int.Parse(vetorPeca2[1]);
            valorPeca2 = double.Parse(vetorPeca2[2], CultureInfo.InvariantCulture);

            // Processamento de Dados

            valorPagamento = (valorPeca1 * numeroPeca1) + (valorPeca2 * numeroPeca2);

            // Saída de Dados

            Console.WriteLine("VALOR A PAGAR: R$ " + valorPagamento.ToString("F2", CultureInfo.InvariantCulture));

            }
        }
    }
