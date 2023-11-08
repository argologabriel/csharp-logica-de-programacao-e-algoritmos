/// Dois carros (X e Y) partem em uma mesma direção. O carro X sai com velocidade constante de 60 Km/h e o carro Y sai com velocidade constante de 90 Km/h. ///

/// Em uma hora (60 minutos) o carro Y consegue se distanciar 30 quilômetros do carro X, ou seja, consegue se afastar um quilômetro a cada 2 minutos. ///

/// Leia a distância (em Km) e calcule quanto tempo leva (em minutos) para o carro Y tomar essa distância do outro carro. ///

using System;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            // Declaração de Variáveis

            int distancia;
            int tempo;

            // Entrada de Dados

            Console.WriteLine("Informe a distância (em Km) entre os carros: ");
            distancia = int.Parse(Console.ReadLine());

            // Processamento de Dados

            tempo = (distancia * 2);

            // Saída de Dados

            Console.WriteLine(tempo + " minutos");

            }
        }
    }

