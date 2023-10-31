namespace Principio_OCP
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Custo { get; set; }
        public decimal Venda { get; set; }
        public int Estoque { get; set; }
        public bool Ativo { get; set; }

        public Produto(int produtoId, string nome, string descricao, decimal custo, decimal venda, int estoque, bool ativo)
        {
            ProdutoId = produtoId;
            Nome = nome;
            Descricao = descricao;
            Custo = custo;
            Venda = venda;
            Estoque = estoque;
            Ativo = ativo;
        }
    }
}
