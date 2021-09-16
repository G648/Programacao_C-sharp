using System.Collections.Generic;
namespace TsukaMotors.Models

{
    public class Pessoa
    {
        //aqui será o cadastro de pessoas;

        public string nome { get; set; }
        public string email { get; set; }
        public int senha { get; set; }

        public Pessoa(string _nome, string _email, int _senha)
        {
            nome = _nome;
            email = _email;
            senha = _senha;
        }
    }
}