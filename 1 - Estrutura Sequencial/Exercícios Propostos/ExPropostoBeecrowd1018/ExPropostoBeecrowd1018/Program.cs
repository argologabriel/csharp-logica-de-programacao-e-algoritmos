/*
Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. A seguir mostre o valor lido e a relação de notas necessárias.
 */

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            int N;
            int quociente, resto, nota;

            // Entrada de Dados

            Console.WriteLine("Informe o valor de N: ");
            N = int.Parse(Console.ReadLine());

            // Processamento e Saída de Dados

            resto = N;

            nota = 100;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 50;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 20;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 10;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 5;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 2;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 1;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");

        }
    }
}

