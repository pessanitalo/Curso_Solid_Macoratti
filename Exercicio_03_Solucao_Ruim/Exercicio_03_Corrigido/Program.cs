namespace Exercicio_03_Corrigido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICalcularImpostoPais calcular = new CalcularImpostoBrasil();
            calcular.TotalRenda = 1700;
            calcular.TotalDeducao = 100;

            CalcularImposto imposto = new CalcularImposto();
            var totalImposto = imposto.Calcular(calcular);
            Console.WriteLine($"Brasil {totalImposto}");
            Console.WriteLine();


            ICalcularImpostoPais calcularUsa = new CalcularImpostoBrasil();
            calcularUsa.TotalRenda = 2750;
            calcularUsa.TotalDeducao = 100;

            CalcularImposto impostoUsa = new CalcularImposto();
            var totalImpostoUsa = impostoUsa.Calcular(calcularUsa);
            Console.WriteLine($"USA {totalImpostoUsa}");
       
            Console.ReadKey();
        }
    }
}