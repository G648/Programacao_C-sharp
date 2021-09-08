using System;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao, defesa, ataque;

            Personagem persona1 = new Personagem();

            persona1.nome = "Morcegão";
            persona1.idade = 46;
            persona1.armadura = "Bat Roupa";
            persona1.iA = "Alfred";

            Personagem persona2 = new Personagem();
            persona2.nome = "Wonder Woman";
            persona2.idade = 100;
            persona2.armadura = "Master Titanium";
            persona2.iA = "Amazon Prime";

            Console.WriteLine($"{persona1.nome} VS {persona2.nome}");
            
            do
            {

                Console.WriteLine("selecione o seu personagem...");
                Console.WriteLine($"1- {persona1.nome} vida = {persona1.ExibirVida()}");
                Console.WriteLine($"2- {persona2.nome} vida = {persona2.ExibirVida()}");
                Console.WriteLine("0- Desistir");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        //atacar personagem 2
                        Console.WriteLine("selecione o ataque:");
                        Console.WriteLine("1- Soco Alto");
                        Console.WriteLine("2- Soco Medio");
                        //Console.WriteLine("3- Chute Baixo");
                        ataque = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"Personagem {persona2.nome}, qual será sua defesa ? 1, 2 ou 3 ?");
                        Console.WriteLine("1- defesa de soco alto;");
                        Console.WriteLine("2- defesa de soco medio;");
                        //Console.WriteLine("3- defesa de chute baixo");
                        defesa = Console.ReadLine();

                        if (ataque == defesa)
                        {
                            Console.WriteLine($" o {persona2.nome} defendeu! ERRROUUUUU");
                        }
                        else
                        {
                            Console.WriteLine($"o {persona2.nome} recebeu um dano de 25");
                            persona2.Defender(25);
                            Console.WriteLine($"a vida restante do {persona2.nome} é de: {persona2.ExibirVida()}");
                        }
                        break;
                    case "2":
                        //atacar personagem 1
                        Console.WriteLine("selecione o ataque:");
                        Console.WriteLine("1- Soco Alto");
                        Console.WriteLine("2- Soco Medio");
                        //Console.WriteLine("3- Chute Baixo");
                        ataque = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"Personagem {persona1.nome}, qual será sua defesa ? 1, 2 ou 3 ?");
                        Console.WriteLine("1- defesa de soco alto;");
                        Console.WriteLine("2- defesa de soco medio;");
                        //Console.WriteLine("3- defesa de chute baixo");
                        defesa = Console.ReadLine();

                        if (ataque == defesa)
                        {
                            Console.WriteLine($" o {persona1.nome} defendeu! ERRROUUUUU");
                        }
                        else
                        {
                            Console.WriteLine($"o {persona1.nome} recebeu um dano de 25");
                            persona1.Defender(25);
                            Console.WriteLine($"a vida restante do {persona1.nome} é de: {persona1.ExibirVida()}");
                        }
                        break;
                    case "0":
                        Console.WriteLine("obrigado por usar o programa!");
                    break;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }//fim switch case


            } while (opcao != "0");



            // persona2.Defender(30);
            // Console.WriteLine($"Personagem {persona2.nome} recebeu um ataque, sua vida restante é de: {persona2.ExibirVida()}");

            // persona2.Defender(20);
            // Console.WriteLine($"Personagem {persona2.nome} recebeu um ataque, sua vida restante é de: {persona2.ExibirVida()}");

        }//fim main
    }
}