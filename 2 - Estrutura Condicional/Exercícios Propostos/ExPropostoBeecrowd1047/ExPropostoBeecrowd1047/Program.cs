/*
Leia a hora inicial, minuto inicial, hora final e minuto final de um jogo. A seguir calcule a duração do jogo.

Obs: O jogo tem duração mínima de um (1) minuto e duração máxima de 24 horas.
*/

using System;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            int horaInicial, minutoInicial, horaFinal, minutoFinal;
            int instanteInicial, instanteFinal;
            int duracao, duracaoHoras, duracaoMinutos;

            // Entrada de Dados

            Console.WriteLine("Informe as horas e os minutos, iniciais e finais do jogo: ");
            string[] valores = Console.ReadLine().Split(' ');

            horaInicial = int.Parse(valores[0]);
            minutoInicial = int.Parse(valores[1]);
            horaFinal = int.Parse(valores[2]);
            minutoFinal = int.Parse(valores[3]);

            // Processamento de Dados

            instanteInicial = horaInicial * 60 + minutoInicial;
            instanteFinal = horaFinal * 60 + minutoFinal;
         
            if (instanteInicial < instanteFinal) {
                duracao = instanteFinal - instanteInicial;
            }
            else {
                duracao = (24 * 60 - instanteInicial) + instanteFinal;
            }

            duracaoHoras = duracao / 60;
            duracaoMinutos = duracao % 60;

            // Saída de Dados

            Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");
        }
    }
}