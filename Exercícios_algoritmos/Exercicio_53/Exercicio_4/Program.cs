using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b;

            for (int i = 1; i <= 3; i++)
            {

                WriteLine("Digite o valor de a: ");
                a = int.Parse(ReadLine());
                WriteLine("Digite o valor de b: ");
                b = int.Parse(ReadLine());

                for (int j = a; j <= b; j++)
                {

                    if (j % 2 == 0)
                    {
                        WriteLine(j);
                    }



                }




            }
            ReadLine();
        }
    }
}
