namespace Exemplo03_LSP
{
    public class PassarosQueVoam : Passaro
    {
        public PassarosQueVoam(string nome) : base(nome)
        {
            Nome = nome;
        }

        public virtual void Voar()
        {
            Console.WriteLine($"{Nome} ele voa");
        }
    }
}
