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
                Console.WriteLine("[3] remover usuarios");
                Console.WriteLine("[4] entrar no menu veiculos");
                Console.WriteLine("[0] Sair do Programa");
                escolha = Console.ReadLine();
                switch (escolha)
                {
                    case "1":
                        Pessoa cadastroPessoas = cadastropessoas.CadastroDeUser();
                        listarUsuarios.Add(cadastroPessoas);
                        Console.Clear();
                        Console.WriteLine("usuario cadastrado com sucesso");
                        break;
                    case "2":
                        //listagem
                        cadastropessoas.ListarUsuarios(listarUsuarios);
                        break;
                    case "3":
                        Console.WriteLine("digite o nome da pessoa que voce deseja remover: ");
                        string nomedigitado = Console.ReadLine();
                        cadastropessoas.RemoverUsuario(nomedigitado, listarUsuarios);
                        Console.WriteLine($"OK, o usuario, {nomedigitado} foi removido com sucesso!");
                        break;
                    case "4":

                        Console.WriteLine("o usuario já é cadastrado ? sim ou não ?");
                        string resposta = Console.ReadLine();
                        if (resposta == "sim")
                        {
                            Console.WriteLine("digite o email:");
                            string digitarusuario = Console.ReadLine();
                            
                            Console.WriteLine("digite sua senha: ");
                            string senhacadastro = Console.ReadLine();

                            Pessoa pessoapesquisada = cadastropessoas.AnalisarEmail(digitarusuario, listarUsuarios);
                            Pessoa senha = cadastropessoas.AnalisarEmail(senhacadastro, listarUsuarios);

                            if (pessoapesquisada == null && senhacadastro == null)
                            {
                                Console.WriteLine("Usuário não cadastrado!");

                            }
                            else if (senhacadastro != pessoapesquisada.senha)
                            {
                                Console.WriteLine("senha inválida!");

                            }
                            Console.Clear();
                            Console.WriteLine("saja bem vindo ao cadastro de veiculo!");

                            do
                            {

                                Console.WriteLine("[1] - Cadastrar Veículo");
                                Console.WriteLine("[2] - Listar Veículos");
                                Console.WriteLine("[3] - buscar veiculo");
                                Console.WriteLine("[4] - remover Veículos");
                                Console.WriteLine("[0] - Voltar");
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
                                    case "3":
                                        Console.WriteLine("Digite o chassi do veículo");
                                        string chassiPesquisado = Console.ReadLine();
                                        Veiculo veiculoPesquisado = veiculoController.BuscarVeiculo(chassiPesquisado, listaDeVeiculos);
                                        if (veiculoPesquisado == null)
                                        {
                                            Console.WriteLine("Veículo não encontrado");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Veiculo retornado {veiculoPesquisado.Modelo}");
                                        }
                                        break;
                                    case "4":
                                        Console.WriteLine("digite  o chassi do veículo para remover");
                                        string chassiParaRemover = Console.ReadLine();
                                        veiculoController.RemoverVeiculo(chassiParaRemover, listaDeVeiculos);

                                        break;
                                    case "0":
                                        Console.WriteLine("Obrigado por utilizar nosso sistema");
                                        break;
                                    default:
                                        Console.WriteLine("Errou!");
                                        break;
                                }
                            } while (opcao != "0");
                            //fim do do while case 4
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("então cadastre um usuario para ter acesso ao menu!");

                        }

                        break;
                    case "0":
                        Console.WriteLine("obrigado por usar o programa");
                        break;

                    default:
                        Console.WriteLine("opção invalida");
                        break;


                }//fim switch



            } while (escolha != "0");



        }
    }
}

