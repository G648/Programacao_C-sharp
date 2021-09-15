using System;
using Pasta_aula_15_5_2.Controller;

namespace Pasta_aula_15_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //vamos criar um menu de opções

            string opcao;
            do
            {
                Console.WriteLine("[1] cadastrar veiculo");
                Console.WriteLine("[2] listar veiculo");
                Console.WriteLine("[0] sair");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        //cadastrar veiculo 
                        VeiculoController veiculoController = new VeiculoController();
                        veiculoController.CadastrarVeiculo();

                        break;
                    case "2":
                        //listar veiculo
                        break;
                    case "0":
                        //sair
                        Console.WriteLine("Obrigado por utilizar nosso sistema");
                        break;
                    default:
                        Console.WriteLine("ERROUUUU");
                        break;
                }


            } while (opcao != "0");
        }
    }
}
