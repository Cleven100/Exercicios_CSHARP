using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, horasTrabalhadas;
            string turnoTrabalho, categoriaTrabalho;
            double salarioFinal=0, salarioInicial=0, valor=0;



            for (int i = 1; i <= 3; i++)
            {


                WriteLine("\n");
                WriteLine("Digite o código do funcionário: ");
                codigo = int.Parse(ReadLine());
                WriteLine("Digite o número de horas trabalhadas: ");
                horasTrabalhadas = int.Parse(ReadLine());
                WriteLine("Digite o Turno de trabalho: ");
                turnoTrabalho = ReadLine();
                WriteLine("Digite a categoria de trabalho: ");
                categoriaTrabalho = ReadLine();




                if (turnoTrabalho == "N" || turnoTrabalho == "M" || turnoTrabalho == "V")
                {

                    if (categoriaTrabalho == "O" || categoriaTrabalho == "G")
                    {

                        if (categoriaTrabalho == "G")
                        {
                            if (turnoTrabalho == "M" || turnoTrabalho == "V")
                            {
                               valor  = (double)150 * 0.15;
                                salarioInicial = valor * horasTrabalhadas;

                                if (salarioInicial < 300)
                                {
                                    salarioFinal = salarioInicial + (salarioInicial * 0.2);



                                }
                                else if (salarioInicial >= 300 && salarioInicial < 600)
                                {

                                    salarioFinal = salarioInicial + (salarioInicial * 0.15);



                                }
                                else if (salarioInicial >= 600)
                                {
                                    salarioFinal = salarioInicial + (salarioInicial * 0.05);

                                }


                            }
                            else
                            {
                                valor = (double)150 * 0.18;
                                salarioInicial = valor * horasTrabalhadas;
                                if (salarioInicial < 300)
                                {
                                    salarioFinal = salarioInicial + (salarioInicial * 0.2);



                                }
                                else if (salarioInicial >= 300 && salarioInicial < 600)
                                {

                                    salarioFinal = salarioInicial + (salarioInicial * 0.15);



                                }
                                else if (salarioInicial >= 600)
                                {
                                    salarioFinal = salarioInicial + (salarioInicial * 0.05);

                                }

                                
                            }



                        }
                        else
                        {
                            if (turnoTrabalho == "M" || turnoTrabalho == "V")
                            {
                                valor = (double)150 * 0.10;
                                salarioInicial = (double)horasTrabalhadas * valor;
                                if (salarioInicial < 300)
                                {
                                    salarioFinal = salarioInicial + (salarioInicial * 0.2);



                                }
                                else if (salarioInicial >= 300 && salarioInicial < 600)
                                {

                                    salarioFinal = salarioInicial + (salarioInicial * 0.15);



                                }
                                else if (salarioInicial >= 600)
                                {
                                    salarioFinal = salarioInicial + (salarioInicial * 0.05);

                                }

                            }
                            else
                            {
                                valor = (double)150 * 0.13;
                                salarioInicial = (double)horasTrabalhadas * valor;
                                if (salarioInicial < 300)
                                {
                                    salarioFinal = salarioInicial + (salarioInicial * 0.2);



                                }
                                else if (salarioInicial >= 300 && salarioInicial < 600)
                                {

                                    salarioFinal = salarioInicial + (salarioInicial * 0.15);



                                }
                                else if (salarioInicial >= 600)
                                {
                                    salarioFinal = salarioInicial + (salarioInicial * 0.05);

                                }
                            }



                        }




                    }
                    else
                    {
                        WriteLine("Caracter de categoria minusculo, por favor digite um caracter Maiusculo ");
                    }



                }
                else
                {
                    WriteLine("Caracter de Turno minusculo, por favor digite um caracter Maiusculo ");
                }


                WriteLine($"O código: {codigo}");
                WriteLine($"Numero de horas trabalhadas: {horasTrabalhadas}");
                WriteLine($"Valor da hora trabalhada: {valor}");
                WriteLine($"Salario inicial = {salarioInicial}");
                WriteLine($"Salario Final = {salarioFinal}");
               



            }


        }





    }
    }

