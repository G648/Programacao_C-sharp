using System;
using Pasta_aula_15_09.Models;
using System.Collections.Generic;

namespace Pasta_aula_15_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa01 = new Pessoa("Guilherme", "Cezar", "191", 19);
            Pessoa pessoa02 = new Pessoa("teste", "opa", "195", 20);
            Pessoa pessoa03 = new Pessoa("Orivaldo", "sobre", "192", 21);
            Pessoa pessoa04 = new Pessoa("orlando", "teste", "193", 22);
            Pessoa pessoa05 = new Pessoa("inglaterra", "aoba", "194", 23);

            List<Pessoa> listaDePessoas = new List<Pessoa>();
            listaDePessoas.Add(pessoa01);
            listaDePessoas.Add(pessoa02);
            listaDePessoas.Add(pessoa03);
            listaDePessoas.Add(pessoa04);
            listaDePessoas.Add(pessoa05);
            listaDePessoas.Add(new Pessoa ("Andreia", "oliveira", "12345", 40));

            //exibir lista

            Console.WriteLine("cadastro de pessoas");
            foreach (var item in listaDePessoas)
            {
                Console.WriteLine($"nome: {item.nome}, sobrenome: {item.sobrenome}, numero: {item.telefone}, idade: {item.idade}");
            }











        }//fim main
    }
}
