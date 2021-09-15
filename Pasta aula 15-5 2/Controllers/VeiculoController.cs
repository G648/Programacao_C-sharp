using System;
using System.Collections.Generic;
using Pasta_aula_15_5_2.models;

namespace Pasta_aula_15_5_2.Controller

{
    public class VeiculoController
    {
        public List<Veiculo> listaveiculo = new List<Veiculo>();

        public void CadastrarVeiculo()
        {

            Console.WriteLine("digite o tipo do veiculo");
            string tipo = Console.ReadLine();

            Console.WriteLine("digite o modelo do veiculo");
            string modelo = Console.ReadLine();

            Console.WriteLine("digite a marca do veiculo");
            string marca = Console.ReadLine();

            Console.WriteLine("digite o ano do veiculo");
            int ano = int.Parse(Console.ReadLine());


            Veiculo veiculo = new Veiculo(tipo, marca, modelo, ano);

            listaveiculo.Add(veiculo);
        }
    }
}