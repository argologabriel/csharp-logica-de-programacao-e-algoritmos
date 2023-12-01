/*
Leia 5 valores Inteiros. A seguir mostre quantos valores digitados foram pares, quantos valores digitados foram ímpares, quantos valores digitados foram positivos e quantos valores digitados foram negativos.
*/

using System;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            int num, pares, impares, positivos, negativos;

            pares = 0;
            impares = 0;
            positivos = 0;
            negativos = 0;

            Console.WriteLine("Digite cinco valores inteiros quaisquer: ");

            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) {
                pares++;
            }
            else {
                impares++;
            }
            if (num > 0) {
                positivos++;
            }
            else if (num < 0) {
                negativos++;
            }

            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) {
                pares++;
            }
            else {
                impares++;
            }
            if (num > 0) {
                positivos++;
            }
            else if (num < 0) {
                negativos++;
            }

            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) {
                pares++;
            }
            else {
                impares++;
            }
            if (num > 0) {
                positivos++;
            }
            else if (num < 0) {
                negativos++;
            }

            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) {
                pares++;
            }
            else {
                impares++;
            }
            if (num > 0) {
                positivos++;
            }
            else if (num < 0) {
                negativos++;
            }

            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) {
                pares++;
            }
            else {
                impares++;
            }
            if (num > 0) {
                positivos++;
            }
            else if (num < 0) {
                negativos++;
            }

            Console.WriteLine(pares + " valor(es) par(es)");
            Console.WriteLine(impares + " valor(es) impar(es)");
            Console.WriteLine(positivos + " valor(es) positivo(s)");
            Console.WriteLine(negativos + " valor(es) negativo(s)");
        }
    }
}