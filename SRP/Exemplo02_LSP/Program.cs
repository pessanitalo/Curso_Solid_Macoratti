namespace Exemplo02_LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numeros = new int[] { 5, 7, 9, 8, 1, 6, 4 };

            
            Calculadora somaNumeros = new CalcularSoma(numeros);
            Console.WriteLine($"\n A soma de todos os numeros é: {somaNumeros.Calcular()}");

            Calculadora calcula = new CalcularSomaNumerosPares(numeros);
            Console.WriteLine($"\n A soma dos numeros pares é: {calcula.Calcular()}");
            Console.ReadKey();
        }
    }
}