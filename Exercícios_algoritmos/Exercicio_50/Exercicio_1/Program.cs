using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, anoAtual;
            double salario = 1000, porcentagem=0.015;
            WriteLine("Digite o ano atual: ");
            anoAtual = int.Parse(ReadLine());


            for (i = 1996; i < anoAtual; i++)
            {
                salario = 1000;
                if (anoAtual == 1995)
                {
                    salario = 1000;

                    break;
                }
                else if (anoAtual == 1996)
                {
                    salario = salario + (salario * (0.015));
                    break;

                }
                porcentagem *= 2;
                WriteLine(porcentagem);
                salario = salario + (salario * (porcentagem));




            }

            WriteLine("O novo salario é: {0}", salario);
            ReadKey();


        }
    }
}
