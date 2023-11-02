namespace Exemplo1_LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario vendedor = new Vendedor("paulo", "vendedor");
            Funcionario gerente = new Vendedor("rodrigo", "gerente");

            Console.WriteLine(vendedor.GetType());
            Console.WriteLine(gerente.GetType());

            vendedor.calculaSalario(500);
            gerente.calculaSalario(1000);

            Console.ReadLine();
        }
    }
}