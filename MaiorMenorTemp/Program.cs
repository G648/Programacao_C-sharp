using System;

namespace MaiorMenorTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] mediasTemp = new double[12];
            string[] mesesDoAno = {"jan", "fev", "mar", "abr", "mai", "jun", "jul", "ago", "set", "out", "nov", "dez"};
            
            for (var i = 0; i < 12; i++)
            {
                Console.WriteLine($"digite a {i + 1}° temperatura ");
                mediasTemp[i] = double.Parse(Console.ReadLine());
            }//fim for

            double maiorTemp = mediasTemp[0];
            double menorTemp = mediasTemp[0];
            int contador = 0;
            int contadorMaior = 0;
            int contadorMenor = 0;

            foreach (var item in mediasTemp)
            {
                //fazer a listagem:
                //Console.WriteLine(item);
                if (maiorTemp < item)
                {
                    maiorTemp = item;
                    contadorMaior = contador;
                }
                if (menorTemp > item)
                {
                    menorTemp = item;
                    contadorMenor = contador;
                    contador++;
                }//fim foreach
            }//fim main
            Console.WriteLine($"A maior temperatura do mes  = {maiorTemp} e ocorreu no mes de {mesesDoAno[contadorMaior]}");
            Console.WriteLine($"A menor temperatura do mes  = {menorTemp} e ocorreu no mes de {mesesDoAno[contadorMenor]}");
        }
    }
}