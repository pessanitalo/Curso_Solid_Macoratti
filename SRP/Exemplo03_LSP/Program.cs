namespace Exemplo03_LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PassarosQueVoam bird = new Pato("Bird");
            Passaro Donald = new Pinguim("Donald");

            bird.Voar();
            Donald.Comer();

            Console.ReadKey();
        }
    }
}