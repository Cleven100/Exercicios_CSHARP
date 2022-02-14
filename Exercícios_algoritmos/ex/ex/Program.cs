using System;
using static System.Console;

namespace Exception
{

    class Program
    {

        static void Main(string[] agrs)
        {
            int a, b, c ;
            double x1, x2, delta, valor_de_delta;

            WriteLine("Digite o valor a: ");
            a = int.Parse(ReadLine());
            WriteLine("Digite o valor b: ");
            b = int.Parse(ReadLine());
            WriteLine("Digite o valor c: ");
            c = int.Parse(ReadLine());


            delta = ((b * b) - (4 * a * c));
            
           

           
           

            if (delta > 0)
            {
                WriteLine("----------");
                WriteLine(delta);
                WriteLine(((-1) * (b)));
                WriteLine(Math.Sqrt(delta));
                WriteLine("----------");

                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                WriteLine(x1);
                WriteLine(x2);
                ReadKey();

            }
            else if (delta == 0)
            {
                WriteLine("não existe valores de x1 e x2");
                ReadKey();
            }
         
        }

    }

}



