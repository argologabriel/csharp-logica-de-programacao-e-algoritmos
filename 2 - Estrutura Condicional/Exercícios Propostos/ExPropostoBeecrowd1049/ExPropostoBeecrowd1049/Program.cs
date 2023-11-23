/*
Neste problema, você deverá ler 3 palavras que definem o tipo de animal possível segundo o esquema abaixo, da esquerda para a direita.  Em seguida conclua qual dos animais seguintes foi escolhido, através das três palavras fornecidas.
*/

using System;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            string palavra1, palavra2, palavra3;

            // Entrada de Dados

            Console.WriteLine("Defina o tipo do animal: ");
            palavra1 = Console.ReadLine();
            palavra2 = Console.ReadLine();
            palavra3 = Console.ReadLine();

            // Processamento e Saída de Dados

            if (palavra1 == "vertebrado") {
                if (palavra2 == "ave") {
                    if (palavra3 == "carnivoro") {
                        Console.WriteLine("aguia");
                    }
                    else {
                        Console.WriteLine("pomba");
                    }
                }
                else {
                    if (palavra3 == "onivoro") {
                        Console.WriteLine("homem");
                    }
                    else {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else {
                if (palavra2 == "inseto") {
                    if (palavra3 == "hematofago") {
                        Console.WriteLine("pulga");
                    }
                    else {
                        Console.WriteLine("lagarta");
                    }
                }
                else {
                    if (palavra3 == "hematofago") {
                        Console.WriteLine("sanguessuga");
                    }
                    else {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}