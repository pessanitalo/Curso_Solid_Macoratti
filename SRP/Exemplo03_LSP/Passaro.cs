namespace Exemplo03_LSP
{
    public abstract class Passaro
    {
        public string Nome { get; set; }

        protected Passaro(string nome)
        {
            Nome = nome;
        }

        public virtual void Comer()
        {
            Console.WriteLine($"{Nome} ele come");
        }
    }
}
