/* 
Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até que seja válido). O programa será encerrado quando o código informado for o número 4.
*/

using System;

namespace CursoNelioAlvesLPA {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite o código do combustível de sua preferência: ");
            int combustivel = int.Parse(Console.ReadLine());

            int alcool = 0, gasolina = 0, diesel = 0;

            while (combustivel != 4) {        
                if (combustivel == 1) {
                    alcool++;      
                }
                else if (combustivel == 2) {
                    gasolina++;
                }
                else if (combustivel == 3) {
                    diesel++;
                }
                else {
                    Console.WriteLine("Digite um código válido: ");
                }
                Console.WriteLine("Digite o código do combustível de sua preferência: ");
                combustivel = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);

        }
    }
}