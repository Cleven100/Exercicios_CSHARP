using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {

            int numeroTermos, x, expoente, denominador, fim, den=0;
            double solucao, fat, d;

            WriteLine("Digite o número de termos: ");
            numeroTermos = int.Parse(ReadLine());
            WriteLine("Digite o valor de X: ");
            x = int.Parse(ReadLine());
            solucao = 0;
            denominador = 1;


            for (int i = 1; i <= numeroTermos; i++)
            {
                fat = 1;
                fim = denominador;
                for (int j = 1; j <= fim; j++)
                {
                    fat = fat * j;
                }
                expoente = i + 1;
                if ((expoente % 2) == 0)
                {
                    solucao = solucao - ((double)Math.Pow(x, expoente) / fat);
                } else{


                    solucao = solucao + ((double)Math.Pow(x, expoente) / fat);
                }
                if (denominador == 4)
                {
                    den = -1;
                }
                if (denominador == 1)
                {
                    den = 1;
                }
                if(den == 1)
                {
                    denominador += 1;
                }
                else
                {
                    denominador -= 1;
                }









            }

            d = solucao;
            WriteLine($"O valor de {d}");
            ReadLine();





        }
    }
}
