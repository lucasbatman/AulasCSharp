using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {  // Seção De Declarações Das Variáveis
            int a, b, y;

            Console.Write("Escreva o primeiro valor: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Escreva o segundo valor: ");
            b = int.Parse(Console.ReadLine());

            y = a;
            a = b;
            b = y;

            Console.WriteLine("O VALOR ALTERADO DE A É: " + a);
            Console.WriteLine("O VALOR ALTERADO DE B É: " + b);

            Console.ReadLine();
        }
    }
}
