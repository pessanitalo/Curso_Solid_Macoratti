using Correcao_Aplicando_Solid.Interfaces;

namespace Correcao_Aplicando_Solid.CalculaDesconto
{
    public class ClienteNaoRegistrado : ICalculoDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal preco)
        {
            return preco;
        }
    }
}
