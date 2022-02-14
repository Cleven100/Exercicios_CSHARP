using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, fatorial, i, j, numero;
           
            
            WriteLine("Digite a quantidade de fatoriais: ");
            n = double.Parse(ReadLine());
           


            for ( i = 1; i <= n; i++)
            {
               


                WriteLine("Digite o valor do fatorial: \n");

                numero = double.Parse(ReadLine());
                fatorial = numero;

                for(j = numero - 1; j>=1; j--)
                {
                    fatorial = fatorial * j;
                    


                }
                WriteLine(fatorial);




            }

            ReadLine();



        }
    }
}
