using Principio_OCP.Extensions;

namespace Principio_OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto(1, "Caneta", "Caneta azul,", 2.00M,3.40M,100,true);
            Console.WriteLine($"Produto {produto.Nome} Lucro {produto.MargemLucro()}");

            Console.ReadLine();
        }
    }
}