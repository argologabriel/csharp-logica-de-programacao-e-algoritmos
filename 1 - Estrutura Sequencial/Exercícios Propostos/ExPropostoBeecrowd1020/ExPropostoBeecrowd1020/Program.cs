/*
Leia um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias

Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias. Nos casos de teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364. Este é apenas um exercício com objetivo de testar raciocínio matemático simples.
*/

using System;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            int anos, meses, dias, resto;

            // Entrada de Dados

            Console.WriteLine("Digite a idade (em dias) de uma pessoa: ");
            dias = int.Parse(Console.ReadLine());

            // Processamento de Dados

            resto = dias;

            anos = resto / 365;
            resto = resto % 365;
            meses = resto / 30;
            dias = resto % 30;

            // Saída de Dados

            Console.WriteLine(anos + " ano (s)");
            Console.WriteLine(meses + " mes (es)");
            Console.WriteLine(dias + " dia (s)");

            }
        }
    }