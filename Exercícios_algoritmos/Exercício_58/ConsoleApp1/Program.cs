using System;
using  static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int pontuacaoFinal = 0, valor = 0, codigo =0, codigoFinal = 0;
            for (int i = 0; i <= 10; i++)
            {
                int pontuacao = 0;
                WriteLine("Digite o código do funcionário: ");
                codigo = int.Parse(ReadLine());
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                    {
                        WriteLine("Digite a pontuação do funcionário de novembro: ");
                        valor = int.Parse(ReadLine());
                        pontuacao += valor;
                    }
                    else if (j == 1)
                    {
                        WriteLine("Digite a pontuação do funcionário de dezembro: ");
                        valor = int.Parse(ReadLine());
                        pontuacao += valor;
                    }
                    else

                    {
                        WriteLine("Digite a pontuação do funcionário de janeiro: ");
                        valor = int.Parse(ReadLine());
                        pontuacao += valor;
                    }
                    if (pontuacao > pontuacaoFinal)
                    {
                        pontuacaoFinal = pontuacao;
                        codigoFinal = codigo;
                    }

                }
                WriteLine($"O código do funcionário é: {codigo}");
                WriteLine($"A pontuação do funcionario foi {pontuacao}");
                WriteLine($"A média da pontuação do funcionario foi {pontuacao / 3}");

                WriteLine("\n");
            }
            WriteLine($"A maior pontuação foi do funcionario {codigoFinal} e a pontuação foi: {pontuacaoFinal}");
            ReadLine();
        }
    }

}