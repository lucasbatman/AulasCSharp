using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            double media, notaUm, notaDois, notaTres, notaQuatro;
            string nomeDoAluno, nomeDoPai, nomeDaMae;
            char sexoDoAluno;
            Console.WriteLine("Digite nome do aluno: ");
            nomeDoAluno = Console.ReadLine();

            Console.Write("Digite o sexo do Aluno: ");
            sexoDoAluno = char.Parse(Console.ReadLine());

            Console.WriteLine("Digite nome do pai: ");
            nomeDoPai = Console.ReadLine();

            Console.WriteLine("Digite nome da Mãe: ");
            nomeDaMae = Console.ReadLine();

            Console.Write("Digite a primeira nota: ");
            notaUm = double.Parse(Console.ReadLine());

            Console.Write("Digite a Segunda nota: ");
            notaDois = double.Parse(Console.ReadLine());

            Console.Write("Digite a Terceira nota: ");
            notaTres = double.Parse(Console.ReadLine());

            Console.Write("Digite a Quarta Nota: ");
            notaQuatro = double.Parse(Console.ReadLine());

           Console.Clear();


            media = (notaUm + notaDois + notaTres + notaQuatro) / 4;

            Console.Write("Escola XYZ - Resultados do Aluno");

            Console.WriteLine("O aluno" + nomeDoAluno);
            Console.WriteLine("O aluno teve média: " + media);
            Console.WriteLine(" ");
            Console.WriteLine("NOTAS DO ANO ");
            Console.WriteLine("Primeira nota: " + notaUm);
            Console.WriteLine("Segunda nota: " + notaDois);
            Console.WriteLine("Tereira nota: " + notaTres);
            Console.WriteLine("Quarta nota: " + notaQuatro);

            if (media >= 6)
            {
                Console.WriteLine("O aluno foi APROVADO!");
                Console.WriteLine(nomeDoPai+" e "+nomeDaMae + ",");
                Console.WriteLine("Parabéns pelo ótimo trabalho desenvolvido com o(a)," + nomeDoAluno)
            }
            else {
                Console.WriteLine("O aluno foi REPROVADO!");
                Console.WriteLine(nomeDoPai + " e " + nomeDaMae + ",");
                Console.WriteLine("Vocês tem que melhorar o trabalho de desenvolvimeto com o(a), " + nomeDoAluno + "Para que que ele(a) se recupere!");

            Console.ReadLine();













        }
    }
}
