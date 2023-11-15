/*
Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.

                                        CODIGO          ESPECIFICAÇÃO          PREÇO

                                        1               Cachorro Quente        R$ 4.00
                                        2               X-Salada               R$ 4.50
                                        3               X-Bacon                R$ 5.00
                                        4               Torrada Simples        R$ 2.00
                                        5               Refrigerante           R$ 1.50
*/

using System;
using System.Globalization;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            int codigo, quantidade;
            double total;

            // Entrada de Dados

            Console.WriteLine("Digite o código e a quantidade do item que deseja: ");
            string[] valores = Console.ReadLine().Split(' ');

            codigo = int.Parse(valores[0]);
            quantidade = int.Parse(valores[1]);

            // Processamento e Saída de Dados

            if (codigo == 1) {
                total = quantidade * 4.00;
            }

            else if (codigo == 2) {
                total = quantidade * 4.50;
            }

            else if (codigo == 3) {
                total = quantidade * 5.00;
            }

            else if (codigo == 4) {
                total = quantidade * 2.00;
            }

            else {
                total = quantidade * 1.50;
            }

            // Saída de Dados

            Console.WriteLine("Total = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}