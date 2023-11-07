using Correcao_Aplicando_Solid.Interfaces;

namespace Correcao_Aplicando_Solid
{
    public class GerenciadorDeDesconto
    {
        private readonly ICalculaDescontoFidelidade descontoFidelidade;

        public GerenciadorDeDesconto(ICalculaDescontoFidelidade descontoFidelidade)
        {
            this.descontoFidelidade = descontoFidelidade;
        }

        public decimal AplicarDesconto(decimal preco, StatusContaCliente statusContaCliente,
            int tempoDeContaEmAnos)
        {
            decimal precoDepoisDoDesconto = 0;
            switch (statusContaCliente)
            {
                case StatusContaCliente.NaoRegistrado:
                    precoDepoisDoDesconto = preco;
                    break;
                case StatusContaCliente.ClienteComum:
                    precoDepoisDoDesconto = 
                    precoDepoisDoDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoDepoisDoDesconto, tempoDeContaEmAnos);
                    break;
                case StatusContaCliente.ClienteEspecial:
                    precoDepoisDoDesconto = 
                    precoDepoisDoDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoDepoisDoDesconto, tempoDeContaEmAnos);
                    break;
                case StatusContaCliente.ClienteVIP:
                    precoDepoisDoDesconto = 
                    precoDepoisDoDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoDepoisDoDesconto, tempoDeContaEmAnos); break;
                default:
                    throw new NotImplementedException();
            }
            return precoDepoisDoDesconto;
        }
    }
}
