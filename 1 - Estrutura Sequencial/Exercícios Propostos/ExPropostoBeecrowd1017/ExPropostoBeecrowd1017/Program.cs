/// Joaozinho quer calcular e mostrar a quantidade de litros de combustível gastos em uma viagem, ao utilizar um automóvel que faz 12 KM/L. Para isso, ele gostaria que você o auxiliasse através de um simples programa. Para efetuar o cálculo, deve-se fornecer o tempo gasto na viagem (em horas) e a velocidade média durante a mesma (em km/h). Assim, pode-se obter distância percorrida e, em seguida, calcular quantos litros seriam necessários. Mostre o valor com 3 casas decimais após o ponto. ///

using System;
using System.Globalization;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            int tempoGasto, velocidadeMedia;
            int distanciaPercorrida;
            double litrosNecessarios;

            // Entrada de Dados

            Console.WriteLine("Informe o tempo gasto (em horas) na viagem: ");
            tempoGasto = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a velocidade média (em km/h) durante a viagem: ");
            velocidadeMedia = int.Parse(Console.ReadLine());

            // Processamento de Dados

            distanciaPercorrida = (velocidadeMedia * tempoGasto);

            litrosNecessarios = (distanciaPercorrida / 12.0);

            // Saída de Dados

            Console.WriteLine(litrosNecessarios.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}



