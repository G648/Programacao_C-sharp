namespace Pasta_aula_15_5_2.models
{
    public class Veiculo
    {
        public string tipo {get ; set;}
        public string Marca {get ; set;}
        public string Modelo {get ; set;}
        public int ano {get ; set;}

        public Veiculo (string _tipo, string _marca, string _modelo, int _ano ){
            tipo = _tipo;
            Marca = _marca;
            Modelo = _modelo;
            ano = _ano;
        }
    }
}