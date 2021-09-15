namespace Pasta_aula_15_09.Models
{
    public class Pessoa
    {
        public string nome;
        public string sobrenome;
        public string telefone;
        public int idade;

        public Pessoa(string nomeDigitado, string sobrenomeDigitado, string telefoneDigitado, int idadeDigitada)
        {
            this.nome = nomeDigitado;
            this.sobrenome = sobrenomeDigitado;
            this.telefone = telefoneDigitado;
            this.idade = idadeDigitada;
        }
        public Pessoa(string nomeDigitado, string sobrenomeDigitado, int idadeDigitada)
        {
            this.nome = nomeDigitado;
            this.sobrenome = sobrenomeDigitado;
            this.idade =idadeDigitada;
        }


    }
}