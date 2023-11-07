/// Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais. ///

using System;
using System.Globalization;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            int numeroFuncionario, horasTrabalhadas;
            double valorHora;

            double salarioFuncionario;

            // Entrada de Dados

            Console.WriteLine("Informe o número do funcionário: ");
            numeroFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número de horas trabalhadas: ");
            horasTrabalhadas = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor que o funcionário recebe por hora trabalhada: ");
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Processamento de Dados

            salarioFuncionario = (valorHora * horasTrabalhadas);

            // Saída de Dados

            Console.WriteLine("NUMBER = " + numeroFuncionario);
            Console.WriteLine("SALARY = U$ " + salarioFuncionario.ToString("F2", CultureInfo.InvariantCulture));

            }
        }
    }