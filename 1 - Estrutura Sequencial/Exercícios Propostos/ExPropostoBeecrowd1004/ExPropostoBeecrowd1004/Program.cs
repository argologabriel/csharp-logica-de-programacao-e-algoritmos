/// Leia dois valores inteiros. A seguir, calcule o produto entre estes dois valores e atribua esta operação à variável PROD. A seguir mostre a variável PROD com mensagem correspondente. ///

using System;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            int ValorInteiro1, ValorInteiro2;
            int PROD;

            // Entrada de Dados;

            Console.WriteLine("Informe o primeiro valor: ");
            ValorInteiro1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor: ");
            ValorInteiro2 = int.Parse(Console.ReadLine());

            // Processamento de Dados

            PROD = ValorInteiro1 * ValorInteiro2;

            // Saída de Dados

            Console.WriteLine("PROD = " + PROD);

            }
        }
    }