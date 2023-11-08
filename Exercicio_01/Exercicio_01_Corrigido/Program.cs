namespace Exercicio_01_Corrigido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cliente = LocalizarCliente.ProcuraPorNome("Pedro");
            // ?. verifica se o operando esquerdo for null não avalia
            // os demais operandos e não lança NullReferenceException
            //--------------------------------------------------------
            // ?? retorna o valor do operando esquerdo se não for null
            // se for null avalia o operando direito e retorna o seu valor
            Console.WriteLine(cliente?.Nome ?? "Não localizado");
            var clientes = Cliente.GetClientes();
            var csv = GerarCsv.ExportarCSV(clientes);
            Console.WriteLine(csv);
            Console.ReadLine();
            Console.WriteLine("Hello, World!");
        }
    }
}