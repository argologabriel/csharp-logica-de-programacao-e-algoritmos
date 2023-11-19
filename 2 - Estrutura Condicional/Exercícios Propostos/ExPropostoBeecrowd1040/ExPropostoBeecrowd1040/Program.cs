/*
Leia quatro números (N1, N2, N3, N4), cada um deles com uma casa decimal, correspondente às quatro notas de um aluno. Calcule a média com pesos 2, 3, 4 e 1, respectivamente, para cada uma destas notas e mostre esta média acompanhada pela mensagem "Media: ". Se esta média for maior ou igual a 7.0, imprima a mensagem "Aluno aprovado.". Se a média calculada for inferior a 5.0, imprima a mensagem "Aluno reprovado.". Se a média calculada for um valor entre 5.0 e 6.9, inclusive estas, o programa deve imprimir a mensagem "Aluno em exame.".

No caso do aluno estar em exame, leia um valor correspondente à nota do exame obtida pelo aluno. Imprima então a mensagem "Nota do exame: " acompanhada pela nota digitada. Recalcule a média (some a pontuação do exame com a média anteriormente calculada e divida por 2). e imprima a mensagem "Aluno aprovado." (caso a média final seja 5.0 ou mais ) ou "Aluno reprovado.", (caso a média tenha ficado 4.9 ou menos). Para estes dois casos (aprovado ou reprovado após ter pego exame) apresente na última linha uma mensagem "Media final: " seguido da média final para esse aluno.
*/
    
using System;
using System.Globalization;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            float N1, N2, N3, N4, exame;
            float media;

            // Entrada de Dados

            Console.WriteLine("Informe suas notas: ");
            string[] notas = Console.ReadLine().Split(' ');

            N1 = float.Parse(notas[0], CultureInfo.InvariantCulture);
            N2 = float.Parse(notas[1], CultureInfo.InvariantCulture);
            N3 = float.Parse(notas[2], CultureInfo.InvariantCulture);
            N4 = float.Parse(notas[3], CultureInfo.InvariantCulture);

            // Processamento e Saída de Dados 

            media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10;

            if (media >= 7) {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media >= 5) {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno em exame.");

                Console.WriteLine("Informe sua nota do exame: ");
                exame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Nota do exame: " + exame.ToString("F1", CultureInfo.InvariantCulture));

                media = (media + exame) / 2;

                if (media >= 5) {
                    Console.WriteLine("Aluno aprovado.");
                }
                else {
                    Console.WriteLine("Aluno reprovado.");
                }

                Console.WriteLine("Media final: " + media.ToString("F1", CultureInfo.InvariantCulture));
            }
            else {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno reprovado.");
            }
        }
    }
}