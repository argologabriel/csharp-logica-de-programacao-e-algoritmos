/* 
Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles, mostrando 4 casas decimais após a vírgula, segundo a fórmula:
 
Distancia = Raiz de ((x2 - x1)^2 + (y2 - y1)^2)
 */

using System;
using System.Globalization;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis 

            double x1, y1, x2, y2;
            double distancia;

            // Entrada de Dados

            Console.WriteLine("Digite os valores de X e Y no primeiro ponto no plano: ");
            string[] ponto1 = Console.ReadLine().Split(' ');

            x1 = double.Parse(ponto1[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(ponto1[1], CultureInfo.InvariantCulture);

            Console.WriteLine("Digite os valores de X e Y no segundo ponto no plano: ");
            string[] ponto2 = Console.ReadLine().Split(' ');

            x2 = double.Parse(ponto2[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(ponto2[1], CultureInfo.InvariantCulture);

            // Processamento de Dados

            distancia = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

            // Saída de Dados

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
                
        }
    }
}
