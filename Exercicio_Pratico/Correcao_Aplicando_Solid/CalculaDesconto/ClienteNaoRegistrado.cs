using Correcao_Aplicando_Solid.Interfaces;

namespace Correcao_Aplicando_Solid.CalculaDesconto
{
    internal class ClienteNaoRegistrado : ICalculoDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal preco)
        {
            return preco;
        }
    }
}
