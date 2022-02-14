using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {


            int carro, numeroAcidente, codigoCidade, contador = 0, maiorNumeroAcidente = 0, menorNumeroAcidente = 99999999, codigoMaiorCidade=0, codigoMenorCidade=0, contadorCidadeCarros = 0, contadorCidade=0; 
            double mediaVeiculosCidades=0,cidadeMediaDoisMil=0;

            for (int i = 1; i <= 3; i++)
            {
                WriteLine("Digite o código da cidade:  ");
                codigoCidade = int.Parse(ReadLine());
                WriteLine("Digite a quantidade de carros de passeio: ");
                carro = int.Parse(ReadLine());
                WriteLine("Digite o número de acidentes na cidade: ");
                numeroAcidente = int.Parse(ReadLine());

                WriteLine("\n\n");
                contador += carro;

                if (numeroAcidente > maiorNumeroAcidente)
                {

                    maiorNumeroAcidente = numeroAcidente;
                    codigoMaiorCidade = codigoCidade;

                }
                if (numeroAcidente < menorNumeroAcidente)
                {

                    menorNumeroAcidente = numeroAcidente;
                    codigoMenorCidade = codigoCidade;


                }
                if(carro < 2000)
                {
                    contadorCidadeCarros += numeroAcidente;
                    contadorCidade++;
                }

                mediaVeiculosCidades =(double) contador / 3;
                cidadeMediaDoisMil = (double)contadorCidadeCarros / contadorCidade;

            }

            WriteLine($"O maior indice de acidentes é: {maiorNumeroAcidente} e pertence a cidade {codigoMaiorCidade}");
            WriteLine($"O menor indice de acidentes é: {menorNumeroAcidente} e pertence a cidade: {codigoMenorCidade}");
            WriteLine($"a media dos veiculos das 5 cidades é: {mediaVeiculosCidades}");
            WriteLine($"a media dos acidentes das cidades com menos de 2000 carros é: {cidadeMediaDoisMil}");
            ReadLine();



        }
    }
}
