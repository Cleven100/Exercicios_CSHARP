using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiro=0, segundo=1, resultado=0;

            Console.WriteLine("0");
            Console.WriteLine("1");
            for (int i = 3; i <= 8; i++)
            {

                resultado = primeiro + segundo;

                primeiro = segundo;
                segundo = resultado;
                Console.WriteLine(resultado);
            }
            Console.ReadLine();
        }
    }
}
