using Correcao_Aplicando_Solid.Interfaces;

namespace Correcao_Aplicando_Solid
{
    public class GerenciadorDeDesconto
    {
        private readonly ICalculaDescontoFidelidade descontoFidelidade;
        private readonly ICalculaDescontoStatusContaFactory descontoStatusConta;

        public GerenciadorDeDesconto(ICalculaDescontoFidelidade descontoFidelidade, ICalculaDescontoStatusContaFactory descontoStatusConta)
        {
            this.descontoFidelidade = descontoFidelidade;
            this.descontoStatusConta = descontoStatusConta;
        }

        public decimal AplicarDesconto(decimal preco, StatusContaCliente statusContaCliente,
                 int tempoDeContaEmAnos)
        {
            decimal precoDepoisDoDesconto = 0;

            precoDepoisDoDesconto = descontoStatusConta.
                GetCalculoDescontoStatusConta(statusContaCliente).AplicarDescontoStatusConta(preco);

            precoDepoisDoDesconto = descontoFidelidade.
                AplicarDescontoFidelidade(precoDepoisDoDesconto, tempoDeContaEmAnos);

            return precoDepoisDoDesconto;
        }
    }
}
