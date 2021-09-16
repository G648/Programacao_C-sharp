using System;
using System.Collections.Generic;
using TsukaMotors.Models;

namespace TsukaMotors.Controllers
{
    public class VeiculoController
    {
        //toda vez que instanciar um objeto será criado uma lista do zero        
        public Veiculo CadastrarVeiculo(){
            Console.WriteLine("Digite o tipo do veículo");
            string tipo = Console.ReadLine();

            Console.WriteLine("Digite o modelo do veículo");
            string modelo = Console.ReadLine();

            Console.WriteLine("Digite a marca do veículo");
            string marca = Console.ReadLine();

            Console.WriteLine("Digite o ano do veículo");
            int ano = int.Parse(Console.ReadLine());

            Veiculo veiculo = new Veiculo(tipo, marca, modelo, ano);
            
            return veiculo;

        }// fim cadastrarVeiculo

        //Método para listar os veículos

        public void ListarVeiculos(List<Veiculo> lista){
            foreach (var item in lista)
            {
                Console.WriteLine($"Marca: {item.Marca} Modelo: {item.Modelo} Ano: {item.Ano} Tipo: {item.Tipo}");
            }
        }//fim listar veículos


    }
}