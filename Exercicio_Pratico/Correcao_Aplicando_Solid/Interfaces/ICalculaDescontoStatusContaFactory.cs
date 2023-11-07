namespace Correcao_Aplicando_Solid.Interfaces
{
    public interface ICalculaDescontoStatusContaFactory
    {
        ICalculoDescontoStatusConta GetCalculoDescontoStatusConta(StatusContaCliente statusContaCliente);
    }
}
