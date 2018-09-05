using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            char sexo ;


            Console.WriteLine("=========================");
            Console.Write("Digite o sexo (M/F): ");
            sexo = char.Parse(Console.ReadLine());

            if (sexo == 'M')
            {
                Console.Write("Sexo Masculino");

            }
            else
            {
                Console.WriteLine("Sexo feminino");
            }

            Console.WriteLine("=========================");
            Console.ReadLine();




        }
    }
}
