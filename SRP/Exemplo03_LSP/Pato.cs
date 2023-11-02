namespace Exemplo03_LSP
{
    public class Pato : PassarosQueVoam
    {
        public Pato(string nome) : base(nome)
        {
        }

        public override void Voar()
        {
            Console.WriteLine($"{Nome} ele voa");
        }
    }
}
