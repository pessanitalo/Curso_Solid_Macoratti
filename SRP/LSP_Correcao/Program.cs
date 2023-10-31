namespace LSP_Correcao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario vendedor = new Vendedor("paulo", "vendedor");
            Funcionario gerente = new Vendedor("rodrigo", "gerente");

            var salarioVendedor = vendedor.calculaSalario(5000);
            var salarioGerente = gerente.calculaSalario(8000);

            Console.WriteLine();
            Console.WriteLine("Salario vendedor " + salarioVendedor);
            Console.WriteLine("Salario gerente " + salarioGerente);

            Console.ReadLine();

        }
    }
}