/*
Pedrinho está organizando um evento em sua Universidade. O evento deverá ser no mês de Abril, iniciando e terminando dentro do mês. O problema é que Pedrinho quer calcular o tempo que o evento vai durar, uma vez que ele sabe quando inicia e quando termina o evento.

Sabendo que o evento pode durar de poucos segundos a vários dias, você deverá ajudar Pedrinho a calcular a duração deste evento.

Como entrada, na primeira linha vai haver a descrição “Dia”, seguido de um espaço e o dia do mês no qual o evento vai começar. Na linha seguinte, será informado o momento no qual o evento vai iniciar, no formato hh : mm : ss. Na terceira e quarta linha de entrada haverá outra informação no mesmo formato das duas primeiras linhas, indicando o término do evento.
*/

using System;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            int W1, X1, Y1, Z1, W2, X2, Y2, Z2, W, X, Y, Z;
            int inicio, fim, duracao, resto;

            // Entrada de Dados

            Console.WriteLine("Informe o dia(Dia dd) de início do evento: ");
            string[] valores = Console.ReadLine().Split(' ');
            W1 = int.Parse(valores[1]);

            Console.WriteLine("Informe o horáio(hh : mm : ss) de início do evento: ");
            valores = Console.ReadLine().Split(' ');
            X1 = int.Parse(valores[0]);
            Y1 = int.Parse(valores[2]);
            Z1 = int.Parse(valores[4]);

            Console.WriteLine("Informe o dia(Dia dd) de término do evento: ");
            valores = Console.ReadLine().Split(' ');
            W2 = int.Parse(valores[1]);

            Console.WriteLine("Informe o horário(hh : mm : ss) de término do evento: ");
            valores = Console.ReadLine().Split(' ');
            X2 = int.Parse(valores[0]);
            Y2 = int.Parse(valores[2]);
            Z2 = int.Parse(valores[4]);

            // Processamento de Dados

            inicio = ((W1 - 1) * 24 * 60 * 60) + (X1 * 60 * 60) + (Y1 * 60) + Z1;
            fim = ((W2 - 1) * 24 * 60 * 60) + (X2 * 60 * 60) + (Y2 * 60) + Z2;

            duracao = fim - inicio;

            W = duracao / (24 * 60 * 60);
            resto = duracao % (24 * 60 * 60);
            X = resto / (60 * 60);
            resto = resto % (60 * 60);
            Y = resto / 60;
            Z = resto % 60;

            // Saída de Dados

            Console.WriteLine(W + " dia(s)");
            Console.WriteLine(X + " hora(s)");
            Console.WriteLine(Y + " minuto(s)");
            Console.WriteLine(Z + " segundo(s)");

            }
        }
    }