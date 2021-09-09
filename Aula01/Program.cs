using System;
using System.Threading;

namespace Aula01
{
    class Program
    {
        public static object Trhead { get; private set; }

        static void Main(string[] args)
        {
            string opcao, defesa, ataque;
            int contador01 = 0;
            int contador02 = 0;
            int contadorRound= 1;

            Personagem persona1 = new Personagem();

            persona1.nome = "Morcegão";
            persona1.idade = 46;
            persona1.armadura = "Bat Roupa";
            persona1.iA = "Alfred";
            persona1.soco = 30;
            persona1.chute = 25;

            Personagem persona2 = new Personagem();
            persona2.nome = "Wonder Woman";
            persona2.idade = 100;
            persona2.armadura = "Master Titanium";
            persona2.iA = "Amazon Prime";
            persona2.soco = 30;
            persona2.chute = 25;


            Console.WriteLine($"{persona1.nome} VS {persona2.nome}");

            do
            {
                Console.WriteLine($"ROUND {contadorRound}, prepare-se!");
                Console.WriteLine("selecione o seu personagem...");
                
                if (contador01 == contador02)
                {
                    Console.WriteLine($"1- {persona1.nome} vida = {persona1.ExibirVida()} - quantidades jogadas = {contador01}");
                    Console.WriteLine($"2- {persona2.nome} vida = {persona2.ExibirVida()} - quantidades jogadas = {contador02}");
                }
                else if (contador01 < contador02)
                {
                    Console.WriteLine($"1- {persona1.nome} vida = {persona1.ExibirVida()} - quantidades jogadas = {contador01}");
                }
                else
                {
                    Console.WriteLine($"2- {persona2.nome} vida = {persona2.ExibirVida()} - quantidades jogadas = {contador02}");
                }
                Console.WriteLine("0- Desistir");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        //atacar personagem 2
                        Console.WriteLine("selecione o ataque:");
                        Console.WriteLine("1- Soco");
                        Console.WriteLine("2- Chute");

                        ataque = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"Personagem {persona2.nome}, qual será sua defesa ? 1, 2 ou 3 ?");
                        Console.WriteLine("1- defesa de soco;");
                        Console.WriteLine("2- defesa de chute;");

                        defesa = Console.ReadLine();

                        if (ataque == defesa)
                        {
                            Console.WriteLine($"o {persona2.nome} defendeu! ERRROUUUUU");
                        }
                        else
                        {
                            if (ataque == "1")
                            {
                                Console.WriteLine($"o {persona2.nome} recebeu um dano de {persona1.soco}");
                                persona2.ReceberAtaque(persona1.soco);

                            }
                            else
                            {
                                Console.WriteLine($"o {persona2.nome} recebeu um dano de {persona1.chute}");
                                persona2.ReceberAtaque(persona1.chute);
                            }

                            if (persona2.ExibirVida() > 0)
                            {
                                Console.WriteLine($"a vida restante do {persona2.nome} é de: {persona2.ExibirVida()}");

                            }
                            else
                            {
                                Console.WriteLine("K.O!!");
                            }
                            Thread.Sleep(3000);

                        }//fim if

                        contador01++;
                        break;
                    case "2":
                        //atacar personagem 1
                        Console.WriteLine("selecione o ataque:");
                        Console.WriteLine("1- Soco ");
                        Console.WriteLine("2- Chute");

                        ataque = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"Personagem {persona1.nome}, qual será sua defesa ? 1, 2 ou 3 ?");
                        Console.WriteLine("1- defesa de soco;");
                        Console.WriteLine("2- defesa de chute;");

                        defesa = Console.ReadLine();

                        if (ataque == defesa)
                        {
                            Console.WriteLine($" o {persona1.nome} defendeu! ERRROUUUUU");
                        }
                        else
                        {
                            if (ataque == "1")
                            {
                                Console.WriteLine($"o {persona2.nome} recebeu um dano de {persona1.soco}");
                                persona1.ReceberAtaque(persona2.soco);

                            }
                            else
                            {
                                Console.WriteLine($"o {persona1.nome} recebeu um dano de {persona2.chute}");
                                persona1.ReceberAtaque(persona2.chute);
                            }
                            if (persona1.ExibirVida() > 0)
                            {
                                Console.WriteLine($"a vida restante do {persona1.nome} é de: {persona1.ExibirVida()}");

                            }
                            else
                            {
                                Console.WriteLine("K.O!!");
                            }

                            Thread.Sleep(3000);
                        }//fim if
                        contador02++;
                        break;
                    case "0":
                        Console.WriteLine("ARREGOUUUU!!");
                        Thread.Sleep(2000);
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }//fim switch case

                if (persona1.ExibirVida() <= 0)
                {
                    Console.WriteLine($" vitória do jogador {persona2.nome}");
                    break;
                }
                else if (persona2.ExibirVida() <= 0)
                {
                    Console.WriteLine($"vitória do jogador {persona1.nome}");
                    break;
                }
                else if (opcao != "0")
                {
                    Console.WriteLine("Prepare-se para o próximo ROUND!!");
                    Thread.Sleep(3000);
                }
                Console.Clear();

                contadorRound++;
            } while (opcao != "0");

        }//fim main
    }
}