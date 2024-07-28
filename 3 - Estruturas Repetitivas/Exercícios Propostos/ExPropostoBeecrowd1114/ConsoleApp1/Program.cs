﻿// Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002. //

using System;

namespace CursoNelioAlvesLPA
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada de dados

            Console.WriteLine("Digite a senha: ");
            int senha = int.Parse(Console.ReadLine());

            // Processamento e saída de dados

            while (senha != 2002) {
                Console.WriteLine("Senha Invalida");
                Console.WriteLine("Digite a senha novamente: ");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso permitido");
        }
    }
}