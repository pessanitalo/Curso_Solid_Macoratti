namespace Exemplo03_LSP
{
    public class Pinguim : Passaro
    {
        public Pinguim(string nome) : base(nome)
        {
        }
        public override void Comer()
        {
            Console.WriteLine($"{Nome} ele come");
        }
    }
}
