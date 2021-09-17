using System.Collections.Generic;
namespace TsukaMotors.Models

{
    public class Pessoa
    {
        //aqui será o cadastro de pessoas;

        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }

        public Pessoa(string _nome, string _email, string _senha)
        {
            nome = _nome;
            email = _email;
            senha = _senha;
        }
    }
}