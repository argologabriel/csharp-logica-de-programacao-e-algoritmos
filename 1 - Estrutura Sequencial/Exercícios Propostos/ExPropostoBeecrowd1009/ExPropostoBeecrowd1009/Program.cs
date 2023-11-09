/// Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês (em dinheiro). Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas, informar o total a receber no final do mês, com duas casas decimais. ///

using System;
using System.Globalization;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            string nome;
            double salario, vendas;

            double total;

            // Entrada de Dados

            Console.WriteLine("Informe o nome do vendedor: ");
            nome = Console.ReadLine();

            Console.WriteLine("Informe o salário do vendedor: ");
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe quantas vendas foram efetuadas (em dinheiro): ");
            vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Processamento de Dados

            total = salario + (vendas * 0.15);

            // Saída de Dados

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo. InvariantCulture));

            }
        }
    }