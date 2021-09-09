namespace Aula01
{
    public class Personagem
    {
        public string nome;
        public int idade;
        public string armadura;
        public string iA;
        public int soco;
        public int chute;
        private int vida = 100;

        public void ReceberAtaque(int ataque){
            this.vida = this.vida - ataque;
        }
        public int ExibirVida(){
            return vida;
        }
    }//fim main
}