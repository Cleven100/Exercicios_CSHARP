using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int fat, x, numero;
            double s = 1;

            WriteLine("Digite o valor de x: ");
            x = int.Parse(ReadLine());
            WriteLine("Digite o numero de termos da sequência: ");
            numero = int.Parse(ReadLine());

            for(int i=1; i<=numero; i++)
            {
                fat = 1;
                for (int j = 1; j <= i + 2; j++)
                {
                    fat *= j;
                }
                if ((i + 1) % 2 == 0)
                {
                    s += (Math.Pow(x, i) / fat);
                }
                else
                {
                    s -= (Math.Pow(x, i) / fat);
                }
                WriteLine($"O valor de S = {s}");
                ReadLine();
            }

        }
    }
}
