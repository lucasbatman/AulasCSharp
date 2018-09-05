using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            //DECLARANDO AS VÁRIAVEIS
            string x;
            int y;
            double z;
            char w;

            // RECEBENDO OS VALORES QUE DEVEM SER DIGITADAS PELO USUÁRIO
            // TRABALHANDO COM A VÁRIAVEL X - STRING
     
            Console.Write("Digite um texto aqui: ");
            x = Console.ReadLine();


            // TRABALHANDO COM A VARIÁVEL Y - INTEIRO
            // O MÉETODO INT.PARSE( É USADO PARA CONVERTER
            // UMA REPRESENTAÇÃO DE STRING DE NÚMERO EM UM INTEIRO
            Console.Write("Digite um número: ");
            y = int.Parse (Console.ReadLine());

            // TRABALHANDO COM A VARIÁVEL Z - DOUBLE
            Console.Write("Digite o valor do cheque - R$ ");
            z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            // TRABALHANDO COM A VARIÁVEL W - CHAR
            Console.Write ("DIGITE O SEXO(M/f): ");
            w = Char.Parse(Console.ReadLine());

            // APRESENTANDO OS VALORES DIGITADOS
            Console.WriteLine();
            Console.WriteLine("RESULTADO");
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(w);


            Console.ReadLine();
        }
    }
}
