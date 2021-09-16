using System;
using System.Collections.Generic;
using TsukaMotors.Controllers;
using TsukaMotors.Models;

namespace TsukaMotors
{
    class Program
    {
        static void Main(string[] args)
        {

            //vamos criar um menu de opções
            VeiculoController veiculoController = new VeiculoController();
            CadastroControllers cadastropessoas = new CadastroControllers();
            List<Pessoa> listarUsuarios = new List<Pessoa>();
            List<Veiculo> listaDeVeiculos = new List<Veiculo>();

            string escolha; //usuario
            string opcao;
            do
            {
                Console.WriteLine("[1] Cadastro de Usuario");
                Console.WriteLine("[2] listar usuarios");
                Console.WriteLine("[0] Sair do Programa");
                escolha = Console.ReadLine();
                switch (escolha)
                {
                    case "1":
                        Pessoa cadastroPessoas = cadastropessoas.CadastroDeUser();
                        listarUsuarios.Add(cadastroPessoas);
                        Console.Clear();
                        if (escolha == "1")
                        {
                            Console.WriteLine("usuario cadastrado com sucesso");
                            do
                            {

                                Console.WriteLine("[1] - Cadastrar Veículo");
                                Console.WriteLine("[2] - Listar Veículos");
                                Console.WriteLine("[0] - Sair");
                                opcao = Console.ReadLine();
                                switch (opcao)
                                {
                                    case "1":
                                        // Aqui iremos cadastrar um veículo

                                        Veiculo veiculoRetornado = veiculoController.CadastrarVeiculo();
                                        listaDeVeiculos.Add(veiculoRetornado);
                                        break;
                                    case "2":
                                        // Aqui vamos listar os veículos cadastrados
                                        //Aqui temos que acessar a lista de veículos e exibir cada item da lista
                                        veiculoController.ListarVeiculos(listaDeVeiculos); //Aqui eu passo para o método a lista
                                        break;
                                    case "0":
                                        Console.WriteLine("Obrigado por utilizar nosso sistema");
                                        break;
                                    default:
                                        Console.WriteLine("Errou!");
                                        break;
                                }
                            } while (opcao != "0");
                        }
                        break;
                    case "2":
                        //listagem
                        cadastropessoas.ListarUsuarios(listarUsuarios);
                        break;
                    case "0":
                        Console.WriteLine("obrigado por usar o programa");
                        break;
                    default:
                        Console.WriteLine("opção invalida");
                        break;
                }

            } while (escolha != "0");          


        }
    }
}
