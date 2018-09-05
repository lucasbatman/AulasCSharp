using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atribuicao
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine(10 == 1);

            Console.WriteLine(11 == 10);

            if (10 == 10)
            {
                Console.WriteLine("10 é igulal a 10");
            }
            if (10 == 1)
            {
                Console.WriteLine("10 é igulal a 10");

            }
            else
            {
                Console.WriteLine("os números não são iguais");
                
            }

            Console.WriteLine(10 > 9);
            Console.WriteLine(10 < 9);

            Console.WriteLine(10 >= 9);
            Console.WriteLine(10 <= 9);

            Console.WriteLine(10 != 10);
            



            Console.ReadLine();
        }
    }
}
