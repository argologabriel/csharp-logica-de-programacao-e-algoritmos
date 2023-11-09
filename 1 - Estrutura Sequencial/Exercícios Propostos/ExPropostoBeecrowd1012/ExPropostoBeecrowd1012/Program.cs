/* 
 
Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre: 

    a) a área do triângulo retângulo que tem A por base e C por altura.
    b) a área do círculo de raio C. (pi = 3.14159)
    c) a área do trapézio que tem A e B por bases e C por altura.
    d) a área do quadrado que tem lado B.
    e) a área do retângulo que tem lados A e B. 

*/

using System;
using System.Globalization;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            double A, B, C;
            double triangulo, circulo, trapezio, quadrado, retangulo;

            // Entrada de Dados

            Console.WriteLine("Informe os valores de A, B e C: ");
            string[] valores = Console.ReadLine().Split(' ');

            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);   
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            // Processamento de Dados

            triangulo = (A * C) / 2.0;
            circulo = Math.Pow(C, 2.0) * 3.14159;
            trapezio = (A + B) / 2.0 * C;
            quadrado = Math.Pow(B, 2.0);
            retangulo = A * B;

            // Saída de Dados

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

            }
        }
    }