namespace Exercicio_02_Corrigido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger meuLogArquivo = new FileLogger();
            ILogger meuLogConsole = new ConsoleLogger();

            Pedido pedido = new Pedido(meuLogArquivo);
            pedido.AdicionarPedido();

            Pedido pedido1 = new Pedido(meuLogConsole);
            pedido1.AdicionarPedido();

            Console.ReadLine();
        }
    }
}