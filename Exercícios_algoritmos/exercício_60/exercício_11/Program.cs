using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1, numeroTermos, numero1 = 2, numero2 = 7, numero3 = 3;

            WriteLine("Digite o número de termos da sequência: ");
            numeroTermos = int.Parse(ReadLine());

            if (i <= numeroTermos)
            {
                WriteLine(numero1);
                i++;
                if (i <= numeroTermos)
                {
                    WriteLine(numero2);
                    i++;
                    if(i <= numeroTermos)
                    {
                        WriteLine(numero3);
                            i++;
                        
                    }
                }
            }
            while( i <= numeroTermos)
            {
                numero1 *= 2;
                WriteLine(numero1);
                i++;
                if( i<= numeroTermos)
                {
                    numero2 *= 3;
                    WriteLine(numero2);
                    if(i<= numeroTermos)
                    {
                        numero3 *= 4;
                        WriteLine(numero3);
                    }
                }
            }
            ReadLine();
        }
    }
}
