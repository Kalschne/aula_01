using System;

namespace _18anos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Informe o Ano de Nascimento");
            Console.WriteLine("Informe a sua Idade");
            recebeAnoNascimento();


        }

        static void recebeAnoNascimento()
        {
            int idade = Convert.ToInt32(Console.ReadLine());
            //int anoAtual = DateTime.Now.Year;

            //string resposta = calculaIF(anoAtual, anoA);
            string resposta = calculaIF(idade);
            Console.WriteLine(resposta);
        }
        // static string calculaDiferenca( int anoAtual, int anoA)
        static string calculaIF(int idade)
        {

            string retorno = "";
            switch (idade)
            {
                  case 18:
                    retorno = "Válido";
                    break;
                case 19:
                    retorno = "Válido";
                    break;
                default:
                    retorno = "Inválido";
                    break;
            }
            return retorno;
            }
        }
    }

