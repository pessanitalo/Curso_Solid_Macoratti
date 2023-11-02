namespace Exercicio_ISP
{
    public class CadastrarProduto : IPersistencia
    {
        public void SalvarDataBase()
        {
            Console.WriteLine("Salvar dados");
        }

        public void ValidarDados()
        {
            Console.WriteLine("Valida dados");
        }
    }
}
