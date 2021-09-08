using System;
using System.Threading;

namespace AtividadeRevisao
{
    class Program
    {
        static void Main(string[] args)
        {
            //criar uma calculadora que receba dois numeros e efetue as seguintes operações:
            //soma, sub, div, mult; 

            string opcao;
            do
            {

                Console.Clear();
                Console.WriteLine("bem vindo ao programa; Por favor escolha qual operação deseja fazer:");
                Console.WriteLine("1- soma");
                Console.WriteLine("2- subtração");
                Console.WriteLine("3- divisão");
                Console.WriteLine("4- multiplicação");
                Console.WriteLine("0- sair");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("bem vindo a soma;");
                        ReceberValores();
                        Soma();
                        break;
                    case "2":
                        Console.WriteLine("bem vindo a subtração;");
                        ReceberValores();
                        Subtracao();
                        break;
                    case "3":
                        Console.WriteLine("bem vindo a divisão;");
                        ReceberValores();
                        Divisao();
                        break;
                    case "4":
                        Console.WriteLine("bem vindo a multiplicação;");
                        ReceberValores();
                        Multiplicacao();
                        break;
                    case "0":
                        Console.WriteLine("retornando ao Menu!");
                        break;
                    default:
                        Console.WriteLine("opção invalida!");
                        break;
                }//fim switch
            } while (opcao != "0");
            //fim while

            int num1, num2;
            int total;

            void ReceberValores()
            {
                Console.WriteLine("digite o primeiro numero");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("digite o segundo numero");
                num2 = int.Parse(Console.ReadLine());
            }

            void Soma()
            {
                total = num1 + num2;
                Console.WriteLine($"a soma dos valores é de: {total}");
                Thread.Sleep(5000);
            }


            void Subtracao()
            {
                total = num1 - num2;
                Console.WriteLine($"a subtração dos valores é de: {total}");
                Thread.Sleep(5000);
            }

            void Divisao(double n1, double n2)
            {
                double total = n1 / n2;
                Console.WriteLine($"a divisao dos valores é de: {total}");
                Thread.Sleep(5000);

            }

            void Multiplicacao()
            {
                total = num1 * num2;
                Console.WriteLine($"a multiplicação dos valores é de: {total}");
                Thread.Sleep(5000);
            }


        }//fim da main
    }
}
