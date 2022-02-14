using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroAluno, alturaAluno, maiorAluno = 0, menorAluno = 10, numeroMaiorAluno = 0, numeroMenorAluno = 0;


            for (int i = 1; i <= 10; i++)
            {

                WriteLine("Digite o número do aluno: ");
                numeroAluno = double.Parse(ReadLine());
                WriteLine("Digite a Altura do aluno: ");
                alturaAluno = double.Parse(ReadLine());

                WriteLine("\n\n");

                if (alturaAluno > maiorAluno)
                {
                    maiorAluno = alturaAluno;
                    numeroMaiorAluno = numeroAluno;

                }
                if (alturaAluno < menorAluno)

                {

                    menorAluno = alturaAluno;
                    numeroMenorAluno = numeroAluno;

                }


            }



            WriteLine($"o maior aluno é: {numeroMaiorAluno} sua altura é: {maiorAluno}");
            WriteLine($"O menor aluno é: {numeroMenorAluno} e sua altura é: {menorAluno}");
            ReadLine();
     
        }

        

    }
}
