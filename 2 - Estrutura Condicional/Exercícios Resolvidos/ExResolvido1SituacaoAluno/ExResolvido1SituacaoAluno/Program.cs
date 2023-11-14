/* 
Fazer um programa para ler as duas notas que um aluno obteve no primeiro e segundo semestres de uma disciplina anual. Em seguida, mostrar a nota final que o aluno obteve no ano juntamente com um texto explicativo. Caso a nota final do aluino seja inferior a 60.00, mostrar a mensagem "REPROVADO". Todos os valores devem ter uma casa decimal.
*/

using System;
using System.Globalization;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            double nota1, nota2;
            double notaFinal;

            // Entrada de Dados

            Console.WriteLine("Informe a nota do primeiro semestre: ");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe a nota do segundo semestre: ");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Processamento de Dados

            notaFinal = nota1 + nota2;

            // Saída de Dados

            Console.WriteLine("NOTA FINAL = " + notaFinal.ToString("F1", CultureInfo.InvariantCulture));

            if (notaFinal < 60.0) {

                Console.WriteLine("REPROVADO");

                }
            }
        }
    }
