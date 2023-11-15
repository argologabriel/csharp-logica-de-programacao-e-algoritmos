/*
Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
*/

using System;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            int inicio, fim;
            int duracao;

            // Entrada de Dados

            Console.WriteLine("Informe o horário de início e término do jogo: ");
            string[] valores = Console.ReadLine().Split(' ');

            inicio = int.Parse(valores[0]);
            fim = int.Parse(valores[1]);

            // Processamento de Dados

            if (fim > inicio) {
                duracao = fim - inicio;
            }
            else {
                duracao = (fim + 24) - inicio;
            }

            // Saída de Dados

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}
