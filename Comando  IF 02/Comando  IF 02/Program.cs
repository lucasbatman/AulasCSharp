using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comando__IF_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string valorpoupancaTexto;
            float valorpoupanca;

            Console.WriteLine("Digite o valor que você possui na sua conta: ");
            valorpoupancaTexto = Console.ReadLine();
            valorpoupanca = float.Parse(valorpoupancaTexto);
            if (valorpoupanca > 100000) {
                Console.WriteLine("Você é um cliente VIP, dessa maneira possui taxas especiais!");
            } else if (valorpoupanca > 50000){
                Console.WriteLine("Você é um cliente Especial, com taxa de juros de 0 ,2% a.a. ");
            } else{
                Console.WriteLine("Você é um cliente Especial, Mas as suas taxas são normais");
            }

            Console.ReadLine();
        }
    }
}
