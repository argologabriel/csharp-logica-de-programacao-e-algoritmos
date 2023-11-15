/*
A empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo com a tabela abaixo:

                                Salário               Percentual de Reajuste

                                0 - 400.00                    15%
                                400.01 - 800.00               12%
                                800.01 - 1200.00              10%
                                1200.01 - 2000.00              7%
                                Acima de 2000.00               4%

*/

using System;
using System.Globalization;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            double salario;

            int percentual;
            double reajuste;

            // Entrada de Dados

            Console.WriteLine("Digite o valor do seu salário atual: ");
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Processamento de Dados

            if (salario <= 400.00) {
                percentual = 15;
            }
            else if (salario > 400.00 && salario <= 800.00) {
                percentual = 12;
            }
            else if (salario > 800.00 && salario <= 1200.00) {
                percentual = 10;
            }
            else if (salario > 1200.00 && salario <= 2000.00) {
                percentual = 7;
            }
            else {
                percentual = 4;
            }

            reajuste = salario * (percentual / 100.00);
            salario += reajuste;

            // Saída de Dados

            Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentual);
        }
    }
}