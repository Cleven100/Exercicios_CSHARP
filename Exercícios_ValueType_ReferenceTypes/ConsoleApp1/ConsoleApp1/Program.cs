using System;
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

            int.TryParse(Console.ReadLine(), out int n);
            int soma = 0, a;
            a = n + 1;

            for (int i = 1; i <= n; i++)
            {
                if (i == n)
                {
                    break;
                }
                if (n % i == 0)
                {
                    soma += i;
                }


            }
            

            if (n == soma)
            {
                Console.WriteLine($"{n} eh perfeito");
                Console.ReadLine();
            }
            if (n != soma)
            {
                Console.WriteLine($"{n} nao eh perfeito");
                Console.ReadLine();
            }


        }
    }
}
