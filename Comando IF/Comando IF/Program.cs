using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comando_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 7;

            if (num >= 7) {
                Console.WriteLine("O número é maior que 7");

                          }else if(num < 7) {
                Console.WriteLine("O número é maior que 7");
            }
            else {
                Console.WriteLine("O número é menor que 7");
            }

            Console.ReadLine();
        }
    }
}
