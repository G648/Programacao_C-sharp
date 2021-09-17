using System;
using TsukaMotors.Models;
using System.Collections.Generic;

namespace TsukaMotors.Controllers
{
    public class CadastroControllers
    {
        public Pessoa CadastroDeUser()
        {
            Console.WriteLine("Dgite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Insira o seu Email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Digite uma senha: ");
            string senha = Console.ReadLine();

            Pessoa cadastroPessoa = new Pessoa (nome, email, senha);

            return cadastroPessoa;

        }

        public void ListarUsuarios (List<Pessoa> lista){
            foreach (var item in lista)
            {
                Console.WriteLine($"nome: {item.nome}, email: {item.email}, senha: {item.senha}");
            }
            
        }
        public void RemoverUsuario (string _nome, List <Pessoa> lista){
            Pessoa pessoaRemovida = lista.Find(pessoa => pessoa.nome == _nome);
            lista.Remove(pessoaRemovida);
        }

        public Pessoa AnalisarEmail (string _email, List <Pessoa> lista){
            Pessoa analisarEmail  = lista.Find(pessoa => pessoa.email == _email);     
            return analisarEmail;
        }

    }
}