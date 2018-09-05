using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int formula, contador, numero;

            Console.Write("Digite o número para obter a tabuada: ");
            numero = int.Parse(Console.ReadLine());

            for (contador = 1; contador <= 10; ++contador)
            {
                formula = numero * contador;
                Console.WriteLine(numero + " x " + contador + "= " + formula);
            }

            Console.ReadLine();  










        }
    }
}
