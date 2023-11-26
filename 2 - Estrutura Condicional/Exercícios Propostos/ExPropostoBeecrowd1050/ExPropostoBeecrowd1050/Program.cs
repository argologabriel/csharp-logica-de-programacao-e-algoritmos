/*
Leia um número inteiro que representa um código de DDD para discagem interurbana. Em seguida, informe à qual cidade o DDD pertence, considerando a tabela abaixo:

        DDD     Destination
    
        61      Brasilia
        71      Salvador
        11      Sao Paulo
        21      Rio de Janeiro
        32      Juiz de Fora
        19      Campinas
        27      Vitoria
        31      Belo Horizonte
*/

using System;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            int ddd;

            // Entrada de Dados

            Console.WriteLine("Digite o DDD: ");
            ddd = int.Parse(Console.ReadLine());

            // Processamento e Saída de Dados

            if (ddd == 61) {
                Console.WriteLine("Brasilia");
            }
            else if (ddd == 71) {
                Console.WriteLine("Salvador");
            }
            else if (ddd == 11) {
                Console.WriteLine("Sao Paulo");
            }
            else if (ddd == 21) {
                Console.WriteLine("Rio de Janeiro");
            }
            else if (ddd == 32) {
                Console.WriteLine("Juiz de Fora");
            }
            else if (ddd == 19) {
                Console.WriteLine("Campinas");
            }
            else if (ddd == 27) {
                Console.WriteLine("Vitoria");
            }
            else if (ddd == 31) {
                Console.WriteLine("Belo Horizonte");
            }
            else {
                Console.WriteLine("DDD nao cadastrado");
            }
        }
    }
}