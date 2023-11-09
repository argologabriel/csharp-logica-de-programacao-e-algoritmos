/// Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica, e informe-o expresso no formato horas:minutos:segundos.

using System;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            int horas, minutos, segundos, resto;

            // Entrada de Dados

            Console.WriteLine("Informe o tempo de duração do evento (em segundos): ");
            segundos = int.Parse(Console.ReadLine());

            // Processamento de Dados

            horas = segundos / 3600;
            resto = segundos % 3600;
            minutos = resto / 60;
            segundos = resto % 60;

            // Saída de Dados

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);

        }
    }
}
