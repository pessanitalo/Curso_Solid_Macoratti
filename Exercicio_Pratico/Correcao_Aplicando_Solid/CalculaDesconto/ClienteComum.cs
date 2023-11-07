using Correcao_Aplicando_Solid.Interfaces;

namespace Correcao_Aplicando_Solid.CalculaDesconto
{
    public class ClienteComum : ICalculoDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal preco)
        {
            return (preco - (Constantes.DESCONTO_CLIENTE_COMUM * preco));
        }
    }
}
