using System;

namespace passagensaereas
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] nomes = new string [5];
           string[] origens = new string [5];
           string[] destinos = new string [5];
           string[] datas = new string [5];
           int i = 0;
           string opcao;

            Console.WriteLine("Bem vindo a Qatar Airways");
            
            bool senhavalida;
            do{
                Console.WriteLine("Insira a senha de acesso:");
                string senhadig = Console.ReadLine();
                senhavalida = EfetuarLogin(senhadig);
            }while (!senhavalida);

            Console.WriteLine("Acesso liberado");

                do{
                    Console.WriteLine(" Selecione uma opção:");
                    Console.WriteLine(" 1 - cadastrar passagens");
                    Console.WriteLine(" 2 - listar passagens");
                    Console.WriteLine(" 0 - sair");
                    opcao = Console.ReadLine();

                    switch(opcao)
                    {
                        case "1":
                        Console.WriteLine("Cadastro de passagem");
                        CadastrarPassagem();
                        break;
                        case "2":
                        Console.WriteLine("Lista de passagens");
                        break;
                        case "0":
                        Console.WriteLine("Obrigado por utilizar a Qatar Airways");
                        break;
                        default:
                        Console.WriteLine("Seleciona uma opção inválida");
                        break;
                    }
                }while(opcao != "0");

            bool EfetuarLogin(string senha){
                if(senha == "123456"){
                    return true;
                }else{
                    Console.WriteLine("Senha inválida");
                    return false;
                }
            }
            void CadastrarPassagem(){
                string resposta = "";
                do{
                if(i<5){
                    Console.WriteLine($"Digite o nome do passageiro");
                    nomes[i] = Console.ReadLine();

                    Console.WriteLine($"Digite a origem");
                    origens[i] = Console.ReadLine();

                    Console.WriteLine($"Digite o destino");
                    destinos[i] = Console.ReadLine();

                    Console.WriteLine("Digite a data do embarque");
                    datas[i] = Console.ReadLine();

                    Console.WriteLine("Gostaria de cadastrar mais uma passagem ? sim ou nao?");
                    resposta = Console.ReadLine();
                    i++;
                }else{
                    Console.WriteLine("Limite excedido!");}
                    break;

            }   while(resposta == "sim");}
            }
        }
}