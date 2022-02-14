using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {

            double n, i, j, e, fatorial;

            WriteLine("Digite o valor de N: ");
            n = double.Parse(ReadLine());

            e = 1;
            for(i=1;i<=n;i++)
            {
                fatorial = 1;
                for (j = 1; j <= i; j++)
                {
                    fatorial *= j;
                    e += (1 / fatorial);

                }
            }

            WriteLine($"O valor de E = {e}");
            ReadLine();



        }
    }
}
