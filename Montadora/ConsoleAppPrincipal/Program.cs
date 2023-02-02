using Models;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pneu pneu1 = new Pneu();
            pneu1.Aro = 16;
            pneu1.PercentualBorracha = 100;
            pneu1.Cor = "Preto";
            pneu1.VelocidadeMaxima = 150;
            pneu1.Estepe = false;
            pneu1.Estourado = false;
            pneu1.Tipo = "Carro de passeio";
            pneu1.TWI = false;
            pneu1.VelocidadeAtual =0;

            Pneu pneu2 = new Pneu();
            pneu2.Aro = 16;
            pneu2.PercentualBorracha = 100;
            pneu2.Cor = "Preto";
            pneu2.VelocidadeMaxima = 150;
            pneu2.Estepe = false;
            pneu2.Estourado = false;
            pneu2.Tipo = "Pneu de estep";
            pneu2.TWI = false;
            pneu2.VelocidadeAtual =0;


            pneu1.Girar(200);
            

            pneu1.Exibir();
            Console.WriteLine("\n");
            pneu2.Exibir();
        }
    }
}