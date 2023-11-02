namespace Exercicio_ISP
{
    public class CadastrarCliente : IPersistencia , IMensagemEmail
    {
        public void EnviarEmail()
        {
            Console.WriteLine("Enviar email");
        }

        public void SalvarDataBase()
        {
            Console.WriteLine("Salvar dados");
        }

        public void ValidarDados()
        {
            Console.WriteLine("Validar dados");
        }
    }
}
