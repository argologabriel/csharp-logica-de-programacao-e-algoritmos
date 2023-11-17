/*
Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.

O símbolo ( representa "maior que". Por exemplo:
[0,25]  indica valores entre 0 e 25.0000, inclusive eles.
(25,50] indica valores maiores que 25 Ex: 25.00001 até o valor 50.0000000
*/

using System;
using System.Globalization;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            double valor;
            string intervalo;

            // Entrada de Dados

            Console.WriteLine("Digite um valor qualquer: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Processamento de Dados

            if (valor >= 0.0 && valor <= 25.0) {
                intervalo = "Intervalo [0,25]";
            }
            else if (valor >= 0.0 && valor <= 50.0) {
                intervalo = "Intervalo (25,50]";
            }
            else if (valor >= 0.0 && valor <= 75.0) {
                intervalo = "Intervalo (50,75]";
            }
            else if (valor >= 0.0 && valor <= 100.0) {
                intervalo = "Intervalo (75,100])";
            }
            else {
                intervalo = "Fora de intervalo";
            }

            // Saída de Dados

            Console.WriteLine(intervalo);

        }
    }
}