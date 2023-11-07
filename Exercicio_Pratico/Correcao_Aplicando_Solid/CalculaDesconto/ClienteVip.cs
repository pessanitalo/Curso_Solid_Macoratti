using Correcao_Aplicando_Solid.Interfaces;

namespace Correcao_Aplicando_Solid.CalculaDesconto
{
    internal class ClienteVip : ICalculoDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal preco)
        {
            return (preco - (Constantes.DESCONTO_CLIENTE_VIP * preco));
        }
    }
}
