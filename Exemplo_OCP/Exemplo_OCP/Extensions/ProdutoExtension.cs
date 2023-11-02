namespace Principio_OCP.Extensions
{
    public static class ProdutoExtension
    {
        public static double MargemLucro( this Produto produto)
        {
			try
			{
				var lucroLiquido = produto.Venda - produto.Custo;
				var margemLucro = lucroLiquido / produto.Custo * 100;
				return Convert.ToDouble(margemLucro);
			}
			catch (Exception)
			{

				throw new InvalidOperationException ("Erro ao calcular o lucro.");
			}
        }
    }
}
