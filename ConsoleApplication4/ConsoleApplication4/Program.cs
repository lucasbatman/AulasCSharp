using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota01, nota02, nota03, nota04, media;

            Console.Write("Digite a Primeira nota: ");
            nota01 = double.Parse(Console.ReadLine());

            Console.Write("Digite a Segunda nota: ");
            nota02 = double.Parse(Console.ReadLine());

            Console.Write("Digite a Terceira nota: ");
            nota03 = double.Parse(Console.ReadLine());

            Console.Write("Digite a Quarta nota: ");
            nota04 = double.Parse(Console.ReadLine());

            media = (nota01 + nota02 + nota03 + nota04) / 4;

            Console.Write(" A média do aluno foi de: " + media);

            Console.ReadLine();






        }
    }
}
