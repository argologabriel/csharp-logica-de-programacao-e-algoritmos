/*
Faça um algoritmo para ler um número indeterminado de dados, contendo cada um, a idade de um indivíduo. O último dado, que não entrará nos cálculos, contém o valor de idade negativa. Calcular e imprimir a idade média deste grupo de indivíduos.
*/

using System;
using System.Globalization;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            int cont = 0;
            double sum = 0.0;

            while (idade >= 0) {
                sum = sum + idade;
                cont++;

                Console.WriteLine("Digite a sua idade: ");
                idade = int.Parse(Console.ReadLine());
            }
            double media = sum / cont;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}