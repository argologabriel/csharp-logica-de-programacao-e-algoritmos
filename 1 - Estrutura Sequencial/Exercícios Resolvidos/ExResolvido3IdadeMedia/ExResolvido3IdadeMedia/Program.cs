/// Fazer um programa para ler o nome (apenas uma palavra) e idade de duas pessoas. Ao final mostrar uma mensagem com os nomes e a idade média entre essas pessoas, com uma casa decimal. ///

using System;
using System.Globalization;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            string nome1, nome2;
            int idade1, idade2;

            double idadeMedia;

            // Entrada de Dados

            Console.WriteLine("Digite o nome e a idade da primeira pessoa: ");
            string[] vetor1 = Console.ReadLine().Split(' ');
            nome1 = vetor1[0];
            idade1 = int.Parse(vetor1[1]);

            Console.WriteLine("Digite o nome e a idade da segunda pessoa: ");
            string[] vetor2 = Console.ReadLine().Split(' ');
            nome2 = vetor2[0];
            idade2 = int.Parse(vetor2[1]);

            // Processamento de Dados

            idadeMedia = (double) (idade1 + idade2) / 2.0;

            // Saída de Dados

            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + idadeMedia.ToString("F1", CultureInfo.InvariantCulture) + " anos");

            }
        }
    }